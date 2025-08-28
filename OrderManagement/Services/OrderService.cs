using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OrderManagement.Services
{
    internal class OrderService
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        public DataTable GetAllOrders()
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    o.order_id, 
                    u.fullname, 
                    u.phone,
                    u.email,
                    u.address,
                    o.order_date, 
                    o.order_total,
                    os.status,
                    cr.description as cancel_reason
                FROM 
                    orders o
                JOIN 
                    users u ON o.user_id = u.user_id
                LEFT JOIN 
                    order_status os ON o.order_id = os.order_id
                LEFT JOIN
                    cancel_reason cr ON o.cancel_reason_id = cr.cancel_id
                ORDER BY
                    o.order_date DESC;";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetOrderDetails(int orderId)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    od.orderDetail_id,
                    p.product_name,
                    od.quantity,
                    od.price
                FROM 
                    order_details od
                JOIN 
                    products p ON od.product_id = p.product_id
                WHERE 
                    od.order_id = @orderId";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        // Phương thức mới để lấy thông tin người dùng (không lấy address)
        public DataTable GetUserById(int userId)
        {
            DataTable dt = new DataTable();
            string query = "SELECT fullname, phone, email FROM users WHERE user_id = @userId";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        public bool DeleteOrder(int orderId)
        {
            try
            {
                string query = "DELETE FROM orders WHERE order_id = @orderId";
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa đơn hàng: " + ex.Message);
                return false;
            }
        }

        public bool UpdateOrderStatus(int orderId, string status)
        {
            try
            {
                string query = "UPDATE order_status SET status = @status WHERE order_id = @orderId";
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@status", status);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật trạng thái đơn hàng: " + ex.Message);
                return false;
            }
        }

        public bool AddOrder(Order order)
        {
            try
            {
                string query = @"
            INSERT INTO orders (user_id, order_date, shipping_address, order_total)
            VALUES (@userId, @orderDate, @shippingAddress, @orderTotal)";
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", order.UserId);
                    cmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
                    cmd.Parameters.AddWithValue("@shippingAddress", order.ShippingAddress);
                    cmd.Parameters.AddWithValue("@orderTotal", order.OrderTotal);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm đơn hàng: " + ex.Message);
                return false;
            }
        }

        public Order GetOrderById(int orderId)
        {
            Order order = null;
            string query = "SELECT * FROM orders WHERE order_id = @orderId";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    order = new Order
                    {
                        OrderId = Convert.ToInt32(reader["order_id"]),
                        UserId = Convert.ToInt32(reader["user_id"]),
                        OrderDate = Convert.ToDateTime(reader["order_date"]),
                        ShippingAddress = reader["shipping_address"] as string,
                        OrderTotal = Convert.ToDecimal(reader["order_total"]),
                        CancelReasonId = reader["cancel_reason_id"] as int?
                    };
                }
            }
            return order;
        }

        public bool UpdateOrder(Order order)
        {
            try
            {
                string query = @"
                    UPDATE orders
                    SET user_id = @userId,
                        order_date = @orderDate,
                        shipping_address = @shippingAddress,
                        order_total = @orderTotal,
                        cancel_reason_id = @cancelReasonId
                    WHERE order_id = @orderId";
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderId", order.OrderId);
                    cmd.Parameters.AddWithValue("@userId", order.UserId);
                    cmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
                    cmd.Parameters.AddWithValue("@shippingAddress", order.ShippingAddress);
                    cmd.Parameters.AddWithValue("@orderTotal", order.OrderTotal);
                    if (order.CancelReasonId.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@cancelReasonId", order.CancelReasonId.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@cancelReasonId", DBNull.Value);
                    }
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật đơn hàng: " + ex.Message);
                return false;
            }
        }

        public DataTable GetCategories()
        {
            DataTable dt = new DataTable();
            string query = "SELECT category_id, category_name FROM categories";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetFilteredOrders(string searchTerm = null, int? categoryId = null)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    o.order_id, 
                    u.fullname, 
                    u.phone,
                    u.address,
                    o.order_total,
                    os.status
                FROM 
                    orders o
                JOIN 
                    users u ON o.user_id = u.user_id
                LEFT JOIN 
                    order_status os ON o.order_id = os.order_id";

            // Bổ sung các bảng cần thiết cho việc lọc
            if (!string.IsNullOrEmpty(searchTerm) || categoryId.HasValue)
            {
                query += @"
                LEFT JOIN
                    order_details od ON o.order_id = od.order_id
                LEFT JOIN
                    products p ON od.product_id = p.product_id";
            }

            // Thêm điều kiện lọc
            query += " WHERE 1=1";
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " AND (o.order_id LIKE @searchTerm OR u.fullname LIKE @searchTerm OR p.product_name LIKE @searchTerm)";
            }

            if (categoryId.HasValue)
            {
                query += " AND p.category_id = @categoryId";
            }

            query += " GROUP BY o.order_id, u.fullname, u.phone, u.address, o.order_total, os.status";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }
                if (categoryId.HasValue)
                {
                    cmd.Parameters.AddWithValue("@categoryId", categoryId.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }
    }
}