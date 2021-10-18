
namespace Employee_and_Production_Worker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewEmpGroup = new System.Windows.Forms.GroupBox();
            this.RateInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ShiftInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EmpListGroup = new System.Windows.Forms.GroupBox();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.EmpDetailsGroup = new System.Windows.Forms.GroupBox();
            this.RateOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ShiftOutput = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberOutput = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NewEmpGroup.SuspendLayout();
            this.EmpListGroup.SuspendLayout();
            this.EmpDetailsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // NewEmpGroup
            // 
            this.NewEmpGroup.Controls.Add(this.RateInput);
            this.NewEmpGroup.Controls.Add(this.label5);
            this.NewEmpGroup.Controls.Add(this.ShiftInput);
            this.NewEmpGroup.Controls.Add(this.label4);
            this.NewEmpGroup.Controls.Add(this.NumberInput);
            this.NewEmpGroup.Controls.Add(this.label3);
            this.NewEmpGroup.Controls.Add(this.NameInput);
            this.NewEmpGroup.Controls.Add(this.label2);
            this.NewEmpGroup.Location = new System.Drawing.Point(76, 71);
            this.NewEmpGroup.Name = "NewEmpGroup";
            this.NewEmpGroup.Size = new System.Drawing.Size(366, 328);
            this.NewEmpGroup.TabIndex = 1;
            this.NewEmpGroup.TabStop = false;
            this.NewEmpGroup.Text = "Enter Employee Data";
            // 
            // RateInput
            // 
            this.RateInput.Location = new System.Drawing.Point(181, 245);
            this.RateInput.Name = "RateInput";
            this.RateInput.Size = new System.Drawing.Size(161, 26);
            this.RateInput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hourly Rate:";
            // 
            // ShiftInput
            // 
            this.ShiftInput.FormattingEnabled = true;
            this.ShiftInput.Items.AddRange(new object[] {
            "1",
            "2"});
            this.ShiftInput.Location = new System.Drawing.Point(181, 191);
            this.ShiftInput.Name = "ShiftInput";
            this.ShiftInput.Size = new System.Drawing.Size(161, 28);
            this.ShiftInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shift Number: ";
            // 
            // NumberInput
            // 
            this.NumberInput.Location = new System.Drawing.Point(181, 134);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.Size = new System.Drawing.Size(161, 26);
            this.NumberInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Number: ";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(181, 79);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(161, 26);
            this.NameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Name: ";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(156, 425);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(197, 36);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add New Employee";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(591, 520);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(197, 36);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EmpListGroup
            // 
            this.EmpListGroup.Controls.Add(this.EmployeeListBox);
            this.EmpListGroup.Location = new System.Drawing.Point(508, 76);
            this.EmpListGroup.Name = "EmpListGroup";
            this.EmpListGroup.Size = new System.Drawing.Size(366, 323);
            this.EmpListGroup.TabIndex = 8;
            this.EmpListGroup.TabStop = false;
            this.EmpListGroup.Text = "Employee Directory";
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.ItemHeight = 20;
            this.EmployeeListBox.Location = new System.Drawing.Point(23, 68);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(313, 224);
            this.EmployeeListBox.TabIndex = 9;
            this.EmployeeListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListBox_SelectedIndexChanged);
            // 
            // EmpDetailsGroup
            // 
            this.EmpDetailsGroup.Controls.Add(this.RateOutput);
            this.EmpDetailsGroup.Controls.Add(this.label10);
            this.EmpDetailsGroup.Controls.Add(this.ShiftOutput);
            this.EmpDetailsGroup.Controls.Add(this.label9);
            this.EmpDetailsGroup.Controls.Add(this.NumberOutput);
            this.EmpDetailsGroup.Controls.Add(this.label8);
            this.EmpDetailsGroup.Controls.Add(this.NameOutput);
            this.EmpDetailsGroup.Controls.Add(this.label6);
            this.EmpDetailsGroup.Location = new System.Drawing.Point(941, 76);
            this.EmpDetailsGroup.Name = "EmpDetailsGroup";
            this.EmpDetailsGroup.Size = new System.Drawing.Size(366, 323);
            this.EmpDetailsGroup.TabIndex = 10;
            this.EmpDetailsGroup.TabStop = false;
            this.EmpDetailsGroup.Text = "Employee Details";
            // 
            // RateOutput
            // 
            this.RateOutput.Location = new System.Drawing.Point(166, 243);
            this.RateOutput.Name = "RateOutput";
            this.RateOutput.Size = new System.Drawing.Size(161, 26);
            this.RateOutput.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Pay: ";
            // 
            // ShiftOutput
            // 
            this.ShiftOutput.Location = new System.Drawing.Point(166, 189);
            this.ShiftOutput.Name = "ShiftOutput";
            this.ShiftOutput.Size = new System.Drawing.Size(161, 26);
            this.ShiftOutput.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Shift Type:";
            // 
            // NumberOutput
            // 
            this.NumberOutput.Location = new System.Drawing.Point(166, 132);
            this.NumberOutput.Name = "NumberOutput";
            this.NumberOutput.Size = new System.Drawing.Size(161, 26);
            this.NumberOutput.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Number:";
            // 
            // NameOutput
            // 
            this.NameOutput.Location = new System.Drawing.Point(158, 76);
            this.NameOutput.Name = "NameOutput";
            this.NameOutput.Size = new System.Drawing.Size(161, 26);
            this.NameOutput.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 869);
            this.Controls.Add(this.EmpDetailsGroup);
            this.Controls.Add(this.EmpListGroup);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NewEmpGroup);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Employee & Production Worker";
            this.NewEmpGroup.ResumeLayout(false);
            this.NewEmpGroup.PerformLayout();
            this.EmpListGroup.ResumeLayout(false);
            this.EmpDetailsGroup.ResumeLayout(false);
            this.EmpDetailsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox NewEmpGroup;
        private System.Windows.Forms.TextBox RateInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ShiftInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox EmpListGroup;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.GroupBox EmpDetailsGroup;
        private System.Windows.Forms.Label NumberOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NameOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RateOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ShiftOutput;
        private System.Windows.Forms.Label label9;
    }
}

