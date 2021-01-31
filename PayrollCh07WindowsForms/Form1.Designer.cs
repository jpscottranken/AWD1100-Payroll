
namespace PayrollCh03WindowsForms
{
    partial class FormPayrollChapter07
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.labelGrossPay = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxGrossPay = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxTotalNumberOfEmployees = new System.Windows.Forms.TextBox();
            this.labelTotalNumberOfEmployees = new System.Windows.Forms.Label();
            this.textBoxTotalGrossPay = new System.Windows.Forms.TextBox();
            this.labelTotalGrossPay = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(153, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(585, 39);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Chapter 07 Windows Forms Payroll Application";
            // 
            // labelFirstName
            // 
            this.labelFirstName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(28, 77);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(175, 28);
            this.labelFirstName.TabIndex = 9;
            this.labelFirstName.Text = "First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastName
            // 
            this.labelLastName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(28, 132);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(175, 28);
            this.labelLastName.TabIndex = 10;
            this.labelLastName.Text = "Last  Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoursWorked.Location = new System.Drawing.Point(28, 186);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(175, 28);
            this.labelHoursWorked.TabIndex = 11;
            this.labelHoursWorked.Text = "Hours Worked:";
            this.labelHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyRate.Location = new System.Drawing.Point(28, 244);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(175, 28);
            this.labelHourlyRate.TabIndex = 12;
            this.labelHourlyRate.Text = "Hourly Rate:";
            this.labelHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGrossPay
            // 
            this.labelGrossPay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrossPay.Location = new System.Drawing.Point(28, 303);
            this.labelGrossPay.Name = "labelGrossPay";
            this.labelGrossPay.Size = new System.Drawing.Size(175, 28);
            this.labelGrossPay.TabIndex = 13;
            this.labelGrossPay.Text = "Gross Pay:";
            this.labelGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(230, 73);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(214, 32);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(230, 128);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(214, 32);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoursWorked.Location = new System.Drawing.Point(230, 182);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(214, 32);
            this.textBoxHoursWorked.TabIndex = 2;
            this.textBoxHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHourlyRate.Location = new System.Drawing.Point(230, 240);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(214, 32);
            this.textBoxHourlyRate.TabIndex = 3;
            this.textBoxHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGrossPay
            // 
            this.textBoxGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxGrossPay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrossPay.Location = new System.Drawing.Point(230, 299);
            this.textBoxGrossPay.Name = "textBoxGrossPay";
            this.textBoxGrossPay.ReadOnly = true;
            this.textBoxGrossPay.Size = new System.Drawing.Size(214, 32);
            this.textBoxGrossPay.TabIndex = 7;
            this.textBoxGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(164, 381);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(125, 45);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(327, 381);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 45);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(646, 381);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 45);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxTotalNumberOfEmployees
            // 
            this.textBoxTotalNumberOfEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxTotalNumberOfEmployees.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalNumberOfEmployees.Location = new System.Drawing.Point(670, 182);
            this.textBoxTotalNumberOfEmployees.Name = "textBoxTotalNumberOfEmployees";
            this.textBoxTotalNumberOfEmployees.ReadOnly = true;
            this.textBoxTotalNumberOfEmployees.Size = new System.Drawing.Size(214, 32);
            this.textBoxTotalNumberOfEmployees.TabIndex = 14;
            this.textBoxTotalNumberOfEmployees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalNumberOfEmployees
            // 
            this.labelTotalNumberOfEmployees.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalNumberOfEmployees.Location = new System.Drawing.Point(478, 183);
            this.labelTotalNumberOfEmployees.Name = "labelTotalNumberOfEmployees";
            this.labelTotalNumberOfEmployees.Size = new System.Drawing.Size(175, 28);
            this.labelTotalNumberOfEmployees.TabIndex = 15;
            this.labelTotalNumberOfEmployees.Text = "Total # Employees:";
            this.labelTotalNumberOfEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTotalGrossPay
            // 
            this.textBoxTotalGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxTotalGrossPay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalGrossPay.Location = new System.Drawing.Point(670, 299);
            this.textBoxTotalGrossPay.Name = "textBoxTotalGrossPay";
            this.textBoxTotalGrossPay.ReadOnly = true;
            this.textBoxTotalGrossPay.Size = new System.Drawing.Size(214, 32);
            this.textBoxTotalGrossPay.TabIndex = 16;
            this.textBoxTotalGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalGrossPay
            // 
            this.labelTotalGrossPay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGrossPay.Location = new System.Drawing.Point(468, 303);
            this.labelTotalGrossPay.Name = "labelTotalGrossPay";
            this.labelTotalGrossPay.Size = new System.Drawing.Size(175, 28);
            this.labelTotalGrossPay.TabIndex = 17;
            this.labelTotalGrossPay.Text = "Total Gross Pay:";
            this.labelTotalGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClearAll.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(483, 381);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(125, 45);
            this.buttonClearAll.TabIndex = 18;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateMenuItem,
            this.clearMenuItem,
            this.clearAllMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculateMenuItem
            // 
            this.calculateMenuItem.Name = "calculateMenuItem";
            this.calculateMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateMenuItem.Text = "Calculate";
            this.calculateMenuItem.Click += new System.EventHandler(this.calculateMenuItem_Click);
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearMenuItem.Text = "Clear";
            this.clearMenuItem.Click += new System.EventHandler(this.clearMenuItem_Click);
            // 
            // clearAllMenuItem
            // 
            this.clearAllMenuItem.Name = "clearAllMenuItem";
            this.clearAllMenuItem.Size = new System.Drawing.Size(60, 20);
            this.clearAllMenuItem.Text = "ClearAll";
            this.clearAllMenuItem.Click += new System.EventHandler(this.clearAllMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // FormPayrollChapter07
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.textBoxTotalGrossPay);
            this.Controls.Add(this.labelTotalGrossPay);
            this.Controls.Add(this.textBoxTotalNumberOfEmployees);
            this.Controls.Add(this.labelTotalNumberOfEmployees);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxGrossPay);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.textBoxHoursWorked);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelGrossPay);
            this.Controls.Add(this.labelHourlyRate);
            this.Controls.Add(this.labelHoursWorked);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPayrollChapter07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 07 Windows Forms Payroll Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.Label labelGrossPay;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxHoursWorked;
        private System.Windows.Forms.TextBox textBoxHourlyRate;
        private System.Windows.Forms.TextBox textBoxGrossPay;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxTotalNumberOfEmployees;
        private System.Windows.Forms.Label labelTotalNumberOfEmployees;
        private System.Windows.Forms.TextBox textBoxTotalGrossPay;
        private System.Windows.Forms.Label labelTotalGrossPay;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    }
}

