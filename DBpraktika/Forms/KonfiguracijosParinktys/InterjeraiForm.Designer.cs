
namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    partial class InterjeraiForm
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
            this.deleteInterjeraBtn = new System.Windows.Forms.Button();
            this.interjeroIDtxt = new System.Windows.Forms.TextBox();
            this.addInterjeraBtn = new System.Windows.Forms.Button();
            this.interjeroKainaTxt = new System.Windows.Forms.TextBox();
            this.interjeroPavTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.interjeruDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interjeruDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteInterjeraBtn);
            this.groupBox1.Controls.Add(this.interjeroIDtxt);
            this.groupBox1.Controls.Add(this.addInterjeraBtn);
            this.groupBox1.Controls.Add(this.interjeroKainaTxt);
            this.groupBox1.Controls.Add(this.interjeroPavTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.interjeruDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interjerų informacija";
            // 
            // deleteInterjeraBtn
            // 
            this.deleteInterjeraBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInterjeraBtn.Location = new System.Drawing.Point(270, 363);
            this.deleteInterjeraBtn.Name = "deleteInterjeraBtn";
            this.deleteInterjeraBtn.Size = new System.Drawing.Size(152, 30);
            this.deleteInterjeraBtn.TabIndex = 8;
            this.deleteInterjeraBtn.Text = "Ištrinti interjerą";
            this.deleteInterjeraBtn.UseVisualStyleBackColor = true;
            this.deleteInterjeraBtn.Click += new System.EventHandler(this.deleteInterjeraBtn_Click);
            // 
            // interjeroIDtxt
            // 
            this.interjeroIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interjeroIDtxt.Location = new System.Drawing.Point(89, 367);
            this.interjeroIDtxt.Name = "interjeroIDtxt";
            this.interjeroIDtxt.Size = new System.Drawing.Size(175, 22);
            this.interjeroIDtxt.TabIndex = 7;
            // 
            // addInterjeraBtn
            // 
            this.addInterjeraBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInterjeraBtn.Location = new System.Drawing.Point(9, 324);
            this.addInterjeraBtn.Name = "addInterjeraBtn";
            this.addInterjeraBtn.Size = new System.Drawing.Size(413, 30);
            this.addInterjeraBtn.TabIndex = 6;
            this.addInterjeraBtn.Text = "Pridėti naują interjerą ";
            this.addInterjeraBtn.UseVisualStyleBackColor = true;
            this.addInterjeraBtn.Click += new System.EventHandler(this.addInterjeraBtn_Click);
            // 
            // interjeroKainaTxt
            // 
            this.interjeroKainaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interjeroKainaTxt.Location = new System.Drawing.Point(154, 295);
            this.interjeroKainaTxt.Name = "interjeroKainaTxt";
            this.interjeroKainaTxt.Size = new System.Drawing.Size(268, 22);
            this.interjeroKainaTxt.TabIndex = 5;
            // 
            // interjeroPavTxt
            // 
            this.interjeroPavTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interjeroPavTxt.Location = new System.Drawing.Point(154, 262);
            this.interjeroPavTxt.Name = "interjeroPavTxt";
            this.interjeroPavTxt.Size = new System.Drawing.Size(268, 22);
            this.interjeroPavTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 298);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interjero kaina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interjero Pavadinimas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interjero ID:";
            // 
            // interjeruDataGridView
            // 
            this.interjeruDataGridView.AllowUserToOrderColumns = true;
            this.interjeruDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.interjeruDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.interjeruDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interjeruDataGridView.Location = new System.Drawing.Point(6, 19);
            this.interjeruDataGridView.Name = "interjeruDataGridView";
            this.interjeruDataGridView.ReadOnly = true;
            this.interjeruDataGridView.Size = new System.Drawing.Size(416, 237);
            this.interjeruDataGridView.TabIndex = 0;
            // 
            // InterjeraiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 422);
            this.Controls.Add(this.groupBox1);
            this.Name = "InterjeraiForm";
            this.Text = "InterjeraiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interjeruDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteInterjeraBtn;
        private System.Windows.Forms.TextBox interjeroIDtxt;
        private System.Windows.Forms.Button addInterjeraBtn;
        private System.Windows.Forms.TextBox interjeroKainaTxt;
        private System.Windows.Forms.TextBox interjeroPavTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView interjeruDataGridView;
    }
}