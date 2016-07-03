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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\Receipts";

            try
            {
                if (Directory.Exists(path))
                {
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(path);

                MessageBox.Show(string.Format("The directory was successfully created at: {0}", Directory.GetCreationTime(path).ToString()));
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FolderCreate(string DirectoryName)
        {
            //string folderName = 
        }
    }
}
