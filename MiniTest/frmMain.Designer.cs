namespace MiniTest
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitlte = new System.Windows.Forms.Label();
            this.lblQuyChe = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errTxtMaSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errTxtMaSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlte
            // 
            this.lblTitlte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitlte.AutoSize = true;
            this.lblTitlte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitlte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlte.ForeColor = System.Drawing.Color.Black;
            this.lblTitlte.Location = new System.Drawing.Point(386, 66);
            this.lblTitlte.Name = "lblTitlte";
            this.lblTitlte.Size = new System.Drawing.Size(223, 31);
            this.lblTitlte.TabIndex = 0;
            this.lblTitlte.Text = "Kiểm tra kiến thức";
            this.lblTitlte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQuyChe
            // 
            this.lblQuyChe.AutoSize = true;
            this.lblQuyChe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyChe.Location = new System.Drawing.Point(61, 136);
            this.lblQuyChe.Name = "lblQuyChe";
            this.lblQuyChe.Size = new System.Drawing.Size(186, 29);
            this.lblQuyChe.TabIndex = 1;
            this.lblQuyChe.Text = "Nội dung chú ý";
            // 
            // lblContent
            // 
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(291, 123);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(675, 302);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = resources.GetString("lblContent.Text");
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(308, 472);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(368, 34);
            this.txtMaSV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập mã số sinh viên";
            // 
            // errTxtMaSV
            // 
            this.errTxtMaSV.ContainerControl = this;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(703, 469);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(155, 41);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Bắt đầu làm";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MiniTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1026, 599);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblQuyChe);
            this.Controls.Add(this.lblTitlte);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiniTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniTest";
            this.Load += new System.EventHandler(this.MiniTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errTxtMaSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlte;
        private System.Windows.Forms.Label lblQuyChe;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errTxtMaSV;
        private System.Windows.Forms.Button btnOK;
    }
}

