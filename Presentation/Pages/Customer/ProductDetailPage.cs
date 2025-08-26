using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using DAL.Models;

namespace Presentation.Pages.Customer
{
    public partial class ProductDetailPage : Form
    {
        private readonly IProductService _productService;
        private readonly int _productId;

        public ProductDetailPage(int productId)
        {
            InitializeComponent();
            _productService = new ProductService(new DAL.Repositories.ProductRepository());
            _productId = productId;
            Load += ProductDetailPage_Load;
        }

        private async void ProductDetailPage_Load(object? sender, EventArgs e)
        {
            await LoadProductDetailAsync(_productId);
        }

        private async Task LoadProductDetailAsync(int productId)
        {
            try
            {
                var product = await _productService.GetByIdAsync(productId);
                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }

                labelName.Text = product.ProductName ?? "(Không tên)";
                labelCategory.Text = product.Category?.CategoryName ?? "(Không danh mục)";
                labelStatus.Text = product.Status?.StatusName ?? "(Không trạng thái)";
                labelPrice.Text = $"Giá bán: {(product.SellPrice ?? 0):N0} ₫";
                labelMarketPrice.Text = $"Giá thị trường: {(product.MarketPrice ?? 0):N0} ₫";
                labelStock.Text = $"Tồn kho: {product.ProductInStock}";
                labelSold.Text = $"Đã bán: {product.SoldCount}";
                labelStockInDate.Text = product.StockInDate.HasValue ? $"Ngày nhập: {product.StockInDate:dd/MM/yyyy}" : "Ngày nhập: -";
                textDescription.Text = product.Description ?? string.Empty;

                // Ảnh từ Resources theo tên trong product.Img
                var resImg = Presentation.Services.ResourceImageLoader.LoadByFileName(product.Img);
                if (resImg != null)
                {
                    pictureBox.Image = resImg;
                    pictureBox.BackColor = Color.White;
                }
                else
                {
                    pictureBox.Image = null;
                    pictureBox.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải chi tiết sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductPage());
        }
    }
}


