namespace WindowsFormsApp1
{
    partial class Look
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qOHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookTitleDataGridViewTextBoxColumn,
            this.bookCostDataGridViewTextBoxColumn,
            this.qOHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(940, 474);
            this.dataGridView1.TabIndex = 1;
            // 
            // ist3cxDataSet1
            // 
           
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
           
            // 
            // bookTableAdapter
            // 
            
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            this.bookTitleDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookCostDataGridViewTextBoxColumn
            // 
            this.bookCostDataGridViewTextBoxColumn.DataPropertyName = "BookCost";
            this.bookCostDataGridViewTextBoxColumn.HeaderText = "BookCost";
            this.bookCostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookCostDataGridViewTextBoxColumn.Name = "bookCostDataGridViewTextBoxColumn";
            this.bookCostDataGridViewTextBoxColumn.Width = 150;
            // 
            // qOHDataGridViewTextBoxColumn
            // 
            this.qOHDataGridViewTextBoxColumn.DataPropertyName = "QOH";
            this.qOHDataGridViewTextBoxColumn.HeaderText = "QOH";
            this.qOHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qOHDataGridViewTextBoxColumn.Name = "qOHDataGridViewTextBoxColumn";
            this.qOHDataGridViewTextBoxColumn.Width = 150;
            // 
            // Look
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 617);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Look";
            this.Text = "Look";
            this.Load += new System.EventHandler(this.Look_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource bookBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qOHDataGridViewTextBoxColumn;
    }
}