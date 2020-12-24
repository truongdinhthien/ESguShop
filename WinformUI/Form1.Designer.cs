
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.combo = new System.Windows.Forms.TabPage();
            this.order = new System.Windows.Forms.TabPage();
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
            this.dgvProductListCountHistory = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.product.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductListCountHistory)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.product.Controls.Add(this.dgvProductList);
            this.product.Location = new System.Drawing.Point(4, 29);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(3);
            this.product.Size = new System.Drawing.Size(902, 507);
            this.product.TabIndex = 0;
            this.product.Text = "Sản phẩm";
            this.product.UseVisualStyleBackColor = true;
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
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(9, 4);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 29;
            this.dgvProductList.Size = new System.Drawing.Size(447, 495);
            this.dgvProductList.TabIndex = 0;
            // 
            // combo
            // 
            this.combo.Location = new System.Drawing.Point(4, 29);
            this.combo.Name = "combo";
            this.combo.Padding = new System.Windows.Forms.Padding(3);
            this.combo.Size = new System.Drawing.Size(902, 507);
            this.combo.TabIndex = 1;
            this.combo.Text = "Combo";
            this.combo.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(4, 29);
            this.order.Name = "order";
            this.order.Padding = new System.Windows.Forms.Padding(3);
            this.order.Size = new System.Drawing.Size(902, 507);
            this.order.TabIndex = 2;
            this.order.Text = "Đơn hàng";
            this.order.UseVisualStyleBackColor = true;
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
            // dgvProductListCountHistory
            // 
            this.dgvProductListCountHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductListCountHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductListCountHistory.Location = new System.Drawing.Point(3, 23);
            this.dgvProductListCountHistory.Name = "dgvProductListCountHistory";
            this.dgvProductListCountHistory.RowHeadersWidth = 51;
            this.dgvProductListCountHistory.RowTemplate.Height = 29;
            this.dgvProductListCountHistory.Size = new System.Drawing.Size(431, 246);
            this.dgvProductListCountHistory.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductListCountHistory);
            this.groupBox2.Location = new System.Drawing.Point(462, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 272);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử số lượng";
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
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductListCountHistory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage product;
        private System.Windows.Forms.TabPage combo;
        private System.Windows.Forms.TabPage order;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProductList;
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
    }
}

