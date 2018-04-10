namespace EmployeeRecords
{
    partial class mainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.fnLabel = new System.Windows.Forms.Label();
            this.lnLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.fnInput = new System.Windows.Forms.TextBox();
            this.lnInput = new System.Windows.Forms.TextBox();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.salaryInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(18, 14);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(498, 74);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Employee Records";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(27, 146);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(109, 20);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Employee ID#";
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(27, 205);
            this.fnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(86, 20);
            this.fnLabel.TabIndex = 2;
            this.fnLabel.Text = "First Name";
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.Location = new System.Drawing.Point(27, 262);
            this.lnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(86, 20);
            this.lnLabel.TabIndex = 3;
            this.lnLabel.Text = "Last Name";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(27, 312);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(83, 20);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Start Date";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(27, 371);
            this.salaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(107, 20);
            this.salaryLabel.TabIndex = 5;
            this.salaryLabel.Text = "Annual Salary";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(220, 142);
            this.idInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(146, 26);
            this.idInput.TabIndex = 6;
            // 
            // fnInput
            // 
            this.fnInput.Location = new System.Drawing.Point(220, 205);
            this.fnInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fnInput.Name = "fnInput";
            this.fnInput.Size = new System.Drawing.Size(292, 26);
            this.fnInput.TabIndex = 7;
            // 
            // lnInput
            // 
            this.lnInput.Location = new System.Drawing.Point(220, 262);
            this.lnInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lnInput.Name = "lnInput";
            this.lnInput.Size = new System.Drawing.Size(292, 26);
            this.lnInput.TabIndex = 8;
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(220, 312);
            this.dateInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(146, 26);
            this.dateInput.TabIndex = 9;
            // 
            // salaryInput
            // 
            this.salaryInput.Location = new System.Drawing.Point(220, 366);
            this.salaryInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salaryInput.Name = "salaryInput";
            this.salaryInput.Size = new System.Drawing.Size(146, 26);
            this.salaryInput.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(32, 443);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 42);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(32, 534);
            this.listButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(141, 42);
            this.listButton.TabIndex = 13;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(180, 443);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(141, 42);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(32, 580);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(482, 190);
            this.outputLabel.TabIndex = 15;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 785);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.salaryInput);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.lnInput);
            this.Controls.Add(this.fnInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.lnLabel);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.Text = "Add/Delete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox fnInput;
        private System.Windows.Forms.TextBox lnInput;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.TextBox salaryInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

