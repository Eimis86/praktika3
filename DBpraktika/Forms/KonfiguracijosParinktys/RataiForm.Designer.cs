
namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    partial class RataiForm
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
            this.deleteRataiBtn = new System.Windows.Forms.Button();
            this.ratuIDtxt = new System.Windows.Forms.TextBox();
            this.addRataiBtn = new System.Windows.Forms.Button();
            this.ratuKainaTxt = new System.Windows.Forms.TextBox();
            this.ratuPavTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ratuDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteRataiBtn);
            this.groupBox1.Controls.Add(this.ratuIDtxt);
            this.groupBox1.Controls.Add(this.addRataiBtn);
            this.groupBox1.Controls.Add(this.ratuKainaTxt);
            this.groupBox1.Controls.Add(this.ratuPavTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ratuDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ratų informacija";
            // 
            // deleteRataiBtn
            // 
            this.deleteRataiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRataiBtn.Location = new System.Drawing.Point(270, 363);
            this.deleteRataiBtn.Name = "deleteRataiBtn";
            this.deleteRataiBtn.Size = new System.Drawing.Size(152, 30);
            this.deleteRataiBtn.TabIndex = 8;
            this.deleteRataiBtn.Text = "Ištrinti ratus";
            this.deleteRataiBtn.UseVisualStyleBackColor = true;
            this.deleteRataiBtn.Click += new System.EventHandler(this.deleteRataiBtn_Click);
            // 
            // ratuIDtxt
            // 
            this.ratuIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratuIDtxt.Location = new System.Drawing.Point(89, 367);
            this.ratuIDtxt.Name = "ratuIDtxt";
            this.ratuIDtxt.Size = new System.Drawing.Size(175, 22);
            this.ratuIDtxt.TabIndex = 7;
            // 
            // addRataiBtn
            // 
            this.addRataiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRataiBtn.Location = new System.Drawing.Point(9, 324);
            this.addRataiBtn.Name = "addRataiBtn";
            this.addRataiBtn.Size = new System.Drawing.Size(413, 30);
            this.addRataiBtn.TabIndex = 6;
            this.addRataiBtn.Text = "Pridėti naujus ratus";
            this.addRataiBtn.UseVisualStyleBackColor = true;
            this.addRataiBtn.Click += new System.EventHandler(this.addRataiBtn_Click);
            // 
            // ratuKainaTxt
            // 
            this.ratuKainaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratuKainaTxt.Location = new System.Drawing.Point(154, 295);
            this.ratuKainaTxt.Name = "ratuKainaTxt";
            this.ratuKainaTxt.Size = new System.Drawing.Size(268, 22);
            this.ratuKainaTxt.TabIndex = 5;
            // 
            // ratuPavTxt
            // 
            this.ratuPavTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratuPavTxt.Location = new System.Drawing.Point(154, 262);
            this.ratuPavTxt.Name = "ratuPavTxt";
            this.ratuPavTxt.Size = new System.Drawing.Size(268, 22);
            this.ratuPavTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 298);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ratu kaina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ratu pavadinimas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ratu ID:";
            // 
            // ratuDataGridView
            // 
            this.ratuDataGridView.AllowUserToOrderColumns = true;
            this.ratuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ratuDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ratuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratuDataGridView.Location = new System.Drawing.Point(6, 19);
            this.ratuDataGridView.Name = "ratuDataGridView";
            this.ratuDataGridView.ReadOnly = true;
            this.ratuDataGridView.Size = new System.Drawing.Size(416, 237);
            this.ratuDataGridView.TabIndex = 0;
            // 
            // RataiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 426);
            this.Controls.Add(this.groupBox1);
            this.Name = "RataiForm";
            this.Text = "RataiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratuDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteRataiBtn;
        private System.Windows.Forms.TextBox ratuIDtxt;
        private System.Windows.Forms.Button addRataiBtn;
        private System.Windows.Forms.TextBox ratuKainaTxt;
        private System.Windows.Forms.TextBox ratuPavTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ratuDataGridView;
    }
}