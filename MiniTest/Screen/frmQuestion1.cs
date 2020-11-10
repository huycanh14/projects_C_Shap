using MiniTest.Questions;
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

namespace MiniTest.Screen
{
    public partial class frmQuestion1 : Form
    {
        private int minute, seconds, milisecond;
        private Question1 _question = new Question1();

        private void frmQuestion1_Load(object sender, EventArgs e)
        {
            var text = _question.GetQuestion();
            lblTextQuestion.Text = text;
            lblMinute.Text = "5";
            timer1.Start();
            EncodeText(text);

        }

        private void lblTextQuestion_Click(object sender, EventArgs e)
        {

        }

        public frmQuestion1()
        {
            InitializeComponent();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            frmQuestion2 frm2 = new frmQuestion2();
            frm2.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            minute = Int32.Parse(lblMinute.Text);
            seconds = Int32.Parse(lblSeconds.Text);
            milisecond = Int32.Parse(lblMiliSeconds.Text);
            milisecond--;
            if (milisecond < 0)
            {
                milisecond = 59;
                seconds--;
                if (seconds < 0)
                {
                    seconds = 59;
                    minute--;
                }
            }

            lblMinute.Text = minute < 10 ? "0" + minute : minute + "";
            lblSeconds.Text = seconds < 10 ? "0" + seconds : seconds + "";
            lblMiliSeconds.Text = milisecond < 10 ? "0" + milisecond : milisecond + "";
            if (minute == 0 && seconds == 0 && milisecond == 0)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Hết thời gian làm câu 1, chuyển qua câu 2");
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    frmQuestion2 frm2 = new frmQuestion2();
                    frm2.ShowDialog();
                    this.Close();
                }
            }
        }

        private void EncodeText(string text)
        {
            string fileName = "Informtion.txt";
            var attr = File.GetAttributes(fileName);
            // unset read-only
            attr = attr & ~FileAttributes.ReadOnly;
            File.SetAttributes(fileName, attr);

            FileStream fs = new FileStream(fileName, FileMode.Append);
            fs.Close();
            var sw = File.AppendText(fileName);
            sw.WriteLine();
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            foreach (byte b in bytes)
            {
                sw.Write(b);
            }
            sw.WriteLine();
            sw.Close();

            // set read-only
            attr = attr | FileAttributes.ReadOnly;
            File.SetAttributes(fileName, attr);
        }
    }
}
