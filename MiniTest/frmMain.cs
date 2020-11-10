using MiniTest.Screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MiniTest_Load(object sender, EventArgs e)
        {
            errTxtMaSV.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                txtMaSV.Focus();
                errTxtMaSV.SetError(txtMaSV, "Đang để trống");
            }
            else
            {
                string fileName = "Informtion.txt";
                FileStream fs;
                //if(File.Exists(fileName))
                if (!File.Exists(fileName))
                {
                    fs = new FileStream(fileName, FileMode.Append);
                    fs.Close();
                }
                var attr = File.GetAttributes(fileName);
                errTxtMaSV.Clear();

                if (File.Exists(fileName))
                {
                    // unset read-only
                    attr = attr & ~FileAttributes.ReadOnly;
                    File.SetAttributes(fileName, attr);
                    File.Delete(fileName);
                }
                string NextLine = txtMaSV.Text;
                fs = new FileStream(fileName, FileMode.Append);
                fs.Close();
                var sw = File.AppendText(fileName);
                byte[] bytes = Encoding.ASCII.GetBytes(NextLine);
                foreach (byte b in bytes)
                {
                    sw.Write(b);
                }
                sw.WriteLine();
                sw.Close();

                // set read-only
                attr = attr | FileAttributes.ReadOnly;
                File.SetAttributes(fileName, attr);
                //this.Hide();
                //frmQuestion1 frm1 = new frmQuestion1();
                //frm1.Show();
                this.Hide();
                frmQuestion1 frm1 = new frmQuestion1();
                frm1.ShowDialog();
                this.Close();
            }
        }

        private void txtMaSV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                e.Cancel = true;
                txtMaSV.Focus();
                errTxtMaSV.SetError(txtMaSV, "Đang để trống");
            }
            else
            {
                errTxtMaSV.Clear();
            }
        }
    }
}
