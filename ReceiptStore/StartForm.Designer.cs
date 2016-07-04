namespace ReceiptStore
{
    partial class StartForm
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
            this.SVReceiptsButton = new System.Windows.Forms.Button();
            this.ViewSVReceiptsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SVReceiptsButton
            // 
            this.SVReceiptsButton.Location = new System.Drawing.Point(59, 180);
            this.SVReceiptsButton.Name = "SVReceiptsButton";
            this.SVReceiptsButton.Size = new System.Drawing.Size(168, 50);
            this.SVReceiptsButton.TabIndex = 0;
            this.SVReceiptsButton.Text = "Save Receipts";
            this.SVReceiptsButton.UseVisualStyleBackColor = true;
            this.SVReceiptsButton.Click += new System.EventHandler(this.SVReceiptsButton_Click);
            // 
            // ViewSVReceiptsButton
            // 
            this.ViewSVReceiptsButton.Location = new System.Drawing.Point(285, 180);
            this.ViewSVReceiptsButton.Name = "ViewSVReceiptsButton";
            this.ViewSVReceiptsButton.Size = new System.Drawing.Size(168, 50);
            this.ViewSVReceiptsButton.TabIndex = 1;
            this.ViewSVReceiptsButton.Text = "View Saved Receipts";
            this.ViewSVReceiptsButton.UseVisualStyleBackColor = true;
            this.ViewSVReceiptsButton.Click += new System.EventHandler(this.ViewSVReceiptsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "What would you like to do?";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewSVReceiptsButton);
            this.Controls.Add(this.SVReceiptsButton);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SVReceiptsButton;
        private System.Windows.Forms.Button ViewSVReceiptsButton;
        private System.Windows.Forms.Label label1;
    }
}

