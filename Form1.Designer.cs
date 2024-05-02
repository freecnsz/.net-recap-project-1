namespace RecapProject1
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
            gbxCategory = new GroupBox();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            gbxSearch = new GroupBox();
            tbxSearch = new TextBox();
            lblSearch = new Label();
            dgwProduct = new DataGridView();
            gbxCategory.SuspendLayout();
            gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            SuspendLayout();
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(cbxCategory);
            gbxCategory.Controls.Add(lblCategory);
            gbxCategory.Location = new Point(12, 12);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(921, 89);
            gbxCategory.TabIndex = 0;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategoryiye Göre Listele";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(85, 36);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(426, 23);
            cbxCategory.TabIndex = 1;
            cbxCategory.UseWaitCursor = true;
            cbxCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(28, 39);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(54, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Kategori:";
            lblCategory.Click += label1_Click;
            // 
            // gbxSearch
            // 
            gbxSearch.Controls.Add(tbxSearch);
            gbxSearch.Controls.Add(lblSearch);
            gbxSearch.Location = new Point(12, 119);
            gbxSearch.Name = "gbxSearch";
            gbxSearch.Size = new Size(921, 81);
            gbxSearch.TabIndex = 1;
            gbxSearch.TabStop = false;
            gbxSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(85, 33);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(426, 23);
            tbxSearch.TabIndex = 2;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(51, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(28, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Ara:";
            // 
            // dgwProduct
            // 
            dgwProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Location = new Point(12, 206);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.Size = new Size(962, 271);
            dgwProduct.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 476);
            Controls.Add(dgwProduct);
            Controls.Add(gbxSearch);
            Controls.Add(gbxCategory);
            Name = "Form1";
            Text = "Ürünler";
            Load += Form1_Load;
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            gbxSearch.ResumeLayout(false);
            gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxCategory;
        private Label lblCategory;
        private ComboBox cbxCategory;
        private GroupBox gbxSearch;
        private TextBox tbxSearch;
        private Label lblSearch;
        private DataGridView dgwProduct;
    }
}
