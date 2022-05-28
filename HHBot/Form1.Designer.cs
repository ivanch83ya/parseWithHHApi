
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
            this.ResBox = new System.Windows.Forms.TextBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.buttonParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResBox
            // 
            this.ResBox.Location = new System.Drawing.Point(13, 39);
            this.ResBox.Multiline = true;
            this.ResBox.Name = "ResBox";
            this.ResBox.Size = new System.Drawing.Size(775, 328);
            this.ResBox.TabIndex = 0;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(13, 374);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(258, 23);
            this.TestButton.TabIndex = 1;
            this.TestButton.Text = "ТЕСТ";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(291, 374);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(149, 23);
            this.buttonParse.TabIndex = 2;
            this.buttonParse.Text = "Парсинг";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonParse);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.ResBox);
            this.Name = "Form1";
            this.Text = "HH API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResBox;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button buttonParse;
    }
}

