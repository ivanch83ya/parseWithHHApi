
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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalaryFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalaryTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalaryCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colSalaryFrom,
            this.colSalaryTo,
            this.colSalaryCurr,
            this.colEmployer,
            this.colAddress,
            this.colInfo});
            this.GridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.RowTemplate.Height = 25;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(1107, 380);
            this.GridView.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.HeaderText = "Вакансия";
            this.colName.Name = "colName";
            // 
            // colSalaryFrom
            // 
            this.colSalaryFrom.HeaderText = "Зарплата от";
            this.colSalaryFrom.Name = "colSalaryFrom";
            // 
            // colSalaryTo
            // 
            this.colSalaryTo.HeaderText = "Зарплата до";
            this.colSalaryTo.Name = "colSalaryTo";
            // 
            // colSalaryCurr
            // 
            this.colSalaryCurr.HeaderText = "Валюта";
            this.colSalaryCurr.Name = "colSalaryCurr";
            // 
            // colEmployer
            // 
            this.colEmployer.HeaderText = "Компания";
            this.colEmployer.Name = "colEmployer";
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Адрес";
            this.colAddress.Name = "colAddress";
            // 
            // colInfo
            // 
            this.colInfo.HeaderText = "Описание";
            this.colInfo.MinimumWidth = 100;
            this.colInfo.Name = "colInfo";
            this.colInfo.Width = 400;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(22, 415);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(330, 23);
            this.searchBox.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(377, 414);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // lblCount
            // 
            this.lblCount.AccessibleDescription = "";
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(530, 421);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(104, 15);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Вакансий всего: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.lblCount);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalaryFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalaryTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalaryCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfo;
        private System.Windows.Forms.Label lblCount;
    }
}

