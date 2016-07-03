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
    public partial class Form1 : Form
    {
        string InstallPath = @"C:\Program Files\Receipts\";
        public Form1()
        {
            InitializeComponent();
            string testFolder = "Wish";
            FolderCreate(testFolder);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string path = @"C:\Program Files\Receipts";

            try
            {
                if (Directory.Exists(InstallPath))
                {
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(InstallPath);

                MessageBox.Show(string.Format("The directory was successfully created at: {0}", Directory.GetCreationTime(InstallPath).ToString()));
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FolderCreate(string DirectoryName)
        {
            DirectoryInfo Di = Directory.CreateDirectory(InstallPath + DirectoryName);
        }
    }
}
