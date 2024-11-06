namespace ジェイソンA
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
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Location = new System.Drawing.Point(34, 35);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(125, 27);
            this.ProductIdTextBox.TabIndex = 0;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(34, 88);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.ProductNameTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(34, 143);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(174, 143);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(94, 29);
            this.ReadButton.TabIndex = 3;
            this.ReadButton.Text = "読込";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductIdTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ProductIdTextBox;
        private TextBox ProductNameTextBox;
        private Button SaveButton;
        private Button ReadButton;
    }
}