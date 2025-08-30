using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Pages.Customer
{
    partial class CustomerListPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.Button buttonViewDetail;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.buttonViewDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            this.SuspendLayout();
            //
            // textBoxSearch
            //
            this.textBoxSearch.Left = 20;
            this.textBoxSearch.Top = 20;
            this.textBoxSearch.Width = 300;
            //
            // buttonSearch
            //
            this.buttonSearch.Left = 330;
            this.buttonSearch.Top = 18;
            this.buttonSearch.Width = 100;
            this.buttonSearch.Text = "Tìm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            //
            // gridCustomers
            //
            this.gridCustomers.Left = 20;
            this.gridCustomers.Top = 60;
            this.gridCustomers.Width = 820;
            this.gridCustomers.Height = 440;
            this.gridCustomers.ReadOnly = true;
            this.gridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomers.MultiSelect = false;
            this.gridCustomers.AutoGenerateColumns = false;
            this.gridCustomers.AllowUserToAddRows = false;
            this.gridCustomers.AllowUserToDeleteRows = false;
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn {HeaderText = "ID", DataPropertyName = "UserId ", Width = 60 });
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Tên đăng nhập", DataPropertyName = "Username", Width = 150 });
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn {HeaderText = "Họ tên", DataPropertyName = "Fullname", Width = 200 });
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn {HeaderText = "Email", DataPropertyName = "Email", Width = 200 });
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn {HeaderText = "Điện thoại", DataPropertyName = "Phone", Width = 120 });
            //
            // buttonViewDetail
            //
            this.buttonViewDetail.Left = 20;
            this.buttonViewDetail.Top = 510;
            this.buttonViewDetail.Width = 160;
            this.buttonViewDetail.Text = "Xem chi tiết";
            this.buttonViewDetail.UseVisualStyleBackColor = true;
            this.buttonViewDetail.Click += new System.EventHandler(this.ButtonViewDetail_Click);
            //
            // CustomerListPage
            //
            this.Text = "Quản lý khách hàng";
            this.Width = 900;
            this.Height = 600;
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.buttonViewDetail);
            this.ResumeLayout(false);

        }
        #endregion
    }
}