﻿namespace Resturant
{
    partial class addEmplyeeForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.joiningDateLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.joiningDateTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.jobComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(26, 50);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(146, 23);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jobLabel
            // 
            this.jobLabel.Location = new System.Drawing.Point(26, 93);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(146, 23);
            this.jobLabel.TabIndex = 2;
            this.jobLabel.Text = "Job";
            this.jobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // joiningDateLabel
            // 
            this.joiningDateLabel.Location = new System.Drawing.Point(26, 135);
            this.joiningDateLabel.Name = "joiningDateLabel";
            this.joiningDateLabel.Size = new System.Drawing.Size(146, 23);
            this.joiningDateLabel.TabIndex = 3;
            this.joiningDateLabel.Text = "Joining Date";
            this.joiningDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salaryLabel
            // 
            this.salaryLabel.Location = new System.Drawing.Point(26, 175);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(146, 23);
            this.salaryLabel.TabIndex = 4;
            this.salaryLabel.Text = "Salary";
            this.salaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(178, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(122, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // joiningDateTextBox
            // 
            this.joiningDateTextBox.Location = new System.Drawing.Point(178, 136);
            this.joiningDateTextBox.Name = "joiningDateTextBox";
            this.joiningDateTextBox.Size = new System.Drawing.Size(122, 22);
            this.joiningDateTextBox.TabIndex = 6;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(178, 176);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(122, 22);
            this.salaryTextBox.TabIndex = 7;
            // 
            // jobComboBox
            // 
            this.jobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.Location = new System.Drawing.Point(178, 92);
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(121, 24);
            this.jobComboBox.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(92, 226);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 30);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // addEmplyeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 287);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.jobComboBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.joiningDateTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.joiningDateLabel);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "addEmplyeeForm";
            this.Text = "addEmplyeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label joiningDateLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox joiningDateTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.ComboBox jobComboBox;
        private System.Windows.Forms.Button addButton;
    }
}