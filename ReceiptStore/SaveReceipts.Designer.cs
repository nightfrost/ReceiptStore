namespace ReceiptStore
{
    partial class SaveReceipts
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SVRNextButton = new System.Windows.Forms.Button();
            this.SVRBackButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Location";
            // 
            // SVRNextButton
            // 
            this.SVRNextButton.Location = new System.Drawing.Point(91, 169);
            this.SVRNextButton.Name = "SVRNextButton";
            this.SVRNextButton.Size = new System.Drawing.Size(75, 23);
            this.SVRNextButton.TabIndex = 3;
            this.SVRNextButton.Text = "Next";
            this.SVRNextButton.UseVisualStyleBackColor = true;
            this.SVRNextButton.Click += new System.EventHandler(this.SVRNextButton_Click);
            // 
            // SVRBackButton
            // 
            this.SVRBackButton.Location = new System.Drawing.Point(172, 169);
            this.SVRBackButton.Name = "SVRBackButton";
            this.SVRBackButton.Size = new System.Drawing.Size(75, 23);
            this.SVRBackButton.TabIndex = 4;
            this.SVRBackButton.Text = "Back";
            this.SVRBackButton.UseVisualStyleBackColor = true;
            this.SVRBackButton.Click += new System.EventHandler(this.SVRBackButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Go To Saved Receipts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SVRBackButton);
            this.Controls.Add(this.SVRNextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "SaveReceipts";
            this.Text = "SaveReceipts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SVRNextButton;
        private System.Windows.Forms.Button SVRBackButton;
        private System.Windows.Forms.Button button2;
    }
}