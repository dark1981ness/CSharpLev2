namespace Employees
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
            this.Employee = new System.Windows.Forms.Panel();
            this.employeeGB = new System.Windows.Forms.GroupBox();
            this.cbSalaryType = new System.Windows.Forms.ComboBox();
            this.gbSalary = new System.Windows.Forms.GroupBox();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.tbWageRate = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.lblWageRate = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbPatr = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.lblSalaryType = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPatr = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.Employee.SuspendLayout();
            this.employeeGB.SuspendLayout();
            this.gbSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.employeeGB);
            this.Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Employee.Location = new System.Drawing.Point(0, 0);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(458, 558);
            this.Employee.TabIndex = 0;
            // 
            // employeeGB
            // 
            this.employeeGB.Controls.Add(this.cbSalaryType);
            this.employeeGB.Controls.Add(this.gbSalary);
            this.employeeGB.Controls.Add(this.btnOK);
            this.employeeGB.Controls.Add(this.btnCancel);
            this.employeeGB.Controls.Add(this.numericAge);
            this.employeeGB.Controls.Add(this.tbSalary);
            this.employeeGB.Controls.Add(this.tbPatr);
            this.employeeGB.Controls.Add(this.tbName);
            this.employeeGB.Controls.Add(this.tbSName);
            this.employeeGB.Controls.Add(this.lblSalaryType);
            this.employeeGB.Controls.Add(this.lblSalary);
            this.employeeGB.Controls.Add(this.lblAge);
            this.employeeGB.Controls.Add(this.lblPatr);
            this.employeeGB.Controls.Add(this.lblName);
            this.employeeGB.Controls.Add(this.lblSName);
            this.employeeGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeGB.Location = new System.Drawing.Point(0, 0);
            this.employeeGB.Name = "employeeGB";
            this.employeeGB.Size = new System.Drawing.Size(458, 558);
            this.employeeGB.TabIndex = 0;
            this.employeeGB.TabStop = false;
            this.employeeGB.Text = "Сотрудник";
            // 
            // cbSalaryType
            // 
            this.cbSalaryType.FormattingEnabled = true;
            this.cbSalaryType.Items.AddRange(new object[] {
            "Фиксированная",
            "Почасовая"});
            this.cbSalaryType.Location = new System.Drawing.Point(132, 204);
            this.cbSalaryType.Name = "cbSalaryType";
            this.cbSalaryType.Size = new System.Drawing.Size(230, 28);
            this.cbSalaryType.TabIndex = 5;
            this.cbSalaryType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbSalary
            // 
            this.gbSalary.Controls.Add(this.tbDays);
            this.gbSalary.Controls.Add(this.tbWageRate);
            this.gbSalary.Controls.Add(this.btnCalc);
            this.gbSalary.Controls.Add(this.lblHours);
            this.gbSalary.Controls.Add(this.lblDays);
            this.gbSalary.Controls.Add(this.tbHours);
            this.gbSalary.Controls.Add(this.lblWageRate);
            this.gbSalary.Location = new System.Drawing.Point(12, 246);
            this.gbSalary.Name = "gbSalary";
            this.gbSalary.Size = new System.Drawing.Size(430, 196);
            this.gbSalary.TabIndex = 11;
            this.gbSalary.TabStop = false;
            this.gbSalary.Text = "Зарплата";
            this.gbSalary.Visible = false;
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(130, 76);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(230, 26);
            this.tbDays.TabIndex = 7;
            // 
            // tbWageRate
            // 
            this.tbWageRate.Location = new System.Drawing.Point(130, 115);
            this.tbWageRate.Name = "tbWageRate";
            this.tbWageRate.Size = new System.Drawing.Size(230, 26);
            this.tbWageRate.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Location = new System.Drawing.Point(159, 147);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(116, 37);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHours.Location = new System.Drawing.Point(10, 41);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(49, 20);
            this.lblHours.TabIndex = 7;
            this.lblHours.Text = "Часы";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDays.Location = new System.Drawing.Point(10, 79);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(39, 20);
            this.lblDays.TabIndex = 6;
            this.lblDays.Text = "Дни";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(130, 38);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(230, 26);
            this.tbHours.TabIndex = 6;
            // 
            // lblWageRate
            // 
            this.lblWageRate.AutoSize = true;
            this.lblWageRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWageRate.Location = new System.Drawing.Point(10, 118);
            this.lblWageRate.Name = "lblWageRate";
            this.lblWageRate.Size = new System.Drawing.Size(64, 20);
            this.lblWageRate.TabIndex = 5;
            this.lblWageRate.Text = "Ставка";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(151, 512);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(255, 512);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(132, 159);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(59, 26);
            this.numericAge.TabIndex = 4;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(132, 469);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(230, 26);
            this.tbSalary.TabIndex = 10;
            this.tbSalary.TextChanged += new System.EventHandler(this.tbSalary_TextChanged);
            this.tbSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalary_KeyPress);
            // 
            // tbPatr
            // 
            this.tbPatr.Location = new System.Drawing.Point(132, 115);
            this.tbPatr.Name = "tbPatr";
            this.tbPatr.Size = new System.Drawing.Size(230, 26);
            this.tbPatr.TabIndex = 3;
            this.tbPatr.TextChanged += new System.EventHandler(this.tbPatr_TextChanged);
            this.tbPatr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPatr_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(132, 76);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(230, 26);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(132, 38);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(230, 26);
            this.tbSName.TabIndex = 1;
            this.tbSName.TextChanged += new System.EventHandler(this.tbSName_TextChanged);
            this.tbSName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSName_KeyPress);
            // 
            // lblSalaryType
            // 
            this.lblSalaryType.AutoSize = true;
            this.lblSalaryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalaryType.Location = new System.Drawing.Point(12, 207);
            this.lblSalaryType.Name = "lblSalaryType";
            this.lblSalaryType.Size = new System.Drawing.Size(114, 20);
            this.lblSalaryType.TabIndex = 0;
            this.lblSalaryType.Text = "Тип зарплаты";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalary.Location = new System.Drawing.Point(12, 472);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(84, 20);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Зарплата";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAge.Location = new System.Drawing.Point(12, 161);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(72, 20);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Возраст";
            // 
            // lblPatr
            // 
            this.lblPatr.AutoSize = true;
            this.lblPatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatr.Location = new System.Drawing.Point(12, 118);
            this.lblPatr.Name = "lblPatr";
            this.lblPatr.Size = new System.Drawing.Size(83, 20);
            this.lblPatr.TabIndex = 0;
            this.lblPatr.Text = "Отчество";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(12, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSName.Location = new System.Drawing.Point(12, 41);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(81, 20);
            this.lblSName.TabIndex = 0;
            this.lblSName.Text = "Фамилия";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 558);
            this.Controls.Add(this.Employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Employee.ResumeLayout(false);
            this.employeeGB.ResumeLayout(false);
            this.employeeGB.PerformLayout();
            this.gbSalary.ResumeLayout(false);
            this.gbSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Employee;
        private System.Windows.Forms.GroupBox employeeGB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPatr;
        private System.Windows.Forms.TextBox tbPatr;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lblSalaryType;
        private System.Windows.Forms.TextBox tbWageRate;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Label lblWageRate;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.GroupBox gbSalary;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ComboBox cbSalaryType;
    }
}