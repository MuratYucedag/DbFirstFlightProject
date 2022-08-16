namespace DbFirstFlightProject
{
    partial class FrmPassenger
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
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnList2 = new System.Windows.Forms.Button();
            this.btnWomenPassengerList = new System.Windows.Forms.Button();
            this.btnMenPassengerList = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.lblTotalPassengerCount = new System.Windows.Forms.Label();
            this.lblWomenCount = new System.Windows.Forms.Label();
            this.lblMenCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(420, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 39);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(284, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 39);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 39);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(101, 77);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(449, 27);
            this.txtSurname.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yolcu Soyadı:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(449, 27);
            this.txtName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yolcu Adı:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(101, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(449, 27);
            this.txtID.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 164);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Yolcu ID:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 178);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(130, 39);
            this.btnList.TabIndex = 13;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(101, 110);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(449, 27);
            this.txtAge.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Yolcu Yaş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cinsiyet:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(101, 143);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(449, 27);
            this.cmbGender.TabIndex = 27;
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(556, 348);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(130, 39);
            this.btnList2.TabIndex = 28;
            this.btnList2.Text = "Listele";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // btnWomenPassengerList
            // 
            this.btnWomenPassengerList.Location = new System.Drawing.Point(556, 303);
            this.btnWomenPassengerList.Name = "btnWomenPassengerList";
            this.btnWomenPassengerList.Size = new System.Drawing.Size(130, 39);
            this.btnWomenPassengerList.TabIndex = 29;
            this.btnWomenPassengerList.Text = "Kadın Yolcular";
            this.btnWomenPassengerList.UseVisualStyleBackColor = true;
            this.btnWomenPassengerList.Click += new System.EventHandler(this.btnWomenPassengerList_Click);
            // 
            // btnMenPassengerList
            // 
            this.btnMenPassengerList.Location = new System.Drawing.Point(556, 258);
            this.btnMenPassengerList.Name = "btnMenPassengerList";
            this.btnMenPassengerList.Size = new System.Drawing.Size(130, 39);
            this.btnMenPassengerList.TabIndex = 30;
            this.btnMenPassengerList.Text = "Erkek Yolcular";
            this.btnMenPassengerList.UseVisualStyleBackColor = true;
            this.btnMenPassengerList.Click += new System.EventHandler(this.btnMenPassengerList_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(556, 213);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(130, 39);
            this.btnStatistics.TabIndex = 31;
            this.btnStatistics.Text = "İstatistikler";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // lblTotalPassengerCount
            // 
            this.lblTotalPassengerCount.AutoSize = true;
            this.lblTotalPassengerCount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPassengerCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalPassengerCount.Location = new System.Drawing.Point(717, 14);
            this.lblTotalPassengerCount.Name = "lblTotalPassengerCount";
            this.lblTotalPassengerCount.Size = new System.Drawing.Size(65, 26);
            this.lblTotalPassengerCount.TabIndex = 32;
            this.lblTotalPassengerCount.Text = "label6";
            // 
            // lblWomenCount
            // 
            this.lblWomenCount.AutoSize = true;
            this.lblWomenCount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWomenCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblWomenCount.Location = new System.Drawing.Point(717, 47);
            this.lblWomenCount.Name = "lblWomenCount";
            this.lblWomenCount.Size = new System.Drawing.Size(65, 26);
            this.lblWomenCount.TabIndex = 33;
            this.lblWomenCount.Text = "label6";
            // 
            // lblMenCount
            // 
            this.lblMenCount.AutoSize = true;
            this.lblMenCount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblMenCount.Location = new System.Drawing.Point(717, 78);
            this.lblMenCount.Name = "lblMenCount";
            this.lblMenCount.Size = new System.Drawing.Size(65, 26);
            this.lblMenCount.TabIndex = 34;
            this.lblMenCount.Text = "label6";
            // 
            // FrmPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 393);
            this.Controls.Add(this.lblMenCount);
            this.Controls.Add(this.lblWomenCount);
            this.Controls.Add(this.lblTotalPassengerCount);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnMenPassengerList);
            this.Controls.Add(this.btnWomenPassengerList);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPassenger";
            this.Text = "FrmPassenger";
            this.Load += new System.EventHandler(this.FrmPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnList2;
        private System.Windows.Forms.Button btnWomenPassengerList;
        private System.Windows.Forms.Button btnMenPassengerList;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label lblTotalPassengerCount;
        private System.Windows.Forms.Label lblWomenCount;
        private System.Windows.Forms.Label lblMenCount;
    }
}