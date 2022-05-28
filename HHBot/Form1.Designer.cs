
namespace HHBot
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Salary_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Salary_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Salary_curr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_empl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_Name,
            this.Col_Salary_from,
            this.Col_Salary_to,
            this.Col_Salary_curr,
            this.Col_empl,
            this.Col_addr,
            this.Col_info});
            this.GridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.RowTemplate.Height = 25;
            this.GridView.Size = new System.Drawing.Size(1107, 248);
            this.GridView.TabIndex = 3;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 264);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(694, 23);
            this.searchBox.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(713, 264);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // Col_ID
            // 
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.Name = "Col_ID";
            // 
            // Col_Name
            // 
            this.Col_Name.HeaderText = "Name";
            this.Col_Name.Name = "Col_Name";
            // 
            // Col_Salary_from
            // 
            this.Col_Salary_from.HeaderText = "Зарплата от";
            this.Col_Salary_from.Name = "Col_Salary_from";
            // 
            // Col_Salary_to
            // 
            this.Col_Salary_to.HeaderText = "Зарплата до";
            this.Col_Salary_to.Name = "Col_Salary_to";
            // 
            // Col_Salary_curr
            // 
            this.Col_Salary_curr.HeaderText = "Валюта";
            this.Col_Salary_curr.Name = "Col_Salary_curr";
            // 
            // Col_empl
            // 
            this.Col_empl.HeaderText = "Employer";
            this.Col_empl.Name = "Col_empl";
            // 
            // Col_addr
            // 
            this.Col_addr.HeaderText = "Адрес";
            this.Col_addr.Name = "Col_addr";
            // 
            // Col_info
            // 
            this.Col_info.HeaderText = "Описание";
            this.Col_info.MinimumWidth = 100;
            this.Col_info.Name = "Col_info";
            this.Col_info.Width = 400;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.GridView);
            this.Name = "Form1";
            this.Text = "HH API";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Salary_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Salary_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Salary_curr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_empl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_info;
    }
}

