
namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    partial class KonfiguracijosForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteKonfigBtn = new System.Windows.Forms.Button();
            this.deleteIDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.konfiguracijosDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.konfigIDTxt = new System.Windows.Forms.TextBox();
            this.ShowPriedaiBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.prieduDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.konfiguracijosDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prieduDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DeleteKonfigBtn);
            this.groupBox1.Controls.Add(this.deleteIDtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.konfiguracijosDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 364);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Užsakytos konfigūracijos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(611, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteKonfigBtn
            // 
            this.DeleteKonfigBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteKonfigBtn.Location = new System.Drawing.Point(535, 300);
            this.DeleteKonfigBtn.Name = "DeleteKonfigBtn";
            this.DeleteKonfigBtn.Size = new System.Drawing.Size(159, 31);
            this.DeleteKonfigBtn.TabIndex = 32;
            this.DeleteKonfigBtn.Text = "Šalinti konfigūraciją";
            this.DeleteKonfigBtn.UseVisualStyleBackColor = true;
            this.DeleteKonfigBtn.Click += new System.EventHandler(this.DeleteKonfigBtn_Click);
            // 
            // deleteIDtxt
            // 
            this.deleteIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIDtxt.Location = new System.Drawing.Point(646, 256);
            this.deleteIDtxt.Name = "deleteIDtxt";
            this.deleteIDtxt.Size = new System.Drawing.Size(57, 22);
            this.deleteIDtxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Konfiguracijos ID";
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
            this.groupBox3.Location = new System.Drawing.Point(6, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 150);
            this.groupBox3.TabIndex = 7;
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
            // KonfiguracijosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 386);
            this.Controls.Add(this.groupBox1);
            this.Name = "KonfiguracijosForm";
            this.Text = "KonfiguracijosForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.konfiguracijosDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prieduDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteKonfigBtn;
        private System.Windows.Forms.TextBox deleteIDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView konfiguracijosDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox konfigIDTxt;
        private System.Windows.Forms.Button ShowPriedaiBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView prieduDataGridView;
    }
}