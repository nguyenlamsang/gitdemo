namespace gitdemo
{
    partial class Form1
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
                components.Dispose () ;
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(219, 190);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(82, 17);
            this.lbusername.TabIndex = 1;
            this.lbusername.Text = "TÀI KHOẢN";
            this.lbusername.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MẬT KHẨU";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(379, 185);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(221, 22);
            this.txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(379, 231);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(218, 22);
            this.txtpass.TabIndex = 4;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(459, 277);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(138, 37);
            this.btnDangnhap.TabIndex = 5;
            this.btnDangnhap.Text = "ĐĂNG NHẬP";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 486);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnDangnhap;
    }
}

