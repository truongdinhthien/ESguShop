
namespace WinformUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.product = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductCountHistory = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txProductId = new System.Windows.Forms.TextBox();
            this.txProductName = new System.Windows.Forms.TextBox();
            this.txProductProducer = new System.Windows.Forms.TextBox();
            this.txProductPrice = new System.Windows.Forms.TextBox();
            this.txProductCurrentCount = new System.Windows.Forms.TextBox();
            this.txProductDescription = new System.Windows.Forms.TextBox();
            this.txProductType = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.combo = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnComboDetailDelete = new System.Windows.Forms.Button();
            this.btnComboDetailEdit = new System.Windows.Forms.Button();
            this.btnComboDetailAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbComboDetailProducts = new System.Windows.Forms.ComboBox();
            this.txComboDetailProductCount = new System.Windows.Forms.TextBox();
            this.dgvComboDetail = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnComboDelete = new System.Windows.Forms.Button();
            this.btnComboEdit = new System.Windows.Forms.Button();
            this.btnComboAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txComboId = new System.Windows.Forms.TextBox();
            this.txComboName = new System.Windows.Forms.TextBox();
            this.txComboPrice = new System.Windows.Forms.TextBox();
            this.dgvCombo = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOrderCancel = new System.Windows.Forms.Button();
            this.btnOrderSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txOrderCustomer = new System.Windows.Forms.TextBox();
            this.txOrderDeliveryDate = new System.Windows.Forms.TextBox();
            this.txOrderDeliveryAddress = new System.Windows.Forms.TextBox();
            this.txOrderPrice = new System.Windows.Forms.TextBox();
            this.cbOrderStatus = new System.Windows.Forms.ComboBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.product.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCountHistory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.combo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboDetail)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombo)).BeginInit();
            this.order.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.product);
            this.tabControl1.Controls.Add(this.combo);
            this.tabControl1.Controls.Add(this.order);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // product
            // 
            this.product.Controls.Add(this.groupBox2);
            this.product.Controls.Add(this.groupBox1);
            this.product.Controls.Add(this.dgvProduct);
            this.product.Location = new System.Drawing.Point(4, 29);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(3);
            this.product.Size = new System.Drawing.Size(902, 507);
            this.product.TabIndex = 0;
            this.product.Text = "Sản phẩm";
            this.product.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductCountHistory);
            this.groupBox2.Location = new System.Drawing.Point(462, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 272);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử số lượng";
            // 
            // dgvProductCountHistory
            // 
            this.dgvProductCountHistory.AllowUserToAddRows = false;
            this.dgvProductCountHistory.AllowUserToDeleteRows = false;
            this.dgvProductCountHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductCountHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductCountHistory.Location = new System.Drawing.Point(3, 23);
            this.dgvProductCountHistory.Name = "dgvProductCountHistory";
            this.dgvProductCountHistory.ReadOnly = true;
            this.dgvProductCountHistory.RowHeadersWidth = 51;
            this.dgvProductCountHistory.RowTemplate.Height = 29;
            this.dgvProductCountHistory.Size = new System.Drawing.Size(431, 246);
            this.dgvProductCountHistory.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProductAdd);
            this.groupBox1.Controls.Add(this.btnProductEdit);
            this.groupBox1.Controls.Add(this.btnProductDelete);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(463, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(336, 179);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(94, 29);
            this.btnProductAdd.TabIndex = 3;
            this.btnProductAdd.Text = "Thêm";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.Location = new System.Drawing.Point(235, 179);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(94, 29);
            this.btnProductEdit.TabIndex = 2;
            this.btnProductEdit.Text = "Sửa";
            this.btnProductEdit.UseVisualStyleBackColor = true;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(134, 179);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(94, 29);
            this.btnProductDelete.TabIndex = 1;
            this.btnProductDelete.Text = "Xóa";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txProductId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txProductName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txProductProducer, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txProductPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txProductCurrentCount, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txProductDescription, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txProductType, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 146);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "NSX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Còn";
            // 
            // txProductId
            // 
            this.txProductId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txProductId.Location = new System.Drawing.Point(66, 3);
            this.txProductId.Name = "txProductId";
            this.txProductId.Size = new System.Drawing.Size(142, 27);
            this.txProductId.TabIndex = 7;
            // 
            // txProductName
            // 
            this.txProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txProductName.Location = new System.Drawing.Point(277, 3);
            this.txProductName.Name = "txProductName";
            this.txProductName.Size = new System.Drawing.Size(143, 27);
            this.txProductName.TabIndex = 8;
            // 
            // txProductProducer
            // 
            this.txProductProducer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txProductProducer.Location = new System.Drawing.Point(277, 39);
            this.txProductProducer.Name = "txProductProducer";
            this.txProductProducer.Size = new System.Drawing.Size(143, 27);
            this.txProductProducer.TabIndex = 9;
            // 
            // txProductPrice
            // 
            this.txProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txProductPrice.Location = new System.Drawing.Point(66, 75);
            this.txProductPrice.Name = "txProductPrice";
            this.txProductPrice.Size = new System.Drawing.Size(142, 27);
            this.txProductPrice.TabIndex = 10;
            // 
            // txProductCurrentCount
            // 
            this.txProductCurrentCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txProductCurrentCount.Location = new System.Drawing.Point(277, 75);
            this.txProductCurrentCount.Name = "txProductCurrentCount";
            this.txProductCurrentCount.Size = new System.Drawing.Size(143, 27);
            this.txProductCurrentCount.TabIndex = 11;
            // 
            // txProductDescription
            // 
            this.txProductDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txProductDescription.Location = new System.Drawing.Point(66, 111);
            this.txProductDescription.Name = "txProductDescription";
            this.txProductDescription.Size = new System.Drawing.Size(142, 27);
            this.txProductDescription.TabIndex = 12;
            // 
            // txProductType
            // 
            this.txProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txProductType.Location = new System.Drawing.Point(66, 39);
            this.txProductType.Name = "txProductType";
            this.txProductType.Size = new System.Drawing.Size(142, 27);
            this.txProductType.TabIndex = 13;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(9, 4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(447, 495);
            this.dgvProduct.TabIndex = 0;
            // 
            // combo
            // 
            this.combo.Controls.Add(this.groupBox4);
            this.combo.Controls.Add(this.groupBox3);
            this.combo.Controls.Add(this.dgvCombo);
            this.combo.Location = new System.Drawing.Point(4, 29);
            this.combo.Name = "combo";
            this.combo.Padding = new System.Windows.Forms.Padding(3);
            this.combo.Size = new System.Drawing.Size(902, 507);
            this.combo.TabIndex = 1;
            this.combo.Text = "Combo";
            this.combo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnComboDetailDelete);
            this.groupBox4.Controls.Add(this.btnComboDetailEdit);
            this.groupBox4.Controls.Add(this.btnComboDetailAdd);
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Controls.Add(this.dgvComboDetail);
            this.groupBox4.Location = new System.Drawing.Point(433, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 353);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sản phẩm";
            // 
            // btnComboDetailDelete
            // 
            this.btnComboDetailDelete.Location = new System.Drawing.Point(161, 97);
            this.btnComboDetailDelete.Name = "btnComboDetailDelete";
            this.btnComboDetailDelete.Size = new System.Drawing.Size(94, 29);
            this.btnComboDetailDelete.TabIndex = 7;
            this.btnComboDetailDelete.Text = "Xóa";
            this.btnComboDetailDelete.UseVisualStyleBackColor = true;
            // 
            // btnComboDetailEdit
            // 
            this.btnComboDetailEdit.Location = new System.Drawing.Point(261, 97);
            this.btnComboDetailEdit.Name = "btnComboDetailEdit";
            this.btnComboDetailEdit.Size = new System.Drawing.Size(94, 29);
            this.btnComboDetailEdit.TabIndex = 6;
            this.btnComboDetailEdit.Text = "Sửa";
            this.btnComboDetailEdit.UseVisualStyleBackColor = true;
            // 
            // btnComboDetailAdd
            // 
            this.btnComboDetailAdd.Location = new System.Drawing.Point(361, 97);
            this.btnComboDetailAdd.Name = "btnComboDetailAdd";
            this.btnComboDetailAdd.Size = new System.Drawing.Size(94, 29);
            this.btnComboDetailAdd.TabIndex = 5;
            this.btnComboDetailAdd.Text = "Thêm";
            this.btnComboDetailAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbComboDetailProducts, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txComboDetailProductCount, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(448, 64);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sản phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Số lượng";
            // 
            // cbComboDetailProducts
            // 
            this.cbComboDetailProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbComboDetailProducts.FormattingEnabled = true;
            this.cbComboDetailProducts.Location = new System.Drawing.Point(182, 3);
            this.cbComboDetailProducts.Name = "cbComboDetailProducts";
            this.cbComboDetailProducts.Size = new System.Drawing.Size(263, 28);
            this.cbComboDetailProducts.TabIndex = 2;
            // 
            // txComboDetailProductCount
            // 
            this.txComboDetailProductCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txComboDetailProductCount.Location = new System.Drawing.Point(182, 35);
            this.txComboDetailProductCount.Name = "txComboDetailProductCount";
            this.txComboDetailProductCount.Size = new System.Drawing.Size(263, 27);
            this.txComboDetailProductCount.TabIndex = 3;
            // 
            // dgvComboDetail
            // 
            this.dgvComboDetail.AllowUserToAddRows = false;
            this.dgvComboDetail.AllowUserToDeleteRows = false;
            this.dgvComboDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComboDetail.Location = new System.Drawing.Point(7, 132);
            this.dgvComboDetail.Name = "dgvComboDetail";
            this.dgvComboDetail.ReadOnly = true;
            this.dgvComboDetail.RowHeadersWidth = 51;
            this.dgvComboDetail.RowTemplate.Height = 29;
            this.dgvComboDetail.Size = new System.Drawing.Size(454, 215);
            this.dgvComboDetail.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnComboDelete);
            this.groupBox3.Controls.Add(this.btnComboEdit);
            this.groupBox3.Controls.Add(this.btnComboAdd);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(433, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 136);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin combo";
            // 
            // btnComboDelete
            // 
            this.btnComboDelete.Location = new System.Drawing.Point(361, 97);
            this.btnComboDelete.Name = "btnComboDelete";
            this.btnComboDelete.Size = new System.Drawing.Size(94, 29);
            this.btnComboDelete.TabIndex = 4;
            this.btnComboDelete.Text = "Xóa";
            this.btnComboDelete.UseVisualStyleBackColor = true;
            // 
            // btnComboEdit
            // 
            this.btnComboEdit.Location = new System.Drawing.Point(361, 61);
            this.btnComboEdit.Name = "btnComboEdit";
            this.btnComboEdit.Size = new System.Drawing.Size(94, 29);
            this.btnComboEdit.TabIndex = 3;
            this.btnComboEdit.Text = "Sửa";
            this.btnComboEdit.UseVisualStyleBackColor = true;
            // 
            // btnComboAdd
            // 
            this.btnComboAdd.Location = new System.Drawing.Point(361, 25);
            this.btnComboAdd.Name = "btnComboAdd";
            this.btnComboAdd.Size = new System.Drawing.Size(94, 29);
            this.btnComboAdd.TabIndex = 2;
            this.btnComboAdd.Text = "Thêm";
            this.btnComboAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txComboId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txComboName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txComboPrice, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 110);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Giá";
            // 
            // txComboId
            // 
            this.txComboId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txComboId.Location = new System.Drawing.Point(91, 3);
            this.txComboId.Name = "txComboId";
            this.txComboId.Size = new System.Drawing.Size(258, 27);
            this.txComboId.TabIndex = 3;
            // 
            // txComboName
            // 
            this.txComboName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txComboName.Location = new System.Drawing.Point(91, 39);
            this.txComboName.Name = "txComboName";
            this.txComboName.Size = new System.Drawing.Size(258, 27);
            this.txComboName.TabIndex = 4;
            // 
            // txComboPrice
            // 
            this.txComboPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txComboPrice.Location = new System.Drawing.Point(91, 75);
            this.txComboPrice.Name = "txComboPrice";
            this.txComboPrice.Size = new System.Drawing.Size(258, 27);
            this.txComboPrice.TabIndex = 5;
            // 
            // dgvCombo
            // 
            this.dgvCombo.AllowUserToAddRows = false;
            this.dgvCombo.AllowUserToDeleteRows = false;
            this.dgvCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombo.Location = new System.Drawing.Point(9, 4);
            this.dgvCombo.Name = "dgvCombo";
            this.dgvCombo.ReadOnly = true;
            this.dgvCombo.RowHeadersWidth = 51;
            this.dgvCombo.RowTemplate.Height = 29;
            this.dgvCombo.Size = new System.Drawing.Size(417, 495);
            this.dgvCombo.TabIndex = 0;
            // 
            // order
            // 
            this.order.Controls.Add(this.groupBox6);
            this.order.Controls.Add(this.groupBox5);
            this.order.Controls.Add(this.dgvOrder);
            this.order.Location = new System.Drawing.Point(4, 29);
            this.order.Name = "order";
            this.order.Padding = new System.Windows.Forms.Padding(3);
            this.order.Size = new System.Drawing.Size(902, 507);
            this.order.TabIndex = 2;
            this.order.Text = "Đơn hàng";
            this.order.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvOrderItem);
            this.groupBox6.Location = new System.Drawing.Point(483, 236);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(411, 263);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách hàng hóa (sản phẩm / combo)";
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.AllowUserToAddRows = false;
            this.dgvOrderItem.AllowUserToDeleteRows = false;
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItem.Location = new System.Drawing.Point(3, 23);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.RowHeadersWidth = 51;
            this.dgvOrderItem.RowTemplate.Height = 29;
            this.dgvOrderItem.Size = new System.Drawing.Size(405, 237);
            this.dgvOrderItem.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOrderCancel);
            this.groupBox5.Controls.Add(this.btnOrderSave);
            this.groupBox5.Controls.Add(this.tableLayoutPanel4);
            this.groupBox5.Location = new System.Drawing.Point(483, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(416, 226);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin đơn hàng";
            // 
            // btnOrderCancel
            // 
            this.btnOrderCancel.Location = new System.Drawing.Point(217, 191);
            this.btnOrderCancel.Name = "btnOrderCancel";
            this.btnOrderCancel.Size = new System.Drawing.Size(94, 29);
            this.btnOrderCancel.TabIndex = 2;
            this.btnOrderCancel.Text = "Hủy";
            this.btnOrderCancel.UseVisualStyleBackColor = true;
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.Location = new System.Drawing.Point(317, 191);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.Size = new System.Drawing.Size(94, 29);
            this.btnOrderSave.TabIndex = 1;
            this.btnOrderSave.Text = "Lưu";
            this.btnOrderSave.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.txOrderCustomer, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txOrderDeliveryDate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txOrderDeliveryAddress, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txOrderPrice, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.cbOrderStatus, 1, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(403, 148);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Khách";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Ngày giao";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Địa chỉ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Giá";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Trạng thái";
            // 
            // txOrderCustomer
            // 
            this.txOrderCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txOrderCustomer.Location = new System.Drawing.Point(103, 3);
            this.txOrderCustomer.Name = "txOrderCustomer";
            this.txOrderCustomer.Size = new System.Drawing.Size(297, 27);
            this.txOrderCustomer.TabIndex = 5;
            this.txOrderCustomer.Text = "KH1 - Huỳnh Văn A";
            // 
            // txOrderDeliveryDate
            // 
            this.txOrderDeliveryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txOrderDeliveryDate.Location = new System.Drawing.Point(103, 32);
            this.txOrderDeliveryDate.Name = "txOrderDeliveryDate";
            this.txOrderDeliveryDate.Size = new System.Drawing.Size(297, 27);
            this.txOrderDeliveryDate.TabIndex = 6;
            this.txOrderDeliveryDate.Text = "24/12/2020";
            // 
            // txOrderDeliveryAddress
            // 
            this.txOrderDeliveryAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txOrderDeliveryAddress.Location = new System.Drawing.Point(103, 61);
            this.txOrderDeliveryAddress.Name = "txOrderDeliveryAddress";
            this.txOrderDeliveryAddress.Size = new System.Drawing.Size(297, 27);
            this.txOrderDeliveryAddress.TabIndex = 7;
            this.txOrderDeliveryAddress.Text = "tphcm";
            // 
            // txOrderPrice
            // 
            this.txOrderPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txOrderPrice.Location = new System.Drawing.Point(103, 90);
            this.txOrderPrice.Name = "txOrderPrice";
            this.txOrderPrice.Size = new System.Drawing.Size(297, 27);
            this.txOrderPrice.TabIndex = 8;
            this.txOrderPrice.Text = "1.500.000";
            // 
            // cbOrderStatus
            // 
            this.cbOrderStatus.FormattingEnabled = true;
            this.cbOrderStatus.Location = new System.Drawing.Point(103, 119);
            this.cbOrderStatus.Name = "cbOrderStatus";
            this.cbOrderStatus.Size = new System.Drawing.Size(151, 28);
            this.cbOrderStatus.TabIndex = 9;
            this.cbOrderStatus.Text = "Đang giao";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(9, 4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 29;
            this.dgvOrder.Size = new System.Drawing.Size(467, 495);
            this.dgvOrder.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 540);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.product.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCountHistory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.combo.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboDetail)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombo)).EndInit();
            this.order.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage product;
        private System.Windows.Forms.TabPage combo;
        private System.Windows.Forms.TabPage order;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductListCountHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txProductId;
        private System.Windows.Forms.TextBox txProductName;
        private System.Windows.Forms.TextBox txProductProducer;
        private System.Windows.Forms.TextBox txProductPrice;
        private System.Windows.Forms.TextBox txProductCurrentCount;
        private System.Windows.Forms.TextBox txProductDescription;
        private System.Windows.Forms.TextBox txProductType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvComboDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tx;
        private System.Windows.Forms.TextBox txComboName;
        private System.Windows.Forms.TextBox txComboPrice;
        private System.Windows.Forms.DataGridView dgvCombo;
        private System.Windows.Forms.Button btnComboDelete;
        private System.Windows.Forms.Button btnComboEdit;
        private System.Windows.Forms.Button btnComboAdd;
        private System.Windows.Forms.Button btnComboDetailDelete;
        private System.Windows.Forms.Button btnComboDetailEdit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbComboDetailProducts;
        private System.Windows.Forms.TextBox txComboDetailProductCount;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.Button btnOrderCancel;
        private System.Windows.Forms.Button btnOrderSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txOrderCustomer;
        private System.Windows.Forms.TextBox txOrderDeliveryDate;
        private System.Windows.Forms.TextBox txOrderDeliveryAddress;
        private System.Windows.Forms.TextBox txOrderPrice;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private System.Windows.Forms.TextBox ComboId;
        private System.Windows.Forms.TextBox txComboId;
        private System.Windows.Forms.Button btnComboDetailAdd;
        private System.Windows.Forms.DataGridView De;
        private System.Windows.Forms.DataGridView dgvProductCountHistory;
    }
}

