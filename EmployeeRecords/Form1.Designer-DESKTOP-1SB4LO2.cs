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
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(331, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Employee Records";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(18, 95);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(74, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Employee ID#";
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(18, 133);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(57, 13);
            this.fnLabel.TabIndex = 2;
            this.fnLabel.Text = "First Name";
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.Location = new System.Drawing.Point(18, 170);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(58, 13);
            this.lnLabel.TabIndex = 3;
            this.lnLabel.Text = "Last Name";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(18, 203);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(55, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Start Date";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(18, 241);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(72, 13);
            this.salaryLabel.TabIndex = 5;
            this.salaryLabel.Text = "Annual Salary";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(147, 92);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(99, 20);
            this.idInput.TabIndex = 6;
            // 
            // fnInput
            // 
            this.fnInput.Location = new System.Drawing.Point(147, 133);
            this.fnInput.Name = "fnInput";
            this.fnInput.Size = new System.Drawing.Size(196, 20);
            this.fnInput.TabIndex = 7;
            // 
            // lnInput
            // 
            this.lnInput.Location = new System.Drawing.Point(147, 170);
            this.lnInput.Name = "lnInput";
            this.lnInput.Size = new System.Drawing.Size(196, 20);
            this.lnInput.TabIndex = 8;
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(147, 203);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(99, 20);
            this.dateInput.TabIndex = 9;
            // 
            // salaryInput
            // 
            this.salaryInput.Location = new System.Drawing.Point(147, 238);
            this.salaryInput.Name = "salaryInput";
            this.salaryInput.Size = new System.Drawing.Size(99, 20);
            this.salaryInput.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(21, 288);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 27);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(21, 347);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(94, 27);
            this.listButton.TabIndex = 13;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(120, 288);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 27);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(21, 377);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(322, 124);
            this.outputLabel.TabIndex = 15;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 510);
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
            this.Name = "mainForm";
            this.Text = "Add/Delete";
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

