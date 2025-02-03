namespace Presentation
{
    partial class Product_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Details));
            ProductGridView = new DataGridView();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // ProductGridView
            // 
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Dock = DockStyle.Fill;
            ProductGridView.Location = new Point(0, 0);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.Size = new Size(1313, 624);
            ProductGridView.TabIndex = 1;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.InitialImage = (Image)resources.GetObject("Logo.InitialImage");
            Logo.Location = new Point(1208, 552);
            Logo.Name = "Logo";
            Logo.Size = new Size(105, 72);
            Logo.TabIndex = 16;
            Logo.TabStop = false;
            // 
            // Product_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 624);
            Controls.Add(Logo);
            Controls.Add(ProductGridView);
            Name = "Product_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product_Details";
            Load += Product_Details_Load;
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ProductGridView;
        private PictureBox Logo;
    }
}