
namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    partial class PriedoForm
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
            this.DeletePriedaBtn = new System.Windows.Forms.Button();
            this.priedoIDtxt = new System.Windows.Forms.TextBox();
            this.AddPriedaBtn = new System.Windows.Forms.Button();
            this.priedoKainaTxt = new System.Windows.Forms.TextBox();
            this.priedoPavTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prieduDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prieduDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeletePriedaBtn);
            this.groupBox1.Controls.Add(this.priedoIDtxt);
            this.groupBox1.Controls.Add(this.AddPriedaBtn);
            this.groupBox1.Controls.Add(this.priedoKainaTxt);
            this.groupBox1.Controls.Add(this.priedoPavTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.prieduDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 399);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priedų informacija";
            // 
            // DeletePriedaBtn
            // 
            this.DeletePriedaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePriedaBtn.Location = new System.Drawing.Point(270, 363);
            this.DeletePriedaBtn.Name = "DeletePriedaBtn";
            this.DeletePriedaBtn.Size = new System.Drawing.Size(152, 30);
            this.DeletePriedaBtn.TabIndex = 8;
            this.DeletePriedaBtn.Text = "Ištrinti priedą";
            this.DeletePriedaBtn.UseVisualStyleBackColor = true;
            this.DeletePriedaBtn.Click += new System.EventHandler(this.DeletePriedaBtn_Click);
            // 
            // priedoIDtxt
            // 
            this.priedoIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priedoIDtxt.Location = new System.Drawing.Point(89, 367);
            this.priedoIDtxt.Name = "priedoIDtxt";
            this.priedoIDtxt.Size = new System.Drawing.Size(175, 22);
            this.priedoIDtxt.TabIndex = 7;
            // 
            // AddPriedaBtn
            // 
            this.AddPriedaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPriedaBtn.Location = new System.Drawing.Point(9, 324);
            this.AddPriedaBtn.Name = "AddPriedaBtn";
            this.AddPriedaBtn.Size = new System.Drawing.Size(413, 30);
            this.AddPriedaBtn.TabIndex = 6;
            this.AddPriedaBtn.Text = "Pridėti naują priedą";
            this.AddPriedaBtn.UseVisualStyleBackColor = true;
            this.AddPriedaBtn.Click += new System.EventHandler(this.AddPriedaBtn_Click);
            // 
            // priedoKainaTxt
            // 
            this.priedoKainaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priedoKainaTxt.Location = new System.Drawing.Point(154, 295);
            this.priedoKainaTxt.Name = "priedoKainaTxt";
            this.priedoKainaTxt.Size = new System.Drawing.Size(268, 22);
            this.priedoKainaTxt.TabIndex = 5;
            // 
            // priedoPavTxt
            // 
            this.priedoPavTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priedoPavTxt.Location = new System.Drawing.Point(154, 262);
            this.priedoPavTxt.Name = "priedoPavTxt";
            this.priedoPavTxt.Size = new System.Drawing.Size(268, 22);
            this.priedoPavTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 298);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Priedo kaina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priedo pavadinimas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Priedo ID:";
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
            this.prieduDataGridView.Size = new System.Drawing.Size(416, 237);
            this.prieduDataGridView.TabIndex = 0;
            // 
            // PriedoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "PriedoForm";
            this.Text = "PriedoForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prieduDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeletePriedaBtn;
        private System.Windows.Forms.TextBox priedoIDtxt;
        private System.Windows.Forms.Button AddPriedaBtn;
        private System.Windows.Forms.TextBox priedoKainaTxt;
        private System.Windows.Forms.TextBox priedoPavTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView prieduDataGridView;
    }
}