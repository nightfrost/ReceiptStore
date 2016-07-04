using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReceiptStore
{
    public partial class SaveReceiptsCustomize : Form
    {
        public static string CustomName;
        public SaveReceiptsCustomize()
        {
            InitializeComponent();
            ReceiptFileName.Text = SaveReceipts.FileName;
            
        }

        private void ReceiptFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SVRCustomizeSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                CustomName = CustomReceiptName.Text;
                // Ensure that the target does not exist.
                if (File.Exists(StartForm.InstallPath + CustomName))
                {
                    MessageBox.Show("A file with the same name already exists.");
                }
                    

                // Move the file.
                File.Move(SaveReceipts.FileName, StartForm.InstallPath + CustomName + Path.GetExtension(SaveReceipts.FileName));
                DialogResult result = MessageBox.Show(string.Format("The file {0} was successfully moved to {1}", SaveReceipts.FileName, StartForm.InstallPath + CustomName + Path.GetExtension(SaveReceipts.FileName)));
                if (result == DialogResult.OK)
                {
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SVRCustomizeCancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
