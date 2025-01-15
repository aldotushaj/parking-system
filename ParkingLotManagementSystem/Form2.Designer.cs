namespace ParkingLotManagementSystem
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.vehicleinTB = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.deleteTB = new System.Windows.Forms.Button();
            this.logoutTB = new System.Windows.Forms.Button();
            this.salesTB = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.licenseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeinCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeoutCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.licenseTB = new System.Windows.Forms.TextBox();
            this.brandTB = new System.Windows.Forms.TextBox();
            this.colorTB = new System.Windows.Forms.TextBox();
            this.timeinTB = new System.Windows.Forms.DateTimePicker();
            this.timeoutTB = new System.Windows.Forms.DateTimePicker();
            this.durationTB = new System.Windows.Forms.TextBox();
            this.costTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBut = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.occupiedLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.attendantLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleinTB
            // 
            this.vehicleinTB.BackColor = System.Drawing.Color.LightGreen;
            this.vehicleinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleinTB.Location = new System.Drawing.Point(146, 383);
            this.vehicleinTB.Name = "vehicleinTB";
            this.vehicleinTB.Size = new System.Drawing.Size(99, 33);
            this.vehicleinTB.TabIndex = 0;
            this.vehicleinTB.Text = "VEHICLE IN";
            this.vehicleinTB.UseVisualStyleBackColor = false;
            this.vehicleinTB.Click += new System.EventHandler(this.vehicleinTB_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // deleteTB
            // 
            this.deleteTB.BackColor = System.Drawing.Color.Red;
            this.deleteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTB.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteTB.Location = new System.Drawing.Point(263, 607);
            this.deleteTB.Name = "deleteTB";
            this.deleteTB.Size = new System.Drawing.Size(99, 33);
            this.deleteTB.TabIndex = 3;
            this.deleteTB.Text = "DELETE";
            this.deleteTB.UseVisualStyleBackColor = false;
            this.deleteTB.Click += new System.EventHandler(this.deleteTB_Click);
            // 
            // logoutTB
            // 
            this.logoutTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutTB.Location = new System.Drawing.Point(950, 607);
            this.logoutTB.Name = "logoutTB";
            this.logoutTB.Size = new System.Drawing.Size(99, 33);
            this.logoutTB.TabIndex = 4;
            this.logoutTB.Text = "LOG OUT";
            this.logoutTB.UseVisualStyleBackColor = true;
            this.logoutTB.Click += new System.EventHandler(this.logoutTB_Click);
            // 
            // salesTB
            // 
            this.salesTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTB.Location = new System.Drawing.Point(368, 607);
            this.salesTB.Name = "salesTB";
            this.salesTB.Size = new System.Drawing.Size(99, 33);
            this.salesTB.TabIndex = 5;
            this.salesTB.Text = "SALES";
            this.salesTB.UseVisualStyleBackColor = true;
            this.salesTB.Click += new System.EventHandler(this.salesTB_Click);
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToResizeColumns = false;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licenseCol,
            this.brandCol,
            this.colorCol,
            this.timeinCol,
            this.timeoutCol,
            this.durationCol,
            this.costCol});
            this.dataTable.Location = new System.Drawing.Point(263, 219);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.Size = new System.Drawing.Size(786, 382);
            this.dataTable.TabIndex = 6;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // licenseCol
            // 
            this.licenseCol.FillWeight = 134.9172F;
            this.licenseCol.HeaderText = "LICENSE PLATE";
            this.licenseCol.Name = "licenseCol";
            this.licenseCol.ReadOnly = true;
            this.licenseCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // brandCol
            // 
            this.brandCol.FillWeight = 104.0789F;
            this.brandCol.HeaderText = "BRAND";
            this.brandCol.Name = "brandCol";
            this.brandCol.ReadOnly = true;
            // 
            // colorCol
            // 
            this.colorCol.FillWeight = 104.0789F;
            this.colorCol.HeaderText = "COLOR";
            this.colorCol.Name = "colorCol";
            this.colorCol.ReadOnly = true;
            // 
            // timeinCol
            // 
            this.timeinCol.FillWeight = 104.0789F;
            this.timeinCol.HeaderText = "TIME IN";
            this.timeinCol.Name = "timeinCol";
            this.timeinCol.ReadOnly = true;
            // 
            // timeoutCol
            // 
            this.timeoutCol.FillWeight = 104.0789F;
            this.timeoutCol.HeaderText = "TIME OUT";
            this.timeoutCol.Name = "timeoutCol";
            this.timeoutCol.ReadOnly = true;
            // 
            // durationCol
            // 
            this.durationCol.FillWeight = 104.0789F;
            this.durationCol.HeaderText = "DURATION";
            this.durationCol.Name = "durationCol";
            this.durationCol.ReadOnly = true;
            // 
            // costCol
            // 
            this.costCol.FillWeight = 104.0789F;
            this.costCol.HeaderText = "AMOUNT";
            this.costCol.Name = "costCol";
            this.costCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "LICENSE PLATE";
            // 
            // licenseTB
            // 
            this.licenseTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.licenseTB.Location = new System.Drawing.Point(113, 222);
            this.licenseTB.Name = "licenseTB";
            this.licenseTB.Size = new System.Drawing.Size(132, 20);
            this.licenseTB.TabIndex = 8;
            this.licenseTB.TextChanged += new System.EventHandler(this.licenseTB_TextChanged);
            // 
            // brandTB
            // 
            this.brandTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.brandTB.Location = new System.Drawing.Point(114, 265);
            this.brandTB.Name = "brandTB";
            this.brandTB.Size = new System.Drawing.Size(131, 20);
            this.brandTB.TabIndex = 9;
            // 
            // colorTB
            // 
            this.colorTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.colorTB.Location = new System.Drawing.Point(113, 308);
            this.colorTB.Name = "colorTB";
            this.colorTB.Size = new System.Drawing.Size(132, 20);
            this.colorTB.TabIndex = 10;
            // 
            // timeinTB
            // 
            this.timeinTB.Enabled = false;
            this.timeinTB.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeinTB.Location = new System.Drawing.Point(146, 357);
            this.timeinTB.Name = "timeinTB";
            this.timeinTB.Size = new System.Drawing.Size(99, 20);
            this.timeinTB.TabIndex = 11;
            this.timeinTB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // timeoutTB
            // 
            this.timeoutTB.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeoutTB.Location = new System.Drawing.Point(146, 451);
            this.timeoutTB.Name = "timeoutTB";
            this.timeoutTB.Size = new System.Drawing.Size(99, 20);
            this.timeoutTB.TabIndex = 12;
            this.timeoutTB.Leave += new System.EventHandler(this.timeoutTB_Leave);
            // 
            // durationTB
            // 
            this.durationTB.Enabled = false;
            this.durationTB.Location = new System.Drawing.Point(146, 544);
            this.durationTB.Name = "durationTB";
            this.durationTB.ReadOnly = true;
            this.durationTB.Size = new System.Drawing.Size(99, 20);
            this.durationTB.TabIndex = 13;
            this.durationTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // costTB
            // 
            this.costTB.Enabled = false;
            this.costTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTB.Location = new System.Drawing.Point(146, 585);
            this.costTB.Name = "costTB";
            this.costTB.ReadOnly = true;
            this.costTB.Size = new System.Drawing.Size(99, 20);
            this.costTB.TabIndex = 14;
            this.costTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "BRAND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "COLOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "TIME IN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "TIME OUT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "DURATION";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "TOTAL AMOUNT";
            // 
            // updateBut
            // 
            this.updateBut.BackColor = System.Drawing.Color.Tomato;
            this.updateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBut.Location = new System.Drawing.Point(146, 480);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(99, 33);
            this.updateBut.TabIndex = 22;
            this.updateBut.Text = "VEHICLE OUT";
            this.updateBut.UseVisualStyleBackColor = false;
            this.updateBut.Click += new System.EventHandler(this.updateBut_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 516);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "Note: Please select the vehicle first from the table.";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(329, 138);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(186, 42);
            this.timeLabel.TabIndex = 24;
            this.timeLabel.Text = "hh:mm:ss";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(644, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "OCCUPIED";
            // 
            // occupiedLabel
            // 
            this.occupiedLabel.AutoSize = true;
            this.occupiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupiedLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.occupiedLabel.Location = new System.Drawing.Point(624, 80);
            this.occupiedLabel.Name = "occupiedLabel";
            this.occupiedLabel.Size = new System.Drawing.Size(174, 91);
            this.occupiedLabel.TabIndex = 26;
            this.occupiedLabel.Text = "000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(840, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "AVAILABLE";
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.availableLabel.Location = new System.Drawing.Point(817, 80);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(174, 91);
            this.availableLabel.TabIndex = 28;
            this.availableLabel.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // attendantLabel
            // 
            this.attendantLabel.AutoSize = true;
            this.attendantLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendantLabel.Location = new System.Drawing.Point(115, 189);
            this.attendantLabel.Name = "attendantLabel";
            this.attendantLabel.Size = new System.Drawing.Size(49, 16);
            this.attendantLabel.TabIndex = 30;
            this.attendantLabel.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Attendant:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(261, 644);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 12);
            this.label12.TabIndex = 32;
            this.label12.Text = "Note: Please select the vehicle first from the table.";
            // 
            // Form2
            // 
            this.AcceptButton = this.vehicleinTB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1061, 665);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.attendantLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.occupiedLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.updateBut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.durationTB);
            this.Controls.Add(this.timeoutTB);
            this.Controls.Add(this.timeinTB);
            this.Controls.Add(this.colorTB);
            this.Controls.Add(this.brandTB);
            this.Controls.Add(this.licenseTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.salesTB);
            this.Controls.Add(this.logoutTB);
            this.Controls.Add(this.deleteTB);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.vehicleinTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Parking Lot Management System Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vehicleinTB;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button deleteTB;
        private System.Windows.Forms.Button logoutTB;
        private System.Windows.Forms.Button salesTB;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox licenseTB;
        private System.Windows.Forms.TextBox brandTB;
        private System.Windows.Forms.TextBox colorTB;
        private System.Windows.Forms.DateTimePicker timeinTB;
        private System.Windows.Forms.DateTimePicker timeoutTB;
        private System.Windows.Forms.TextBox durationTB;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label occupiedLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeinCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeoutCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCol;
        private System.Windows.Forms.Label attendantLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}