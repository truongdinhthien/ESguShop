using BUS.Catalogs.Interfaces;
using BUS.Orders.Interfaces;
using Core.Entities;
using Core.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productService;
        private readonly IComboService _comboService;
        private readonly IOrderService _orderService;

        private OperationType ProductMode = OperationType.View;
        private OperationType ComboMode = OperationType.View;

        public Form1(IProductService productService, IComboService comboService, IOrderService orderService)
        {
            InitializeComponent();
            _productService = productService;
            _comboService = comboService;
            _orderService = orderService;

            cbProductType.DataSource = Enum.GetValues(typeof(ProductType));
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            await LoadProductDataGridViewAsync();
        }

        public async Task LoadProductDataGridViewAsync()
        {
            dgvProduct.ShowLoading(true);

            var products = await _productService.ListAsync();
            List<object> data = new List<object>();
            foreach (var product in products)
            {
                data.Add(new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Quantity,
                    product.Producer,
                    Typename = Enum.GetName(typeof(ProductType), product.Type),
                    product.Description,
                });
            }

            dgvProduct.ShowLoading(false);

            dgvProduct.Columns.Add("Id", "Mã");
            dgvProduct.Columns.Add("Name", "Tên");
            dgvProduct.Columns.Add("Price", "Giá");
            dgvProduct.Columns.Add("Quantity", "số lượng");
            dgvProduct.Columns.Add("Producer", "Nhà cung cấp");
            dgvProduct.Columns.Add("TypeName", "Loại");
            dgvProduct.Columns.Add("Description", "Mô tả");

            dgvProduct.Columns["Price"].DefaultCellStyle.Format = "N0";

            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dgvProduct.DataSource = data;

        }

        public async Task LoadComboDataGridViewAsync()
        {
            dgvCombo.ShowLoading(true);

            var combos = await _comboService.ListAsync();
            List<object> data = new List<object>();
            foreach (var combo in combos)
            {
                data.Add(new
                {
                    combo.Id,
                    combo.Name,
                    combo.Price
                });
            }

            dgvCombo.ShowLoading(false);

            dgvCombo.Columns.Add("Id", "Mã");
            dgvCombo.Columns.Add("Name", "Tên");
            dgvCombo.Columns.Add("Price", "Giá");

            dgvProduct.Columns["Price"].DefaultCellStyle.Format = "N0";

            foreach (DataGridViewColumn column in dgvCombo.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dgvCombo.DataSource = data;

        }

        public async Task LoadProductCountHistoryDataGridViewAsync(string productId)
        {
            dgvProductCountHistory.ShowLoading(true);

            var histories = await _productService.ListHistoryAsync(productId);
            List<object> data = new List<object>();
            foreach (var history in histories)
            {
                data.Add(new
                {
                    history.Id,
                    history.Quantity,
                    history.DateChange
                });
            }

            dgvProductCountHistory.ShowLoading(false);

            dgvProductCountHistory.Columns.Add("Id", "Mã");
            dgvProductCountHistory.Columns.Add("Quantity", "số lượng");
            dgvProductCountHistory.Columns.Add("DateChange", "Ngày thay đổi");

            dgvProductCountHistory.Columns["DateChange"].DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (DataGridViewColumn column in dgvProductCountHistory.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dgvProductCountHistory.DataSource = data;
        }

        public void SetProductMode(OperationType productMode)
        {
            ProductMode = productMode;
            switch (ProductMode)
            {
                case OperationType.View:
                    btnProductCancel.Visible = false;
                    btnProductSave.Visible = false;

                    btnProductAdd.Visible = true;
                    //btnProductDelete.Visible = true;
                    btnProductEdit.Visible = true;

                    txProductName.Enabled = false;
                    txProductProducer.Enabled = false;
                    txProductPrice.Enabled = false;
                    txProductCurrentCount.Enabled = false;
                    txProductDescription.Enabled = false;
                    cbProductType.Enabled = false;
                    break;
                case OperationType.Add:
                    btnProductCancel.Visible = true;
                    btnProductSave.Visible = true;

                    btnProductAdd.Visible = false;
                    //btnProductDelete.Visible = false;
                    btnProductEdit.Visible = false;

                    txProductName.Enabled = true;
                    txProductProducer.Enabled = true;
                    txProductPrice.Enabled = true;
                    txProductCurrentCount.Enabled = true;
                    txProductDescription.Enabled = true;
                    cbProductType.Enabled = true;

                    txProductId.Text = null;
                    txProductName.Text = null;
                    cbProductType.SelectedItem = ProductType.Misc;
                    txProductProducer.Text = null;
                    txProductPrice.Text = null;
                    txProductCurrentCount.Text = null;
                    txProductDescription.Text = null;
                    break;
                case OperationType.Edit:
                    btnProductCancel.Visible = true;
                    btnProductSave.Visible = true;

                    btnProductAdd.Visible = false;
                    //btnProductDelete.Visible = false;
                    btnProductEdit.Visible = false;

                    txProductName.Enabled = true;
                    txProductProducer.Enabled = true;
                    txProductPrice.Enabled = true;
                    txProductCurrentCount.Enabled = true;
                    txProductDescription.Enabled = true;
                    cbProductType.Enabled = true;
                    break;
            }
        }

        public void SetComboMode(OperationType comboMode)
        {
            ComboMode = comboMode;
            switch (ComboMode)
            {
                case OperationType.View:
                    btnComboCancel.Visible = false;
                    btnComboSave.Visible = false;

                    btnComboAdd.Visible = true;
                    btnComboEdit.Visible = true;
                    //btnComboDelete.Visible = true;

                    txComboName.Enabled = false;
                    txComboPrice.Enabled = false;
                    break;
                case OperationType.Add:
                    btnComboCancel.Visible = true;
                    btnComboSave.Visible = true;

                    btnComboAdd.Visible = false;
                    btnComboEdit.Visible = false;
                    //btnComboDelete.Visible = false;

                    txComboName.Enabled = true;
                    txComboPrice.Enabled = true;

                    txComboId.Text = null;
                    txComboName.Text = null;
                    txComboPrice.Text = null;
                    break;
                case OperationType.Edit:
                    btnComboCancel.Visible = true;
                    btnComboSave.Visible = true;

                    btnComboAdd.Visible = false;
                    btnComboEdit.Visible = false;
                    //btnComboDelete.Visible = false;

                    txComboName.Enabled = true;
                    txComboPrice.Enabled = true;
                    break;
            }
        }

        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 0 || dgvProduct.SelectedRows[0].Index < 0)
            {
                //No rows are selected
                //btnProductDelete.Enabled = false;
                btnProductEdit.Enabled = false;

                dgvProductCountHistory.Refresh();

                txProductId.Text = null;
                txProductName.Text = null;
                cbProductType.SelectedItem = ProductType.Misc;
                txProductProducer.Text = null;
                txProductPrice.Text = null;
                txProductCurrentCount.Text = null;
                txProductDescription.Text = null;

                return;
            }
            //btnProductDelete.Enabled = true;
            btnProductEdit.Enabled = true;

            var rowIndex = dgvProduct.SelectedRows[0].Index;
            var row = dgvProduct.Rows[rowIndex];

            txProductId.Text = row.Cells["Id"].Value?.ToString();
            txProductName.Text = row.Cells["Name"].Value?.ToString();
            cbProductType.SelectedIndex = cbProductType.FindString(row.Cells["TypeName"].Value?.ToString());
            txProductProducer.Text = row.Cells["Producer"].Value?.ToString();
            txProductPrice.Text = row.Cells["Price"].Value?.ToString();
            txProductCurrentCount.Text = row.Cells["Quantity"].Value?.ToString();
            txProductDescription.Text = row.Cells["Description"].Value?.ToString();

            var productId = txProductId.Text;

            LoadProductCountHistoryDataGridViewAsync(productId).ConfigureAwait(true);
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            SetProductMode(OperationType.Add);
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            SetProductMode(OperationType.Edit);
        }

        private async void btnProductCancel_Click(object sender, EventArgs e)
        {
            SetProductMode(OperationType.View);
            await LoadProductDataGridViewAsync();
        }

        private bool validateProduct()
        {
            var isValid = true;

            var name = txProductName.Text;
            var producer = txProductProducer.Text;
            var price = txProductPrice.Text;
            var quantity = txProductCurrentCount.Text;

            if (string.IsNullOrEmpty(name))
            {
                isValid = false;
                MessageBox.Show("Tên không được bỏ trống");
            }
            if (string.IsNullOrEmpty(producer))
            {
                isValid = false;
                MessageBox.Show("Nhà cung cấp không được bỏ trống");
            }
            if (!decimal.TryParse(price, out decimal tmpPrice) || tmpPrice < 0)
            {
                isValid = false;
                MessageBox.Show("Gía không hợp lệ");
            }

            if (!int.TryParse(quantity, out int tmpQuantity) || tmpQuantity < 0)
            {
                isValid = false;
                MessageBox.Show("Số lượng không hợp lệ");
            }

            return isValid;
        }

        private async void btnProductSave_Click(object sender, EventArgs e)
        {
            if (ProductMode == OperationType.Add && validateProduct())
            {
                var name = txProductName.Text;
                var producer = txProductProducer.Text;
                var price = txProductPrice.Text;
                var quantity = txProductCurrentCount.Text;
                var description = txProductDescription.Text;
                var type = (ProductType)cbProductType.SelectedItem;

                var product = new Product
                {
                    Name = name,
                    Producer = producer,
                    Price = decimal.Parse(price),
                    Quantity = int.Parse(quantity),
                    Description = description,
                    Type = type,
                };

                await _productService.AddAsync(product);
                MessageBox.Show("Thêm thành công");
                SetProductMode(OperationType.View);
                await LoadProductDataGridViewAsync();
            }
            if (ProductMode == OperationType.Edit && validateProduct())
            {


                var name = txProductName.Text;
                var producer = txProductProducer.Text;
                var price = txProductPrice.Text;
                var quantity = txProductCurrentCount.Text;
                var description = txProductDescription.Text;
                var type = (ProductType)cbProductType.SelectedItem;


                var productId = txProductId.Text;
                var product = await _productService.GetByIdAsync(productId);

                if (int.Parse(quantity) != product.Quantity)
                {
                    var storage = new Storage
                    {
                        ProductId = productId,
                        Quantity = int.Parse(quantity),
                        DateChange = DateTime.Today
                    };

                    await _productService.AddHistoryAsync(storage);
                }

                product.Name = name;
                product.Producer = producer;
                product.Price = decimal.Parse(price);
                product.Quantity = int.Parse(quantity);
                product.Description = description;
                product.Type = type;

                await _productService.UpdateAsync(product);
                MessageBox.Show("Cập nhật thành công");
                SetProductMode(OperationType.View);
                await LoadProductDataGridViewAsync();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[0])
            { }
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                LoadComboDataGridViewAsync().ConfigureAwait(true);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages[2])
            {
                LoadOrderDataGridViewAsync().ConfigureAwait(true);
            }


        }

        private async void dgvCombo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCombo.SelectedRows.Count == 0 || dgvCombo.SelectedRows[0].Index < 0)
            {
                //No rows are selected
                btnComboEdit.Enabled = false;
                //btnComboDelete.Enabled = false;

                dgvComboDetail.Refresh();

                txComboId.Text = null;
                txComboName.Text = null;
                txComboPrice.Text = null;

                return;
            }
            btnComboEdit.Enabled = true;
            //btnComboDelete.Enabled = true;

            var rowIndex = dgvCombo.SelectedRows[0].Index;
            var row = dgvCombo.Rows[rowIndex];

            txComboId.Text = row.Cells["Id"].Value?.ToString();
            txComboName.Text = row.Cells["Name"].Value?.ToString();
            txComboPrice.Text = row.Cells["Price"].Value?.ToString();

            var comboId = txComboId.Text;
            await LoadComboDetailDataGridViewAsync(comboId);
            await LoadComboDetailProducts();
        }

        public async Task LoadComboDetailDataGridViewAsync(string comboId)
        {
            dgvComboDetail.ShowLoading(true);

            var products = await _productService.ListAsync(comboId);
            List<object> data = new List<object>();
            foreach (var product in products)
            {
                data.Add(new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Quantity,
                    product.Producer,
                    product.TypeName,
                    product.Description,
                });
            }

            dgvComboDetail.ShowLoading(false);

            dgvComboDetail.Columns.Add("Id", "Mã");
            dgvComboDetail.Columns.Add("Name", "Tên");
            dgvComboDetail.Columns.Add("Price", "Giá");
            dgvComboDetail.Columns.Add("Quantity", "số lượng");
            dgvComboDetail.Columns.Add("Producer", "Nhà cung cấp");
            dgvComboDetail.Columns.Add("TypeName", "Loại");
            dgvComboDetail.Columns.Add("Description", "Mô tả");

            dgvComboDetail.Columns["Price"].DefaultCellStyle.Format = "N0";

            foreach (DataGridViewColumn column in dgvComboDetail.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dgvComboDetail.DataSource = data;
        }

        private async void btnComboCancel_Click(object sender, EventArgs e)
        {
            SetComboMode(OperationType.View);
            await LoadComboDataGridViewAsync();
        }

        private bool validateCombo()
        {
            var isValid = true;

            var name = txComboName.Text;
            var price = txComboPrice.Text;

            if (string.IsNullOrEmpty(name))
            {
                isValid = false;
                MessageBox.Show("Tên không được bỏ trống");
            }

            if (!decimal.TryParse(price, out decimal tmpPrice) || tmpPrice < 0)
            {
                isValid = false;
                MessageBox.Show("Gía không hợp lệ");
            }

            return isValid;
        }

        private async void btnComboSave_Click(object sender, EventArgs e)
        {
            if (ComboMode == OperationType.Add && validateCombo())
            {
                var name = txComboName.Text;
                var price = txComboPrice.Text;

                var combo = new Combo
                {
                    Name = name,
                    Price = decimal.Parse(price),
                };


                await _comboService.AddAsync(combo);
                MessageBox.Show("Thêm thành công");
                SetComboMode(OperationType.View);
                await LoadComboDataGridViewAsync();
            }
            if (ComboMode == OperationType.Edit && validateCombo())
            {
                var name = txComboName.Text;
                var price = txComboPrice.Text;

                var comboId = txComboId.Text;
                var combo = await _comboService.GetByIdAsync(comboId);

                combo.Name = name;
                combo.Price = decimal.Parse(price);

                await _comboService.UpdateAsync(combo);
                MessageBox.Show("Cập nhật thành công");
                SetComboMode(OperationType.View);
                await LoadComboDataGridViewAsync();
            }
        }

        private void btnComboAdd_Click(object sender, EventArgs e)
        {
            SetComboMode(OperationType.Add);
        }

        private void btnComboEdit_Click(object sender, EventArgs e)
        {
            SetComboMode(OperationType.Edit);
        }

        private async Task LoadComboDetailProducts()
        {
            var comboId = txComboId.Text;
            var products = await _productService.ListProductNotInComboAsync(comboId);
            if (products != null)
            {
                cbComboDetailProducts.DataSource = products;
            }
            else
            {
                cbComboDetailProducts.DataSource = new List<object>();
            }
            cbComboDetailProducts.DisplayMember = "Name";
            cbComboDetailProducts.ValueMember = "Id";
        }

        private async void btnComboDetailAdd_Click(object sender, EventArgs e)
        {
            var productId = (string)cbComboDetailProducts.SelectedValue;
            var quantity = txComboDetailProductCount.Text;
            if (!int.TryParse(quantity, out int tmpQuantity) || tmpQuantity < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }

            var comboId = txComboId.Text;
            await _comboService.AddProductToComboAsync(comboId, productId, tmpQuantity);
            await LoadComboDataGridViewAsync();
        }

        private async void btnComboDetailDelete_Click(object sender, EventArgs e)
        {
            if (dgvComboDetail.SelectedRows.Count == 0 || dgvComboDetail.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
                return;
            }


            var rowIndex = dgvComboDetail.SelectedRows[0].Index;
            var row = dgvComboDetail.Rows[rowIndex];

            var comboId = txComboId.Text;
            var productId = row.Cells["Id"].Value?.ToString();
            await _comboService.RemoveProductToComboAsync(comboId, productId);
            MessageBox.Show("Đã xóa thành công");
            await LoadComboDataGridViewAsync();

        }

        public async Task LoadOrderDataGridViewAsync()
        {
            dgvOrder.ShowLoading(true);

            var orders = await _orderService.GetOrdersAsync();
            List<object> data = new List<object>();
            foreach (var order in orders)
            {
                data.Add(new
                {
                    order.TotalPrice,
                    order.DeliveryAddress,
                    order.CustomerId,
                    order.DeliveryDate
                });
            }

            dgvOrder.ShowLoading(false);

            dgvOrder.Columns.Add("CustomerId", "Mã");
            dgvOrder.Columns.Add("TotalPrice", "Tên");
            dgvOrder.Columns.Add("DeliveryAddress", "Giá");
            dgvOrder.Columns.Add("DeliveryDate", "số lượng");


            dgvOrder.Columns["TotalPrice"].DefaultCellStyle.Format = "N0";

            foreach (DataGridViewColumn column in dgvOrder.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            dgvOrder.DataSource = data;
        }
    }
}
