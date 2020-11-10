namespace MiniTest.Screen
{
    partial class frmQuestion1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMiliSeconds = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTextQuestion = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(48, 32);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(33, 36);
            this.lblMinute.TabIndex = 0;
            this.lblMinute.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(127, 32);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(33, 36);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // lblMiliSeconds
            // 
            this.lblMiliSeconds.AutoSize = true;
            this.lblMiliSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiliSeconds.Location = new System.Drawing.Point(206, 32);
            this.lblMiliSeconds.Name = "lblMiliSeconds";
            this.lblMiliSeconds.Size = new System.Drawing.Size(33, 36);
            this.lblMiliSeconds.TabIndex = 4;
            this.lblMiliSeconds.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTextQuestion
            // 
            this.lblTextQuestion.AllowDrop = true;
            this.lblTextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextQuestion.Location = new System.Drawing.Point(12, 118);
            this.lblTextQuestion.Name = "lblTextQuestion";
            this.lblTextQuestion.Size = new System.Drawing.Size(942, 476);
            this.lblTextQuestion.TabIndex = 5;
            this.lblTextQuestion.Text = "question";
            this.lblTextQuestion.Click += new System.EventHandler(this.lblTextQuestion_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(494, 24);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(161, 56);
            this.btnNextQuestion.TabIndex = 6;
            this.btnNextQuestion.Text = "Câu kế tiếp";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // frmQuestion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(966, 603);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblTextQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMiliSeconds);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Câu hỏi số 1";
            this.Load += new System.EventHandler(this.frmQuestion1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMiliSeconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTextQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
    }
}