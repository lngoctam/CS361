
namespace PasswordManager
{
    partial class MainForm
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
            this.btn_CreatAccount = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CreatAccount
            // 
            this.btn_CreatAccount.Location = new System.Drawing.Point(70, 214);
            this.btn_CreatAccount.Name = "btn_CreatAccount";
            this.btn_CreatAccount.Size = new System.Drawing.Size(141, 28);
            this.btn_CreatAccount.TabIndex = 0;
            this.btn_CreatAccount.Text = "Create Account";
            this.btn_CreatAccount.UseVisualStyleBackColor = true;
            this.btn_CreatAccount.Click += new System.EventHandler(this.btn_CreatAccount_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(71, 248);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(140, 29);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Location = new System.Drawing.Point(70, 52);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(130, 13);
            this.lb_Welcome.TabIndex = 2;
            this.lb_Welcome.Text = "Safeguard Your Valuables";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PasswordManager.Properties.Resources.main_photo;
            this.pictureBox1.Location = new System.Drawing.Point(71, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_CreatAccount);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreatAccount;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}