namespace DbFirstFlightProject
{
    partial class FrmEmployee
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblAvgSalary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSumSalary = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMaxSalaryEmployee = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaxSalary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(420, 118);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 39);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(284, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 39);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 39);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Departman:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(444, 27);
            this.txtName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Personel Adı:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(106, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(444, 27);
            this.txtID.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 164);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Personel ID:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 118);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(130, 39);
            this.btnList.TabIndex = 13;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(444, 27);
            this.comboBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(566, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Toplam Kişi Sayısı:";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCount.Location = new System.Drawing.Point(718, 17);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(30, 23);
            this.lblTotalCount.TabIndex = 26;
            this.lblTotalCount.Text = "00";
            // 
            // lblAvgSalary
            // 
            this.lblAvgSalary.AutoSize = true;
            this.lblAvgSalary.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAvgSalary.Location = new System.Drawing.Point(718, 83);
            this.lblAvgSalary.Name = "lblAvgSalary";
            this.lblAvgSalary.Size = new System.Drawing.Size(30, 23);
            this.lblAvgSalary.TabIndex = 28;
            this.lblAvgSalary.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(566, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Toplam Maaş:";
            // 
            // lblSumSalary
            // 
            this.lblSumSalary.AutoSize = true;
            this.lblSumSalary.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSumSalary.Location = new System.Drawing.Point(718, 50);
            this.lblSumSalary.Name = "lblSumSalary";
            this.lblSumSalary.Size = new System.Drawing.Size(30, 23);
            this.lblSumSalary.TabIndex = 30;
            this.lblSumSalary.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(566, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ortalama Maaş:";
            // 
            // lblMaxSalaryEmployee
            // 
            this.lblMaxSalaryEmployee.AutoSize = true;
            this.lblMaxSalaryEmployee.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxSalaryEmployee.Location = new System.Drawing.Point(651, 204);
            this.lblMaxSalaryEmployee.Name = "lblMaxSalaryEmployee";
            this.lblMaxSalaryEmployee.Size = new System.Drawing.Size(30, 23);
            this.lblMaxSalaryEmployee.TabIndex = 32;
            this.lblMaxSalaryEmployee.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(566, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Personel:";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(556, 245);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(280, 39);
            this.btnStatistics.TabIndex = 33;
            this.btnStatistics.Text = "İstatistikler";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(566, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "En Yüksek Maaş:";
            // 
            // lblMaxSalary
            // 
            this.lblMaxSalary.AutoSize = true;
            this.lblMaxSalary.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxSalary.Location = new System.Drawing.Point(718, 114);
            this.lblMaxSalary.Name = "lblMaxSalary";
            this.lblMaxSalary.Size = new System.Drawing.Size(30, 23);
            this.lblMaxSalary.TabIndex = 34;
            this.lblMaxSalary.Text = "00";
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 333);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMaxSalary);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.lblMaxSalaryEmployee);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSumSalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAvgSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblAvgSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSumSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMaxSalaryEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaxSalary;
    }
}