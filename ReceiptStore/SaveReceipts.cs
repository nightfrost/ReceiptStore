using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptStore
{
    public partial class SaveReceipts : Form
    {
        
        public SaveReceipts()
        {
            InitializeComponent();
        }

        public static string FileName;

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files|*.*|PDF File|*.pdf|Microsoft Word 97 - 2003 Document|*.doc|Microsoft Word Document|*.docx";
            openFileDialog1.Title = "Save a receipt";
            openFileDialog1.ShowDialog();
                FileName = openFileDialog1.FileName;
                textBox1.Text = FileName;
            
            }catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error found when choosing file: {0}", ex.Message));
            }
        }

        private void SVRNextButton_Click(object sender, EventArgs e)
        {
            
            SaveReceiptsCustomize svreceiptsCustomize = new SaveReceiptsCustomize();
            svreceiptsCustomize.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSavedReceipts vsvreceipts = new ViewSavedReceipts();
            vsvreceipts.Show();
        }

        private void SVRBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startform = new StartForm();
            startform.Show();
        }
    }
}
