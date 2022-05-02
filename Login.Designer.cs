
namespace MarDeCortezDsk
{
    partial class Login
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
            this.containerLogin = new System.Windows.Forms.Panel();
            this.lklb_createacoount = new System.Windows.Forms.LinkLabel();
            this.bttn_login = new System.Windows.Forms.Button();
            this.txtBox_psswrd = new System.Windows.Forms.TextBox();
            this.txtBox_user = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_alert = new System.Windows.Forms.Label();
            this.containerLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // containerLogin
            // 
            this.containerLogin.AutoSize = true;
            this.containerLogin.BackColor = System.Drawing.Color.White;
            this.containerLogin.Controls.Add(this.lb_alert);
            this.containerLogin.Controls.Add(this.pictureBox1);
            this.containerLogin.Controls.Add(this.lklb_createacoount);
            this.containerLogin.Controls.Add(this.bttn_login);
            this.containerLogin.Controls.Add(this.txtBox_psswrd);
            this.containerLogin.Controls.Add(this.txtBox_user);
            this.containerLogin.Location = new System.Drawing.Point(60, 30);
            this.containerLogin.Name = "containerLogin";
            this.containerLogin.Size = new System.Drawing.Size(1141, 606);
            this.containerLogin.TabIndex = 0;
            // 
            // lklb_createacoount
            // 
            this.lklb_createacoount.AutoSize = true;
            this.lklb_createacoount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklb_createacoount.LinkColor = System.Drawing.Color.Black;
            this.lklb_createacoount.Location = new System.Drawing.Point(471, 506);
            this.lklb_createacoount.Name = "lklb_createacoount";
            this.lklb_createacoount.Size = new System.Drawing.Size(191, 36);
            this.lklb_createacoount.TabIndex = 5;
            this.lklb_createacoount.TabStop = true;
            this.lklb_createacoount.Text = "Crear Cuenta";
            // 
            // bttn_login
            // 
            this.bttn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_login.Location = new System.Drawing.Point(446, 413);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(240, 73);
            this.bttn_login.TabIndex = 4;
            this.bttn_login.Text = "Iniciar Sesion";
            this.bttn_login.UseVisualStyleBackColor = true;
            this.bttn_login.Click += new System.EventHandler(this.bttn_login_Click);
            // 
            // txtBox_psswrd
            // 
            this.txtBox_psswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_psswrd.ForeColor = System.Drawing.Color.DimGray;
            this.txtBox_psswrd.Location = new System.Drawing.Point(312, 326);
            this.txtBox_psswrd.Name = "txtBox_psswrd";
            this.txtBox_psswrd.Size = new System.Drawing.Size(500, 53);
            this.txtBox_psswrd.TabIndex = 2;
            this.txtBox_psswrd.Text = "Contraseña";
            // 
            // txtBox_user
            // 
            this.txtBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_user.ForeColor = System.Drawing.Color.DimGray;
            this.txtBox_user.Location = new System.Drawing.Point(312, 230);
            this.txtBox_user.Name = "txtBox_user";
            this.txtBox_user.Size = new System.Drawing.Size(500, 53);
            this.txtBox_user.TabIndex = 0;
            this.txtBox_user.Text = "Usuario";
            this.txtBox_user.TextChanged += new System.EventHandler(this.txtBox_user_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarDeCortezDsk.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(469, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "@Create by Acosta/Badillo/Luna";
            // 
            // lb_alert
            // 
            this.lb_alert.AutoSize = true;
            this.lb_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alert.ForeColor = System.Drawing.Color.Red;
            this.lb_alert.Location = new System.Drawing.Point(371, 513);
            this.lb_alert.Name = "lb_alert";
            this.lb_alert.Size = new System.Drawing.Size(396, 29);
            this.lb_alert.TabIndex = 6;
            this.lb_alert.Text = "El usuario o contraseña es icorrecto";
            this.lb_alert.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1255, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.containerLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.containerLogin.ResumeLayout(false);
            this.containerLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel containerLogin;
        private System.Windows.Forms.TextBox txtBox_user;
        private System.Windows.Forms.TextBox txtBox_psswrd;
        private System.Windows.Forms.Button bttn_login;
        private System.Windows.Forms.LinkLabel lklb_createacoount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_alert;
    }
}