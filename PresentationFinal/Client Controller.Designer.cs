namespace Presentation
{
    partial class ClientController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientController));
            panel1 = new Panel();
            bttnSearch = new Button();
            picProduct = new PictureBox();
            txtCatName = new TextBox();
            lblCat = new Label();
            txtSearchWord = new TextBox();
            txtProPrice = new TextBox();
            lblPrice = new Label();
            txtProName = new TextBox();
            lblProName = new Label();
            bttnShowAll = new Button();
            comboProName = new ComboBox();
            label3 = new Label();
            lblOr = new Label();
            label2 = new Label();
            lblProNameClient = new Label();
            gridSearchResult = new DataGridView();
            label1 = new Label();
            gridCustomerPros = new DataGridView();
            bttnAddToCart = new Button();
            bttnShowCart = new Button();
            lblCounter = new Label();
            pictureBox1 = new PictureBox();
            lblTotalPrice = new Label();
            label4 = new Label();
            bttnConfirm = new Button();
            Logo = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSearchResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomerPros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(bttnSearch);
            panel1.Controls.Add(picProduct);
            panel1.Controls.Add(txtCatName);
            panel1.Controls.Add(lblCat);
            panel1.Controls.Add(txtSearchWord);
            panel1.Controls.Add(txtProPrice);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(txtProName);
            panel1.Controls.Add(lblProName);
            panel1.Controls.Add(bttnShowAll);
            panel1.Controls.Add(comboProName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblOr);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblProNameClient);
            panel1.Controls.Add(gridSearchResult);
            panel1.Location = new Point(22, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 240);
            panel1.TabIndex = 0;
            // 
            // bttnSearch
            // 
            bttnSearch.Location = new Point(435, 187);
            bttnSearch.Name = "bttnSearch";
            bttnSearch.Size = new Size(111, 36);
            bttnSearch.TabIndex = 15;
            bttnSearch.Text = "Search";
            bttnSearch.UseVisualStyleBackColor = true;
            bttnSearch.Click += bttnSearch_Click;
            // 
            // picProduct
            // 
            picProduct.Image = (Image)resources.GetObject("picProduct.Image");
            picProduct.InitialImage = (Image)resources.GetObject("picProduct.InitialImage");
            picProduct.Location = new Point(985, 29);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(230, 180);
            picProduct.TabIndex = 13;
            picProduct.TabStop = false;
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(760, 30);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(193, 27);
            txtCatName.TabIndex = 12;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCat.Location = new Point(609, 30);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(84, 25);
            lblCat.TabIndex = 11;
            lblCat.Text = "Category";
            // 
            // txtSearchWord
            // 
            txtSearchWord.Location = new Point(205, 192);
            txtSearchWord.Name = "txtSearchWord";
            txtSearchWord.Size = new Size(193, 27);
            txtSearchWord.TabIndex = 9;
            // 
            // txtProPrice
            // 
            txtProPrice.Location = new Point(760, 141);
            txtProPrice.Name = "txtProPrice";
            txtProPrice.Size = new Size(193, 27);
            txtProPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(609, 141);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(86, 25);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Unit Price";
            // 
            // txtProName
            // 
            txtProName.Location = new Point(760, 89);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(193, 27);
            txtProName.TabIndex = 10;
            // 
            // lblProName
            // 
            lblProName.AutoSize = true;
            lblProName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProName.Location = new Point(609, 89);
            lblProName.Name = "lblProName";
            lblProName.Size = new Size(126, 25);
            lblProName.TabIndex = 8;
            lblProName.Text = "Product Name";
            // 
            // bttnShowAll
            // 
            bttnShowAll.BackColor = SystemColors.ButtonFace;
            bttnShowAll.ForeColor = Color.FromArgb(0, 192, 0);
            bttnShowAll.Location = new Point(54, 12);
            bttnShowAll.Name = "bttnShowAll";
            bttnShowAll.Size = new Size(151, 63);
            bttnShowAll.TabIndex = 6;
            bttnShowAll.Text = "Show All";
            bttnShowAll.UseVisualStyleBackColor = false;
            bttnShowAll.Click += bttnShowAll_Click;
            // 
            // comboProName
            // 
            comboProName.FormattingEnabled = true;
            comboProName.Location = new Point(205, 122);
            comboProName.Name = "comboProName";
            comboProName.Size = new Size(193, 28);
            comboProName.TabIndex = 5;
            comboProName.SelectedIndexChanged += comboProID_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(54, 93);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 3;
            label3.Text = "Or";
            // 
            // lblOr
            // 
            lblOr.AutoSize = true;
            lblOr.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOr.ForeColor = Color.Red;
            lblOr.Location = new Point(54, 162);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(25, 20);
            lblOr.TabIndex = 3;
            lblOr.Text = "Or";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 187);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "Search";
            // 
            // lblProNameClient
            // 
            lblProNameClient.AutoSize = true;
            lblProNameClient.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProNameClient.Location = new Point(54, 123);
            lblProNameClient.Name = "lblProNameClient";
            lblProNameClient.Size = new Size(125, 25);
            lblProNameClient.TabIndex = 4;
            lblProNameClient.Text = "Select Product";
            // 
            // gridSearchResult
            // 
            gridSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSearchResult.Location = new Point(603, 14);
            gridSearchResult.Name = "gridSearchResult";
            gridSearchResult.RowHeadersWidth = 51;
            gridSearchResult.Size = new Size(644, 214);
            gridSearchResult.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(22, 9);
            label1.MinimumSize = new Size(120, 40);
            label1.Name = "label1";
            label1.Size = new Size(142, 41);
            label1.TabIndex = 1;
            label1.Text = "Products";
            // 
            // gridCustomerPros
            // 
            gridCustomerPros.BackgroundColor = SystemColors.Info;
            gridCustomerPros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomerPros.Location = new Point(22, 398);
            gridCustomerPros.Name = "gridCustomerPros";
            gridCustomerPros.RowHeadersWidth = 51;
            gridCustomerPros.Size = new Size(1026, 214);
            gridCustomerPros.TabIndex = 14;
            gridCustomerPros.CellContentClick += gridCustomerPros_CellContentClick;
            // 
            // bttnAddToCart
            // 
            bttnAddToCart.Location = new Point(631, 320);
            bttnAddToCart.Name = "bttnAddToCart";
            bttnAddToCart.Size = new Size(275, 40);
            bttnAddToCart.TabIndex = 15;
            bttnAddToCart.Text = "Add To Cart";
            bttnAddToCart.UseVisualStyleBackColor = true;
            bttnAddToCart.Click += bttnAddToCart_Click;
            // 
            // bttnShowCart
            // 
            bttnShowCart.Location = new Point(1038, 320);
            bttnShowCart.Name = "bttnShowCart";
            bttnShowCart.Size = new Size(231, 40);
            bttnShowCart.TabIndex = 16;
            bttnShowCart.Text = "Show Cart";
            bttnShowCart.UseVisualStyleBackColor = true;
            bttnShowCart.Click += bttnShowCart_Click;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.ForeColor = Color.FromArgb(0, 0, 192);
            lblCounter.Location = new Point(943, 317);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(17, 20);
            lblCounter.TabIndex = 17;
            lblCounter.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(924, 340);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.FromArgb(0, 0, 192);
            lblTotalPrice.Location = new Point(1231, 398);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(23, 28);
            lblTotalPrice.TabIndex = 17;
            lblTotalPrice.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(1094, 398);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 17;
            label4.Text = "Total Price";
            // 
            // bttnConfirm
            // 
            bttnConfirm.BackColor = SystemColors.ControlLightLight;
            bttnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnConfirm.ForeColor = Color.LightSeaGreen;
            bttnConfirm.Location = new Point(1108, 458);
            bttnConfirm.Name = "bttnConfirm";
            bttnConfirm.Size = new Size(161, 48);
            bttnConfirm.TabIndex = 19;
            bttnConfirm.Text = "Confirm Order";
            bttnConfirm.UseVisualStyleBackColor = false;
            bttnConfirm.Click += bttnConfirm_Click;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.InitialImage = (Image)resources.GetObject("Logo.InitialImage");
            Logo.Location = new Point(1196, 531);
            Logo.Name = "Logo";
            Logo.Size = new Size(116, 81);
            Logo.TabIndex = 20;
            Logo.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(31, 340);
            label5.MinimumSize = new Size(120, 40);
            label5.Name = "label5";
            label5.Size = new Size(120, 41);
            label5.TabIndex = 1;
            label5.Text = "Cart";
            // 
            // ClientController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 624);
            Controls.Add(Logo);
            Controls.Add(bttnConfirm);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblCounter);
            Controls.Add(bttnShowCart);
            Controls.Add(bttnAddToCart);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(gridCustomerPros);
            Name = "ClientController";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client Controller";
            Load += ClientController_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSearchResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomerPros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboProName;
        private Label lblProNameClient;
        private Label lblOr;
        private Label label2;
        private Button bttnShowAll;
        private Label label3;
        private TextBox txtProPrice;
        private Label lblPrice;
        private TextBox txtProName;
        private Label lblProName;
        private TextBox txtCatName;
        private Label lblCat;
        private PictureBox picProduct;
        private DataGridView gridSearchResult;
        private TextBox txtSearchWord;
        private Button bttnSearch;
        private DataGridView gridCustomerPros;
        private Button bttnAddToCart;
        private Button bttnShowCart;
        private Label lblCounter;
        private PictureBox pictureBox1;
        private Label lblTotalPrice;
        private Label label4;
        private Button bttnConfirm;
        private PictureBox Logo;
        private Label label5;
    }
}