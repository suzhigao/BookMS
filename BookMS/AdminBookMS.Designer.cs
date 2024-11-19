
namespace BookMS
{
    partial class AdminBookMS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBook = new System.Windows.Forms.Button();
            this.AlterBook = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.buttonReFresh = new System.Windows.Forms.Button();
            this.buttonFindByName = new System.Windows.Forms.Button();
            this.textBoxFindByID = new System.Windows.Forms.TextBox();
            this.textBoxFindByName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_SelectedBook = new System.Windows.Forms.Label();
            this.buttonFindByID = new System.Windows.Forms.Button();
            this.MuiltDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 582);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "书号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "书名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出版社";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "库存";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "作者";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // AddBook
            // 
            this.AddBook.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBook.Location = new System.Drawing.Point(746, 68);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(129, 49);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "添加图书";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // AlterBook
            // 
            this.AlterBook.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AlterBook.Location = new System.Drawing.Point(982, 68);
            this.AlterBook.Name = "AlterBook";
            this.AlterBook.Size = new System.Drawing.Size(129, 49);
            this.AlterBook.TabIndex = 2;
            this.AlterBook.Text = "修改图书";
            this.AlterBook.UseVisualStyleBackColor = true;
            this.AlterBook.Click += new System.EventHandler(this.AlterBook_Click);
            // 
            // DeleteBook
            // 
            this.DeleteBook.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteBook.Location = new System.Drawing.Point(746, 179);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(129, 49);
            this.DeleteBook.TabIndex = 3;
            this.DeleteBook.Text = "删除图书";
            this.DeleteBook.UseVisualStyleBackColor = true;
            this.DeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // buttonReFresh
            // 
            this.buttonReFresh.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReFresh.Location = new System.Drawing.Point(982, 179);
            this.buttonReFresh.Name = "buttonReFresh";
            this.buttonReFresh.Size = new System.Drawing.Size(129, 49);
            this.buttonReFresh.TabIndex = 4;
            this.buttonReFresh.Text = "刷新";
            this.buttonReFresh.UseVisualStyleBackColor = true;
            // 
            // buttonFindByName
            // 
            this.buttonFindByName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFindByName.Location = new System.Drawing.Point(982, 387);
            this.buttonFindByName.Name = "buttonFindByName";
            this.buttonFindByName.Size = new System.Drawing.Size(129, 49);
            this.buttonFindByName.TabIndex = 6;
            this.buttonFindByName.Text = "书名查询";
            this.buttonFindByName.UseVisualStyleBackColor = true;
            this.buttonFindByName.Click += new System.EventHandler(this.buttonFindByName_Click);
            // 
            // textBoxFindByID
            // 
            this.textBoxFindByID.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFindByID.Location = new System.Drawing.Point(746, 298);
            this.textBoxFindByID.Name = "textBoxFindByID";
            this.textBoxFindByID.Size = new System.Drawing.Size(170, 28);
            this.textBoxFindByID.TabIndex = 7;
            // 
            // textBoxFindByName
            // 
            this.textBoxFindByName.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFindByName.Location = new System.Drawing.Point(746, 402);
            this.textBoxFindByName.Name = "textBoxFindByName";
            this.textBoxFindByName.Size = new System.Drawing.Size(170, 28);
            this.textBoxFindByName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "当前选中的图书是：";
            // 
            // Label_SelectedBook
            // 
            this.Label_SelectedBook.AutoSize = true;
            this.Label_SelectedBook.Location = new System.Drawing.Point(891, 25);
            this.Label_SelectedBook.Name = "Label_SelectedBook";
            this.Label_SelectedBook.Size = new System.Drawing.Size(39, 15);
            this.Label_SelectedBook.TabIndex = 10;
            this.Label_SelectedBook.Text = "NULL";
            // 
            // buttonFindByID
            // 
            this.buttonFindByID.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFindByID.Location = new System.Drawing.Point(982, 283);
            this.buttonFindByID.Name = "buttonFindByID";
            this.buttonFindByID.Size = new System.Drawing.Size(129, 49);
            this.buttonFindByID.TabIndex = 11;
            this.buttonFindByID.Text = "书号查询";
            this.buttonFindByID.UseVisualStyleBackColor = true;
            this.buttonFindByID.Click += new System.EventHandler(this.buttonFindByID_Click);
            // 
            // MuiltDelete
            // 
            this.MuiltDelete.Location = new System.Drawing.Point(746, 502);
            this.MuiltDelete.Name = "MuiltDelete";
            this.MuiltDelete.Size = new System.Drawing.Size(191, 54);
            this.MuiltDelete.TabIndex = 12;
            this.MuiltDelete.Text = "多行删除(待加)";
            this.MuiltDelete.UseVisualStyleBackColor = true;
            // 
            // AdminBookMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 582);
            this.Controls.Add(this.MuiltDelete);
            this.Controls.Add(this.buttonFindByID);
            this.Controls.Add(this.Label_SelectedBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFindByName);
            this.Controls.Add(this.textBoxFindByID);
            this.Controls.Add(this.buttonFindByName);
            this.Controls.Add(this.buttonReFresh);
            this.Controls.Add(this.DeleteBook);
            this.Controls.Add(this.AlterBook);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminBookMS";
            this.Text = "图书管理页面";
            this.Load += new System.EventHandler(this.Admin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button AlterBook;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Button buttonReFresh;
        private System.Windows.Forms.Button buttonFindByName;
        private System.Windows.Forms.TextBox textBoxFindByID;
        private System.Windows.Forms.TextBox textBoxFindByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_SelectedBook;
        private System.Windows.Forms.Button buttonFindByID;
        private System.Windows.Forms.Button MuiltDelete;
    }
}