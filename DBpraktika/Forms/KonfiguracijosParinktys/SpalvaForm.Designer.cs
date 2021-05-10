
namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    partial class SpalvaForm
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
            this.deleteSpalvaBtn = new System.Windows.Forms.Button();
            this.spalvosIDtxt = new System.Windows.Forms.TextBox();
            this.addSpalvaBtn = new System.Windows.Forms.Button();
            this.spalvosKainaTxt = new System.Windows.Forms.TextBox();
            this.spalvosPavTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spalvuDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spalvuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteSpalvaBtn);
            this.groupBox1.Controls.Add(this.spalvosIDtxt);
            this.groupBox1.Controls.Add(this.addSpalvaBtn);
            this.groupBox1.Controls.Add(this.spalvosKainaTxt);
            this.groupBox1.Controls.Add(this.spalvosPavTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.spalvuDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spalvų Informacija";
            // 
            // deleteSpalvaBtn
            // 
            this.deleteSpalvaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSpalvaBtn.Location = new System.Drawing.Point(270, 363);
            this.deleteSpalvaBtn.Name = "deleteSpalvaBtn";
            this.deleteSpalvaBtn.Size = new System.Drawing.Size(152, 30);
            this.deleteSpalvaBtn.TabIndex = 8;
            this.deleteSpalvaBtn.Text = "Ištrinti spalvą";
            this.deleteSpalvaBtn.UseVisualStyleBackColor = true;
            this.deleteSpalvaBtn.Click += new System.EventHandler(this.deleteSpalvaBtn_Click);
            // 
            // spalvosIDtxt
            // 
            this.spalvosIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spalvosIDtxt.Location = new System.Drawing.Point(89, 367);
            this.spalvosIDtxt.Name = "spalvosIDtxt";
            this.spalvosIDtxt.Size = new System.Drawing.Size(175, 22);
            this.spalvosIDtxt.TabIndex = 7;
            // 
            // addSpalvaBtn
            // 
            this.addSpalvaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSpalvaBtn.Location = new System.Drawing.Point(9, 324);
            this.addSpalvaBtn.Name = "addSpalvaBtn";
            this.addSpalvaBtn.Size = new System.Drawing.Size(413, 30);
            this.addSpalvaBtn.TabIndex = 6;
            this.addSpalvaBtn.Text = "Pridėti naują spalvą";
            this.addSpalvaBtn.UseVisualStyleBackColor = true;
            this.addSpalvaBtn.Click += new System.EventHandler(this.addSpalvaBtn_Click);
            // 
            // spalvosKainaTxt
            // 
            this.spalvosKainaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spalvosKainaTxt.Location = new System.Drawing.Point(154, 295);
            this.spalvosKainaTxt.Name = "spalvosKainaTxt";
            this.spalvosKainaTxt.Size = new System.Drawing.Size(268, 22);
            this.spalvosKainaTxt.TabIndex = 5;
            // 
            // spalvosPavTxt
            // 
            this.spalvosPavTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spalvosPavTxt.Location = new System.Drawing.Point(154, 262);
            this.spalvosPavTxt.Name = "spalvosPavTxt";
            this.spalvosPavTxt.Size = new System.Drawing.Size(268, 22);
            this.spalvosPavTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 295);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Spalvos kaina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spalvos pavadinimas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spalvos ID:";
            // 
            // spalvuDataGridView
            // 
            this.spalvuDataGridView.AllowUserToOrderColumns = true;
            this.spalvuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.spalvuDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.spalvuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spalvuDataGridView.Location = new System.Drawing.Point(6, 19);
            this.spalvuDataGridView.Name = "spalvuDataGridView";
            this.spalvuDataGridView.ReadOnly = true;
            this.spalvuDataGridView.Size = new System.Drawing.Size(416, 237);
            this.spalvuDataGridView.TabIndex = 0;
            // 
            // SpalvaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 423);
            this.Controls.Add(this.groupBox1);
            this.Name = "SpalvaForm";
            this.Text = "SpalvaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spalvuDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView spalvuDataGridView;
        private System.Windows.Forms.TextBox spalvosPavTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spalvosKainaTxt;
        private System.Windows.Forms.Button deleteSpalvaBtn;
        private System.Windows.Forms.TextBox spalvosIDtxt;
        private System.Windows.Forms.Button addSpalvaBtn;
    }
}