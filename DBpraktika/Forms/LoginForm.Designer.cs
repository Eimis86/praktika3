
namespace DBpraktika.Forms
{
    partial class LoginForm
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
        /// the contents of this method with the code editor.a
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBtn = new System.Windows.Forms.Button();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.pswLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(147, 81);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(89, 34);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "log in";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(13, 13);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(91, 20);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "Username :";
            // 
            // pswLbl
            // 
            this.pswLbl.AutoSize = true;
            this.pswLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswLbl.Location = new System.Drawing.Point(18, 45);
            this.pswLbl.Name = "pswLbl";
            this.pswLbl.Size = new System.Drawing.Size(86, 20);
            this.pswLbl.TabIndex = 2;
            this.pswLbl.Text = "Password :";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(110, 10);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(243, 26);
            this.usernameTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(110, 42);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '#';
            this.passwordTxt.Size = new System.Drawing.Size(243, 26);
            this.passwordTxt.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 127);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.pswLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.LoginBtn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label pswLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
    }
}