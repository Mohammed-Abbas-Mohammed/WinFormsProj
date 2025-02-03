namespace PresentationFinal
{
    partial class Category_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Details));
            gridCatDetails = new DataGridView();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gridCatDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // gridCatDetails
            // 
            gridCatDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCatDetails.Dock = DockStyle.Fill;
            gridCatDetails.Location = new Point(0, 0);
            gridCatDetails.Name = "gridCatDetails";
            gridCatDetails.RowHeadersWidth = 51;
            gridCatDetails.Size = new Size(1313, 624);
            gridCatDetails.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.InitialImage = (Image)resources.GetObject("Logo.InitialImage");
            Logo.Location = new Point(1208, 552);
            Logo.Name = "Logo";
            Logo.Size = new Size(105, 72);
            Logo.TabIndex = 18;
            Logo.TabStop = false;
            // 
            // Category_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 624);
            Controls.Add(Logo);
            Controls.Add(gridCatDetails);
            Name = "Category_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category_Details";
            Load += Category_Details_Load;
            ((System.ComponentModel.ISupportInitialize)gridCatDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCatDetails;
        private PictureBox Logo;
    }
}