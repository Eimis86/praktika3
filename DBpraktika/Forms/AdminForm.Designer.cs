
namespace DBpraktika.Forms
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.loggedUserTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userIdTxt = new System.Windows.Forms.TextBox();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.password2Txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.AddUser = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MarkesModeliaiBtn = new System.Windows.Forms.Button();
            this.PrieduBtn = new System.Windows.Forms.Button();
            this.varikliaiBtn = new System.Windows.Forms.Button();
            this.interjeraiBtn = new System.Windows.Forms.Button();
            this.rataiBtn = new System.Windows.Forms.Button();
            this.spalvaBtn = new System.Windows.Forms.Button();
            this.KonfiguracijosBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administratorius:";
            // 
            // loggedUserTxt
            // 
            this.loggedUserTxt.AutoSize = true;
            this.loggedUserTxt.Location = new System.Drawing.Point(90, 468);
            this.loggedUserTxt.Name = "loggedUserTxt";
            this.loggedUserTxt.Size = new System.Drawing.Size(27, 13);
            this.loggedUserTxt.TabIndex = 1;
            this.loggedUserTxt.Text = "user";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.userGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 456);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naudotojų informacija";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.userIdTxt);
            this.groupBox4.Controls.Add(this.DeleteUser);
            this.groupBox4.Location = new System.Drawing.Point(268, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 115);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ištrinti naudotoją";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Įveskite naudotojo ID";
            // 
            // userIdTxt
            // 
            this.userIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTxt.Location = new System.Drawing.Point(145, 26);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(69, 26);
            this.userIdTxt.TabIndex = 21;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser.Location = new System.Drawing.Point(9, 68);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(205, 31);
            this.DeleteUser.TabIndex = 23;
            this.DeleteUser.Text = "Ištrinti";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.password2Txt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lastnameTxt);
            this.groupBox3.Controls.Add(this.nameTxt);
            this.groupBox3.Controls.Add(this.AddUser);
            this.groupBox3.Controls.Add(this.passwordTxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.usernameTxt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 218);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Naujas naudotojas";
            // 
            // password2Txt
            // 
            this.password2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2Txt.Location = new System.Drawing.Point(89, 84);
            this.password2Txt.Name = "password2Txt";
            this.password2Txt.Size = new System.Drawing.Size(145, 26);
            this.password2Txt.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Check Pass:";
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxt.Location = new System.Drawing.Point(89, 148);
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(145, 26);
            this.lastnameTxt.TabIndex = 30;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(89, 116);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(145, 26);
            this.nameTxt.TabIndex = 29;
            // 
            // AddUser
            // 
            this.AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser.Location = new System.Drawing.Point(12, 180);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(222, 31);
            this.AddUser.TabIndex = 24;
            this.AddUser.Text = "Pridėti naują naudotoja";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(89, 52);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(145, 26);
            this.passwordTxt.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Pavardė:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(89, 20);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(145, 26);
            this.usernameTxt.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Vardas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Username:";
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(9, 19);
            this.userGridView.Name = "userGridView";
            this.userGridView.ReadOnly = true;
            this.userGridView.Size = new System.Drawing.Size(486, 205);
            this.userGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KonfiguracijosBtn);
            this.groupBox2.Controls.Add(this.MarkesModeliaiBtn);
            this.groupBox2.Controls.Add(this.PrieduBtn);
            this.groupBox2.Controls.Add(this.varikliaiBtn);
            this.groupBox2.Controls.Add(this.interjeraiBtn);
            this.groupBox2.Controls.Add(this.rataiBtn);
            this.groupBox2.Controls.Add(this.spalvaBtn);
            this.groupBox2.Location = new System.Drawing.Point(528, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 453);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konfigūracijos komponentų informacija";
            // 
            // MarkesModeliaiBtn
            // 
            this.MarkesModeliaiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkesModeliaiBtn.Location = new System.Drawing.Point(6, 218);
            this.MarkesModeliaiBtn.Name = "MarkesModeliaiBtn";
            this.MarkesModeliaiBtn.Size = new System.Drawing.Size(143, 31);
            this.MarkesModeliaiBtn.TabIndex = 30;
            this.MarkesModeliaiBtn.Text = "Markės | Modeliai";
            this.MarkesModeliaiBtn.UseVisualStyleBackColor = true;
            this.MarkesModeliaiBtn.Click += new System.EventHandler(this.MarkesModeliaiBtn_Click);
            // 
            // PrieduBtn
            // 
            this.PrieduBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrieduBtn.Location = new System.Drawing.Point(6, 181);
            this.PrieduBtn.Name = "PrieduBtn";
            this.PrieduBtn.Size = new System.Drawing.Size(143, 31);
            this.PrieduBtn.TabIndex = 29;
            this.PrieduBtn.Text = "Priedų ypatybės";
            this.PrieduBtn.UseVisualStyleBackColor = true;
            this.PrieduBtn.Click += new System.EventHandler(this.PrieduBtn_Click);
            // 
            // varikliaiBtn
            // 
            this.varikliaiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varikliaiBtn.Location = new System.Drawing.Point(6, 144);
            this.varikliaiBtn.Name = "varikliaiBtn";
            this.varikliaiBtn.Size = new System.Drawing.Size(143, 31);
            this.varikliaiBtn.TabIndex = 28;
            this.varikliaiBtn.Text = "Variklių ypatybės";
            this.varikliaiBtn.UseVisualStyleBackColor = true;
            this.varikliaiBtn.Click += new System.EventHandler(this.varikliaiBtn_Click);
            // 
            // interjeraiBtn
            // 
            this.interjeraiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interjeraiBtn.Location = new System.Drawing.Point(6, 107);
            this.interjeraiBtn.Name = "interjeraiBtn";
            this.interjeraiBtn.Size = new System.Drawing.Size(143, 31);
            this.interjeraiBtn.TabIndex = 27;
            this.interjeraiBtn.Text = "Interjerų ypatybės";
            this.interjeraiBtn.UseVisualStyleBackColor = true;
            this.interjeraiBtn.Click += new System.EventHandler(this.interjeraiBtn_Click);
            // 
            // rataiBtn
            // 
            this.rataiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rataiBtn.Location = new System.Drawing.Point(6, 70);
            this.rataiBtn.Name = "rataiBtn";
            this.rataiBtn.Size = new System.Drawing.Size(143, 31);
            this.rataiBtn.TabIndex = 26;
            this.rataiBtn.Text = "Ratų ypatybės";
            this.rataiBtn.UseVisualStyleBackColor = true;
            this.rataiBtn.Click += new System.EventHandler(this.rataiBtn_Click);
            // 
            // spalvaBtn
            // 
            this.spalvaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spalvaBtn.Location = new System.Drawing.Point(6, 33);
            this.spalvaBtn.Name = "spalvaBtn";
            this.spalvaBtn.Size = new System.Drawing.Size(143, 31);
            this.spalvaBtn.TabIndex = 25;
            this.spalvaBtn.Text = "Spalvų ypatybės";
            this.spalvaBtn.UseVisualStyleBackColor = true;
            this.spalvaBtn.Click += new System.EventHandler(this.spalvaBtn_Click);
            // 
            // KonfiguracijosBtn
            // 
            this.KonfiguracijosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KonfiguracijosBtn.Location = new System.Drawing.Point(6, 388);
            this.KonfiguracijosBtn.Name = "KonfiguracijosBtn";
            this.KonfiguracijosBtn.Size = new System.Drawing.Size(143, 57);
            this.KonfiguracijosBtn.TabIndex = 31;
            this.KonfiguracijosBtn.Text = "Užsakytos konfigūracijos";
            this.KonfiguracijosBtn.UseVisualStyleBackColor = true;
            this.KonfiguracijosBtn.Click += new System.EventHandler(this.KonfiguracijosBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.loggedUserTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loggedUserTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button spalvaBtn;
        private System.Windows.Forms.Button interjeraiBtn;
        private System.Windows.Forms.Button rataiBtn;
        private System.Windows.Forms.Button varikliaiBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password2Txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PrieduBtn;
        private System.Windows.Forms.Button MarkesModeliaiBtn;
        private System.Windows.Forms.Button KonfiguracijosBtn;
    }
}