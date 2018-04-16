namespace Clinic2018
{
    partial class clinic_search
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.lb55 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb44 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb33 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb22 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new Clinic2018.conn_patientTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.gb1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 566);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(165, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "ค้นหาประวัติ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ระบบบริหารจัดการงานบริการงานแพทย์และอนามัย ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(35, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 125);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "บัตรประชาชน";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "ชื่อ/สกุล";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "วัน เดือน ปีเกิด";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "โทรศัพท์";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "สถานะสิทธิ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.SystemColors.Control;
            this.gb1.Controls.Add(this.gb2);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gb1.Location = new System.Drawing.Point(17, 124);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(789, 425);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "แสดงข้อมูล";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.bt2);
            this.gb2.Controls.Add(this.bt1);
            this.gb2.Controls.Add(this.lb55);
            this.gb2.Controls.Add(this.label5);
            this.gb2.Controls.Add(this.lb44);
            this.gb2.Controls.Add(this.lb4);
            this.gb2.Controls.Add(this.lb33);
            this.gb2.Controls.Add(this.lb3);
            this.gb2.Controls.Add(this.lb22);
            this.gb2.Controls.Add(this.lb2);
            this.gb2.Controls.Add(this.lb11);
            this.gb2.Controls.Add(this.label1);
            this.gb2.Controls.Add(this.lb1);
            this.gb2.Location = new System.Drawing.Point(18, 177);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(754, 235);
            this.gb2.TabIndex = 10;
            this.gb2.TabStop = false;
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(300, 189);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 27);
            this.bt2.TabIndex = 12;
            this.bt2.Text = "ส่งคิว";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(219, 188);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 29);
            this.bt1.TabIndex = 11;
            this.bt1.Text = "ยกเลิก";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // lb55
            // 
            this.lb55.AutoSize = true;
            this.lb55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb55.Location = new System.Drawing.Point(150, 151);
            this.lb55.Name = "lb55";
            this.lb55.Size = new System.Drawing.Size(14, 20);
            this.lb55.TabIndex = 1;
            this.lb55.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(75, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "label1 :";
            // 
            // lb44
            // 
            this.lb44.AutoSize = true;
            this.lb44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb44.Location = new System.Drawing.Point(150, 121);
            this.lb44.Name = "lb44";
            this.lb44.Size = new System.Drawing.Size(14, 20);
            this.lb44.TabIndex = 3;
            this.lb44.Text = "-";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb4.Location = new System.Drawing.Point(64, 121);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(70, 20);
            this.lb4.TabIndex = 4;
            this.lb4.Text = "โทรศัพท์ :";
            // 
            // lb33
            // 
            this.lb33.AutoSize = true;
            this.lb33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb33.Location = new System.Drawing.Point(150, 91);
            this.lb33.Name = "lb33";
            this.lb33.Size = new System.Drawing.Size(14, 20);
            this.lb33.TabIndex = 5;
            this.lb33.Text = "-";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb3.Location = new System.Drawing.Point(28, 91);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(106, 20);
            this.lb3.TabIndex = 6;
            this.lb3.Text = "วัน/เดือน/ปีเกิด :";
            // 
            // lb22
            // 
            this.lb22.AutoSize = true;
            this.lb22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb22.Location = new System.Drawing.Point(150, 61);
            this.lb22.Name = "lb22";
            this.lb22.Size = new System.Drawing.Size(14, 20);
            this.lb22.TabIndex = 7;
            this.lb22.Text = "-";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb2.Location = new System.Drawing.Point(70, 61);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(64, 20);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "ชื่อ-สกุล :";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb11.Location = new System.Drawing.Point(150, 31);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(14, 20);
            this.lb11.TabIndex = 9;
            this.lb11.Text = "-";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb1.Location = new System.Drawing.Point(35, 31);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(99, 20);
            this.lb1.TabIndex = 10;
            this.lb1.Text = "บัตรประชาชน :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(484, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ค้นหา";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "บัตรประชาชน";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.patientTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Clinic2018.conn_patientTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(381, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ส่งให้พยาบาล**";
            // 
            // clinic_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 566);
            this.Controls.Add(this.panel1);
            this.Name = "clinic_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ค้นหาประวัติ - ระบบบริหารจัดการงานบริการงานแพทย์และอนามัย ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private conn_patientTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Label lb55;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb44;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb33;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb22;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
    }
}