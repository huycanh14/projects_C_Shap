namespace MiniTest.Screen
{
    partial class frmQuestion2
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
            this.components = new System.ComponentModel.Container();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblTextQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMiliSeconds = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(53, 49);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(33, 36);
            this.lblMinute.TabIndex = 6;
            this.lblMinute.Text = "0";
            // 
            // lblTextQuestion
            // 
            this.lblTextQuestion.AllowDrop = true;
            this.lblTextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextQuestion.Location = new System.Drawing.Point(12, 135);
            this.lblTextQuestion.Name = "lblTextQuestion";
            this.lblTextQuestion.Size = new System.Drawing.Size(948, 494);
            this.lblTextQuestion.TabIndex = 11;
            this.lblTextQuestion.Text = "question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // lblMiliSeconds
            // 
            this.lblMiliSeconds.AutoSize = true;
            this.lblMiliSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiliSeconds.Location = new System.Drawing.Point(211, 49);
            this.lblMiliSeconds.Name = "lblMiliSeconds";
            this.lblMiliSeconds.Size = new System.Drawing.Size(33, 36);
            this.lblMiliSeconds.TabIndex = 10;
            this.lblMiliSeconds.Text = "0";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(132, 49);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(33, 36);
            this.lblSeconds.TabIndex = 8;
            this.lblSeconds.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQuestion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 638);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblTextQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMiliSeconds);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestion2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Câu hỏi số 2";
            this.Load += new System.EventHandler(this.frmQuestion2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblTextQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMiliSeconds;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}