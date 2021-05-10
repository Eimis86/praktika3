
namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    partial class MarkesModeliaiForm
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
            this.DeleteMarkeBtn = new System.Windows.Forms.Button();
            this.markesIDtxt = new System.Windows.Forms.TextBox();
            this.AddMarkeBtn = new System.Windows.Forms.Button();
            this.markesPavTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.markesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.markesComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteModeliBtn = new System.Windows.Forms.Button();
            this.modelioIDtxt = new System.Windows.Forms.TextBox();
            this.AddModeliBtn = new System.Windows.Forms.Button();
            this.modelioPavTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modeliuDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markesDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeliuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteMarkeBtn);
            this.groupBox1.Controls.Add(this.markesIDtxt);
            this.groupBox1.Controls.Add(this.AddMarkeBtn);
            this.groupBox1.Controls.Add(this.markesPavTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.markesDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 399);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Markių informacija";
            // 
            // DeleteMarkeBtn
            // 
            this.DeleteMarkeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMarkeBtn.Location = new System.Drawing.Point(270, 363);
            this.DeleteMarkeBtn.Name = "DeleteMarkeBtn";
            this.DeleteMarkeBtn.Size = new System.Drawing.Size(152, 30);
            this.DeleteMarkeBtn.TabIndex = 8;
            this.DeleteMarkeBtn.Text = "Ištrinti markę";
            this.DeleteMarkeBtn.UseVisualStyleBackColor = true;
            this.DeleteMarkeBtn.Click += new System.EventHandler(this.DeleteMarkeBtn_Click);
            // 
            // markesIDtxt
            // 
            this.markesIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markesIDtxt.Location = new System.Drawing.Point(89, 367);
            this.markesIDtxt.Name = "markesIDtxt";
            this.markesIDtxt.Size = new System.Drawing.Size(175, 22);
            this.markesIDtxt.TabIndex = 7;
            // 
            // AddMarkeBtn
            // 
            this.AddMarkeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMarkeBtn.Location = new System.Drawing.Point(9, 324);
            this.AddMarkeBtn.Name = "AddMarkeBtn";
            this.AddMarkeBtn.Size = new System.Drawing.Size(413, 30);
            this.AddMarkeBtn.TabIndex = 6;
            this.AddMarkeBtn.Text = "Pridėti naują markę";
            this.AddMarkeBtn.UseVisualStyleBackColor = true;
            this.AddMarkeBtn.Click += new System.EventHandler(this.AddMarkeBtn_Click);
            // 
            // markesPavTxt
            // 
            this.markesPavTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markesPavTxt.Location = new System.Drawing.Point(154, 262);
            this.markesPavTxt.Name = "markesPavTxt";
            this.markesPavTxt.Size = new System.Drawing.Size(268, 22);
            this.markesPavTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Markės pavadinimas :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Markės ID :";
            // 
            // markesDataGridView
            // 
            this.markesDataGridView.AllowUserToOrderColumns = true;
            this.markesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.markesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.markesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.markesDataGridView.Name = "markesDataGridView";
            this.markesDataGridView.ReadOnly = true;
            this.markesDataGridView.Size = new System.Drawing.Size(416, 237);
            this.markesDataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.markesComboBox);
            this.groupBox2.Controls.Add(this.DeleteModeliBtn);
            this.groupBox2.Controls.Add(this.modelioIDtxt);
            this.groupBox2.Controls.Add(this.AddModeliBtn);
            this.groupBox2.Controls.Add(this.modelioPavTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.modeliuDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(446, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 399);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modelių informacija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Markė :";
            // 
            // markesComboBox
            // 
            this.markesComboBox.FormattingEnabled = true;
            this.markesComboBox.Location = new System.Drawing.Point(154, 290);
            this.markesComboBox.Name = "markesComboBox";
            this.markesComboBox.Size = new System.Drawing.Size(268, 21);
            this.markesComboBox.TabIndex = 9;
            // 
            // DeleteModeliBtn
            // 
            this.DeleteModeliBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteModeliBtn.Location = new System.Drawing.Point(270, 363);
            this.DeleteModeliBtn.Name = "DeleteModeliBtn";
            this.DeleteModeliBtn.Size = new System.Drawing.Size(152, 30);
            this.DeleteModeliBtn.TabIndex = 8;
            this.DeleteModeliBtn.Text = "Ištrinti modelį";
            this.DeleteModeliBtn.UseVisualStyleBackColor = true;
            this.DeleteModeliBtn.Click += new System.EventHandler(this.DeleteModeliBtn_Click);
            // 
            // modelioIDtxt
            // 
            this.modelioIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelioIDtxt.Location = new System.Drawing.Point(89, 367);
            this.modelioIDtxt.Name = "modelioIDtxt";
            this.modelioIDtxt.Size = new System.Drawing.Size(175, 22);
            this.modelioIDtxt.TabIndex = 7;
            // 
            // AddModeliBtn
            // 
            this.AddModeliBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddModeliBtn.Location = new System.Drawing.Point(9, 324);
            this.AddModeliBtn.Name = "AddModeliBtn";
            this.AddModeliBtn.Size = new System.Drawing.Size(413, 30);
            this.AddModeliBtn.TabIndex = 6;
            this.AddModeliBtn.Text = "Pridėt naują modelį";
            this.AddModeliBtn.UseVisualStyleBackColor = true;
            this.AddModeliBtn.Click += new System.EventHandler(this.AddModeliBtn_Click);
            // 
            // modelioPavTxt
            // 
            this.modelioPavTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelioPavTxt.Location = new System.Drawing.Point(154, 262);
            this.modelioPavTxt.Name = "modelioPavTxt";
            this.modelioPavTxt.Size = new System.Drawing.Size(268, 22);
            this.modelioPavTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Modelio pavadinimas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Modelio ID :";
            // 
            // modeliuDataGridView
            // 
            this.modeliuDataGridView.AllowUserToOrderColumns = true;
            this.modeliuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modeliuDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.modeliuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modeliuDataGridView.Location = new System.Drawing.Point(6, 19);
            this.modeliuDataGridView.Name = "modeliuDataGridView";
            this.modeliuDataGridView.ReadOnly = true;
            this.modeliuDataGridView.Size = new System.Drawing.Size(416, 237);
            this.modeliuDataGridView.TabIndex = 0;
            // 
            // MarkesModeliaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MarkesModeliaiForm";
            this.Text = "MarkesModeliaiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markesDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeliuDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteMarkeBtn;
        private System.Windows.Forms.TextBox markesIDtxt;
        private System.Windows.Forms.Button AddMarkeBtn;
        private System.Windows.Forms.TextBox markesPavTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView markesDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteModeliBtn;
        private System.Windows.Forms.TextBox modelioIDtxt;
        private System.Windows.Forms.Button AddModeliBtn;
        private System.Windows.Forms.TextBox modelioPavTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView modeliuDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox markesComboBox;
    }
}