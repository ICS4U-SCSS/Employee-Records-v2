namespace CharacterRecords
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.classInput = new System.Windows.Forms.TextBox();
            this.healthInput = new System.Windows.Forms.TextBox();
            this.levelInput = new System.Windows.Forms.TextBox();
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
            this.titleLabel.Location = new System.Drawing.Point(74, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(199, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Characters";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(56, 95);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(56, 132);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(32, 13);
            this.classLabel.TabIndex = 3;
            this.classLabel.Text = "Class";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(56, 208);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(62, 13);
            this.healthLabel.TabIndex = 4;
            this.healthLabel.Text = "Health (HP)";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(56, 170);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(63, 13);
            this.levelLabel.TabIndex = 5;
            this.levelLabel.Text = "Level (1-10)";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(185, 91);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(98, 20);
            this.nameInput.TabIndex = 7;
            // 
            // classInput
            // 
            this.classInput.Location = new System.Drawing.Point(185, 128);
            this.classInput.Name = "classInput";
            this.classInput.Size = new System.Drawing.Size(98, 20);
            this.classInput.TabIndex = 8;
            // 
            // healthInput
            // 
            this.healthInput.Location = new System.Drawing.Point(185, 205);
            this.healthInput.Name = "healthInput";
            this.healthInput.Size = new System.Drawing.Size(98, 20);
            this.healthInput.TabIndex = 10;
            // 
            // levelInput
            // 
            this.levelInput.Location = new System.Drawing.Point(185, 166);
            this.levelInput.Name = "levelInput";
            this.levelInput.Size = new System.Drawing.Size(98, 20);
            this.levelInput.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(185, 268);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 28);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(21, 347);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(94, 28);
            this.listButton.TabIndex = 13;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(249, 346);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 28);
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
            this.Controls.Add(this.levelInput);
            this.Controls.Add(this.healthInput);
            this.Controls.Add(this.classInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainForm";
            this.Text = "Add/Delete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox classInput;
        private System.Windows.Forms.TextBox healthInput;
        private System.Windows.Forms.TextBox levelInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

