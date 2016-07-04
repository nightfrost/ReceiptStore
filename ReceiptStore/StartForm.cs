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
    public partial class StartForm : Form
    {
        public static string InstallPath = @"C:\Program Files\Receipts\";
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initial receipts folder.
            try
            {
                if (Directory.Exists(InstallPath))
                {
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(InstallPath);

                MessageBox.Show(string.Format("The directory for receipts was successfully created at: {0}", Directory.GetCreationTime(InstallPath).ToString()));
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void FolderCreate(string DirectoryName)
        {
            //Method to call when wanting a new subfolder for receipts.
            DirectoryInfo Di = Directory.CreateDirectory(InstallPath + DirectoryName);
        }

        private void SVReceiptsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaveReceipts svreceipts = new SaveReceipts();
            svreceipts.Show();
        }

        private void ViewSVReceiptsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSavedReceipts vsvreceipts = new ViewSavedReceipts();
            vsvreceipts.Show();
        }
    }
}
