using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt3_kiem_tra
{
    public partial class Form1 : Form
    {
        private BindingList<Product> productList;
        private List<Product> filteredList;
        private int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            productList = new BindingList<Product>();
            filteredList = new List<Product>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup binding source
            bindingSource.DataSource = productList;
            dgvProducts.DataSource = bindingSource;

            // Add some sample data
            AddSampleData();

            // Initial display
            UpdateStatus();
            ClearForm();
        }

        private void AddSampleData()
        {
            productList.Add(new Product("SP001", "iPhone 13 Pro", "Điện thoại", 25000000, 10));
            productList.Add(new Product("SP002", "MacBook Pro M1", "Laptop", 45000000, 5));
            productList.Add(new Product("SP003", "AirPods Pro", "Phụ kiện", 7500000, 20));
            productList.Add(new Product("SP004", "Samsung Galaxy S21", "Điện thoại", 22000000, 15));
            productList.Add(new Product("SP005", "Lenovo ThinkPad", "Laptop", 28000000, 8));
        }

        private void UpdateStatus()
        {
            lblStatus.Text = $"Tổng số sản phẩm: {productList.Count}";
        }

        private void ClearForm()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            cboCategory.SelectedIndex = -1;
            picAvatar.Image = null;
            errorProvider.Clear();
            selectedIndex = -1;
            ClearFiltersAndRefresh();
        }

        private bool ValidateInput()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider.SetError(txtProductName, "Tên sản phẩm không được để trống");
                isValid = false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
            {
                errorProvider.SetError(txtUnitPrice, "Đơn giá phải lớn hơn 0");
                isValid = false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                errorProvider.SetError(txtQuantity, "Số lượng phải >= 0");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string productId = string.IsNullOrWhiteSpace(txtProductId.Text) 
                ? GenerateProductId() 
                : txtProductId.Text;

            decimal.TryParse(txtUnitPrice.Text, out decimal price);
            int.TryParse(txtQuantity.Text, out int qty);

            var product = new Product(
                productId,
                txtProductName.Text,
                cboCategory.SelectedIndex >= 0 ? cboCategory.SelectedItem.ToString() : "",
                price,
                qty,
                picAvatar.ImageLocation ?? ""
            );

            productList.Add(product);
            UpdateStatus();
            ClearForm();
            MessageBox.Show("Thêm sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerateProductId()
        {
            int maxId = 0;
            foreach (var product in productList)
            {
                if (product.ProductId.StartsWith("SP"))
                {
                    if (int.TryParse(product.ProductId.Substring(2), out int id))
                    {
                        maxId = Math.Max(maxId, id);
                    }
                }
            }
            return $"SP{(maxId + 1).ToString("D3")}";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput())
                return;

            decimal.TryParse(txtUnitPrice.Text, out decimal price);
            int.TryParse(txtQuantity.Text, out int qty);

            productList[selectedIndex].ProductName = txtProductName.Text;
            productList[selectedIndex].Category = cboCategory.SelectedIndex >= 0 ? cboCategory.SelectedItem.ToString() : "";
            productList[selectedIndex].UnitPrice = price;
            productList[selectedIndex].Quantity = qty;
            if (picAvatar.ImageLocation != null)
                productList[selectedIndex].ImagePath = picAvatar.ImageLocation;

            bindingSource.ResetBindings(false);
            UpdateStatus();
            ClearForm();
            MessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productList.RemoveAt(selectedIndex);
                UpdateStatus();
                ClearForm();
                MessageBox.Show("Xóa sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedIndex = e.RowIndex;
            var product = productList[selectedIndex];

            txtProductId.Text = product.ProductId;
            txtProductName.Text = product.ProductName;
            cboCategory.SelectedItem = product.Category;
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtQuantity.Text = product.Quantity.ToString();

            if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
            {
                picAvatar.ImageLocation = product.ImagePath;
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAvatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            filteredList = productList
                .Where(p => p.ProductName.ToLower().Contains(searchText))
                .ToList();

            bindingSource.DataSource = filteredList.Any() ? new BindingList<Product>(filteredList) : new BindingList<Product>();
        }

        private void ClearFiltersAndRefresh()
        {
            txtSearch.Clear();
            bindingSource.DataSource = productList;
        }

        private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        writer.WriteLine("Mã SP,Tên SP,Danh Mục,Đơn Giá,Số Lượng");
                        foreach (var product in productList)
                        {
                            writer.WriteLine($"\"{product.ProductId}\",\"{product.ProductName}\",\"{product.Category}\",{product.UnitPrice},{product.Quantity}");
                        }
                    }
                    MessageBox.Show($"Xuất CSV thành công!\nFile: {saveFileDialog.FileName}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // TableLayoutPanel sẽ tự động điều chỉnh nhờ Dock = Fill
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            // Validation sẽ check khi nhấn Add/Update
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            // Validation sẽ check khi nhấn Add/Update
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            // Validation sẽ check khi nhấn Add/Update
        }
    }
}
