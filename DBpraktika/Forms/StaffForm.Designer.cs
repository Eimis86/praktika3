
namespace DBpraktika.Forms
{
    partial class StaffForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MarkesModeliaiBtn = new System.Windows.Forms.Button();
            this.PrieduBtn = new System.Windows.Forms.Button();
            this.varikliaiBtn = new System.Windows.Forms.Button();
            this.interjeraiBtn = new System.Windows.Forms.Button();
            this.rataiBtn = new System.Windows.Forms.Button();
            this.spalvaBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.konfiguracijosDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.konfigIDTxt = new System.Windows.Forms.TextBox();
            this.ShowPriedaiBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.prieduDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteIDtxt = new System.Windows.Forms.TextBox();
            this.DeleteKonfigBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.konfiguracijosDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prieduDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pardavejas:";
            // 
            // loggedUserTxt
            // 
            this.loggedUserTxt.AutoSize = true;
            this.loggedUserTxt.Location = new System.Drawing.Point(68, 428);
            this.loggedUserTxt.Name = "loggedUserTxt";
            this.loggedUserTxt.Size = new System.Drawing.Size(27, 13);
            this.loggedUserTxt.TabIndex = 2;
            this.loggedUserTxt.Text = "user";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MarkesModeliaiBtn);
            this.groupBox2.Controls.Add(this.PrieduBtn);
            this.groupBox2.Controls.Add(this.varikliaiBtn);
            this.groupBox2.Controls.Add(this.interjeraiBtn);
            this.groupBox2.Controls.Add(this.rataiBtn);
            this.groupBox2.Controls.Add(this.spalvaBtn);
            this.groupBox2.Location = new System.Drawing.Point(475, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 175);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keisti konfigūracijos komponentų informacija";
            // 
            // MarkesModeliaiBtn
            // 
            this.MarkesModeliaiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkesModeliaiBtn.Location = new System.Drawing.Point(6, 41);
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
            this.PrieduBtn.Location = new System.Drawing.Point(6, 115);
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
            this.varikliaiBtn.Location = new System.Drawing.Point(6, 78);
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
            this.interjeraiBtn.Location = new System.Drawing.Point(155, 115);
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
            this.rataiBtn.Location = new System.Drawing.Point(155, 78);
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
            this.spalvaBtn.Location = new System.Drawing.Point(155, 41);
            this.spalvaBtn.Name = "spalvaBtn";
            this.spalvaBtn.Size = new System.Drawing.Size(143, 31);
            this.spalvaBtn.TabIndex = 25;
            this.spalvaBtn.Text = "Spalvų ypatybės";
            this.spalvaBtn.UseVisualStyleBackColor = true;
            this.spalvaBtn.Click += new System.EventHandler(this.spalvaBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DeleteKonfigBtn);
            this.groupBox1.Controls.Add(this.deleteIDtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.konfiguracijosDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 246);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Užsakytos konfigūracijos";
            // 
            // konfiguracijosDataGridView
            // 
            this.konfiguracijosDataGridView.AllowUserToOrderColumns = true;
            this.konfiguracijosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.konfiguracijosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.konfiguracijosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.konfiguracijosDataGridView.Location = new System.Drawing.Point(6, 19);
            this.konfiguracijosDataGridView.Name = "konfiguracijosDataGridView";
            this.konfiguracijosDataGridView.ReadOnly = true;
            this.konfiguracijosDataGridView.Size = new System.Drawing.Size(764, 184);
            this.konfiguracijosDataGridView.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.konfigIDTxt);
            this.groupBox3.Controls.Add(this.ShowPriedaiBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.prieduDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(18, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 150);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pasirinktos konfiguracijos priedai";
            // 
            // konfigIDTxt
            // 
            this.konfigIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konfigIDTxt.Location = new System.Drawing.Point(388, 47);
            this.konfigIDTxt.Name = "konfigIDTxt";
            this.konfigIDTxt.Size = new System.Drawing.Size(57, 22);
            this.konfigIDTxt.TabIndex = 3;
            // 
            // ShowPriedaiBtn
            // 
            this.ShowPriedaiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPriedaiBtn.Location = new System.Drawing.Point(286, 91);
            this.ShowPriedaiBtn.Name = "ShowPriedaiBtn";
            this.ShowPriedaiBtn.Size = new System.Drawing.Size(159, 31);
            this.ShowPriedaiBtn.TabIndex = 31;
            this.ShowPriedaiBtn.Text = "Rodyti priedus";
            this.ShowPriedaiBtn.UseVisualStyleBackColor = true;
            this.ShowPriedaiBtn.Click += new System.EventHandler(this.ShowPriedaiBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Konfiguracijos ID";
            // 
            // prieduDataGridView
            // 
            this.prieduDataGridView.AllowUserToOrderColumns = true;
            this.prieduDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prieduDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.prieduDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prieduDataGridView.Location = new System.Drawing.Point(6, 19);
            this.prieduDataGridView.Name = "prieduDataGridView";
            this.prieduDataGridView.ReadOnly = true;
            this.prieduDataGridView.Size = new System.Drawing.Size(271, 125);
            this.prieduDataGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Konfiguracijos ID";
            // 
            // deleteIDtxt
            // 
            this.deleteIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIDtxt.Location = new System.Drawing.Point(538, 214);
            this.deleteIDtxt.Name = "deleteIDtxt";
            this.deleteIDtxt.Size = new System.Drawing.Size(57, 22);
            this.deleteIDtxt.TabIndex = 7;
            // 
            // DeleteKonfigBtn
            // 
            this.DeleteKonfigBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteKonfigBtn.Location = new System.Drawing.Point(611, 209);
            this.DeleteKonfigBtn.Name = "DeleteKonfigBtn";
            this.DeleteKonfigBtn.Size = new System.Drawing.Size(159, 31);
            this.DeleteKonfigBtn.TabIndex = 32;
            this.DeleteKonfigBtn.Text = "Šalinti konfigūraciją";
            this.DeleteKonfigBtn.UseVisualStyleBackColor = true;
            this.DeleteKonfigBtn.Click += new System.EventHandler(this.DeleteKonfigBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.loggedUserTxt);
            this.Controls.Add(this.label1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.konfiguracijosDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prieduDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loggedUserTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MarkesModeliaiBtn;
        private System.Windows.Forms.Button PrieduBtn;
        private System.Windows.Forms.Button varikliaiBtn;
        private System.Windows.Forms.Button interjeraiBtn;
        private System.Windows.Forms.Button rataiBtn;
        private System.Windows.Forms.Button spalvaBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView konfiguracijosDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox konfigIDTxt;
        private System.Windows.Forms.Button ShowPriedaiBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView prieduDataGridView;
        private System.Windows.Forms.Button DeleteKonfigBtn;
        private System.Windows.Forms.TextBox deleteIDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}