
namespace PayrollCh03WindowsForms
{
    partial class FormPayrollChapter03
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
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(153, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(585, 39);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Chapter 03 Windows Forms Payroll Application";
            // 
            // labelFirstName
            // 
            this.labelFirstName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(126, 85);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(175, 28);
            this.labelFirstName.TabIndex = 9;
            this.labelFirstName.Text = "First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastName
            // 
            this.labelLastName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(126, 140);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(175, 28);
            this.labelLastName.TabIndex = 10;
            this.labelLastName.Text = "Last  Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoursWorked.Location = new System.Drawing.Point(126, 194);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(175, 28);
            this.labelHoursWorked.TabIndex = 11;
            this.labelHoursWorked.Text = "Hours Worked:";
            this.labelHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyRate.Location = new System.Drawing.Point(126, 252);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(175, 28);
            this.labelHourlyRate.TabIndex = 12;
            this.labelHourlyRate.Text = "Hourly Rate:";
            this.labelHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGrossPay
            // 
            this.labelGrossPay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrossPay.Location = new System.Drawing.Point(126, 311);
            this.labelGrossPay.Name = "labelGrossPay";
            this.labelGrossPay.Size = new System.Drawing.Size(175, 28);
            this.labelGrossPay.TabIndex = 13;
            this.labelGrossPay.Text = "Gross Pay:";
            this.labelGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(328, 81);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(214, 32);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(328, 136);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(214, 32);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoursWorked.Location = new System.Drawing.Point(328, 190);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(214, 32);
            this.textBoxHoursWorked.TabIndex = 2;
            this.textBoxHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHourlyRate.Location = new System.Drawing.Point(328, 248);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(214, 32);
            this.textBoxHourlyRate.TabIndex = 3;
            this.textBoxHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGrossPay
            // 
            this.textBoxGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxGrossPay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrossPay.Location = new System.Drawing.Point(328, 307);
            this.textBoxGrossPay.Name = "textBoxGrossPay";
            this.textBoxGrossPay.ReadOnly = true;
            this.textBoxGrossPay.Size = new System.Drawing.Size(214, 32);
            this.textBoxGrossPay.TabIndex = 7;
            this.textBoxGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(141, 382);
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
            this.buttonClear.Location = new System.Drawing.Point(304, 382);
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
            this.buttonExit.Location = new System.Drawing.Point(460, 382);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 45);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormPayrollChapter03
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(768, 450);
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
            this.Name = "FormPayrollChapter03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 03 Windows Forms Payroll Application";
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
    }
}

