namespace ReceiptStore
{
    partial class SaveReceiptsCustomize
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReceiptFileName = new System.Windows.Forms.TextBox();
            this.CustomReceiptName = new System.Windows.Forms.TextBox();
            this.ReceiptFromName = new System.Windows.Forms.TextBox();
            this.SVRCustomizeSaveButton = new System.Windows.Forms.Button();
            this.SVRCustomizeCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custom Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "From:";
            // 
            // ReceiptFileName
            // 
            this.ReceiptFileName.Location = new System.Drawing.Point(87, 30);
            this.ReceiptFileName.Name = "ReceiptFileName";
            this.ReceiptFileName.ReadOnly = true;
            this.ReceiptFileName.Size = new System.Drawing.Size(100, 20);
            this.ReceiptFileName.TabIndex = 3;
            this.ReceiptFileName.TextChanged += new System.EventHandler(this.ReceiptFileName_TextChanged);
            // 
            // CustomReceiptName
            // 
            this.CustomReceiptName.Location = new System.Drawing.Point(87, 65);
            this.CustomReceiptName.Name = "CustomReceiptName";
            this.CustomReceiptName.Size = new System.Drawing.Size(100, 20);
            this.CustomReceiptName.TabIndex = 4;
            // 
            // ReceiptFromName
            // 
            this.ReceiptFromName.Location = new System.Drawing.Point(87, 100);
            this.ReceiptFromName.Name = "ReceiptFromName";
            this.ReceiptFromName.Size = new System.Drawing.Size(100, 20);
            this.ReceiptFromName.TabIndex = 5;
            // 
            // SVRCustomizeSaveButton
            // 
            this.SVRCustomizeSaveButton.Location = new System.Drawing.Point(50, 126);
            this.SVRCustomizeSaveButton.Name = "SVRCustomizeSaveButton";
            this.SVRCustomizeSaveButton.Size = new System.Drawing.Size(75, 23);
            this.SVRCustomizeSaveButton.TabIndex = 6;
            this.SVRCustomizeSaveButton.Text = "Save";
            this.SVRCustomizeSaveButton.UseVisualStyleBackColor = true;
            this.SVRCustomizeSaveButton.Click += new System.EventHandler(this.SVRCustomizeSaveButton_Click);
            // 
            // SVRCustomizeCancelButton
            // 
            this.SVRCustomizeCancelButton.Location = new System.Drawing.Point(149, 126);
            this.SVRCustomizeCancelButton.Name = "SVRCustomizeCancelButton";
            this.SVRCustomizeCancelButton.Size = new System.Drawing.Size(75, 23);
            this.SVRCustomizeCancelButton.TabIndex = 7;
            this.SVRCustomizeCancelButton.Text = "Cancel";
            this.SVRCustomizeCancelButton.UseVisualStyleBackColor = true;
            this.SVRCustomizeCancelButton.Click += new System.EventHandler(this.SVRCustomizeCancelButton_Click);
            // 
            // SaveReceiptsCustomize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 194);
            this.Controls.Add(this.SVRCustomizeCancelButton);
            this.Controls.Add(this.SVRCustomizeSaveButton);
            this.Controls.Add(this.ReceiptFromName);
            this.Controls.Add(this.CustomReceiptName);
            this.Controls.Add(this.ReceiptFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaveReceiptsCustomize";
            this.Text = "SaveReceiptsCustomize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReceiptFileName;
        private System.Windows.Forms.TextBox CustomReceiptName;
        private System.Windows.Forms.TextBox ReceiptFromName;
        private System.Windows.Forms.Button SVRCustomizeSaveButton;
        private System.Windows.Forms.Button SVRCustomizeCancelButton;
    }
}