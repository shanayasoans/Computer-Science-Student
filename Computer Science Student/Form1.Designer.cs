﻿namespace Computer_Science_Student
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
            this.exitButton = new System.Windows.Forms.Button();
            this.getHoursButton = new System.Windows.Forms.Button();
            this.studentDataGroupBox = new System.Windows.Forms.GroupBox();
            this.requiredHoursLabel = new System.Windows.Forms.Label();
            this.softwareEngineeringRadioButton = new System.Windows.Forms.RadioButton();
            this.infoSystemsRadioButton = new System.Windows.Forms.RadioButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.outputRequiredHoursLabel = new System.Windows.Forms.Label();
            this.inputAcademicTrackLabel = new System.Windows.Forms.Label();
            this.inputIDlLabel = new System.Windows.Forms.Label();
            this.inputNameLabel = new System.Windows.Forms.Label();
            this.studentDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(240, 312);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 72);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getHoursButton
            // 
            this.getHoursButton.Location = new System.Drawing.Point(104, 312);
            this.getHoursButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getHoursButton.Name = "getHoursButton";
            this.getHoursButton.Size = new System.Drawing.Size(128, 72);
            this.getHoursButton.TabIndex = 9;
            this.getHoursButton.Text = "Get Required Hours";
            this.getHoursButton.UseVisualStyleBackColor = true;
            this.getHoursButton.Click += new System.EventHandler(this.getHoursButton_Click);
            // 
            // studentDataGroupBox
            // 
            this.studentDataGroupBox.Controls.Add(this.requiredHoursLabel);
            this.studentDataGroupBox.Controls.Add(this.softwareEngineeringRadioButton);
            this.studentDataGroupBox.Controls.Add(this.infoSystemsRadioButton);
            this.studentDataGroupBox.Controls.Add(this.idTextBox);
            this.studentDataGroupBox.Controls.Add(this.nameTextBox);
            this.studentDataGroupBox.Controls.Add(this.outputRequiredHoursLabel);
            this.studentDataGroupBox.Controls.Add(this.inputAcademicTrackLabel);
            this.studentDataGroupBox.Controls.Add(this.inputIDlLabel);
            this.studentDataGroupBox.Controls.Add(this.inputNameLabel);
            this.studentDataGroupBox.Location = new System.Drawing.Point(51, 18);
            this.studentDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentDataGroupBox.Name = "studentDataGroupBox";
            this.studentDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentDataGroupBox.Size = new System.Drawing.Size(369, 285);
            this.studentDataGroupBox.TabIndex = 8;
            this.studentDataGroupBox.TabStop = false;
            this.studentDataGroupBox.Text = "Student Data";
            // 
            // requiredHoursLabel
            // 
            this.requiredHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requiredHoursLabel.Location = new System.Drawing.Point(164, 217);
            this.requiredHoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredHoursLabel.Name = "requiredHoursLabel";
            this.requiredHoursLabel.Size = new System.Drawing.Size(182, 34);
            this.requiredHoursLabel.TabIndex = 9;
            this.requiredHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // softwareEngineeringRadioButton
            // 
            this.softwareEngineeringRadioButton.AutoSize = true;
            this.softwareEngineeringRadioButton.Location = new System.Drawing.Point(168, 162);
            this.softwareEngineeringRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.softwareEngineeringRadioButton.Name = "softwareEngineeringRadioButton";
            this.softwareEngineeringRadioButton.Size = new System.Drawing.Size(187, 24);
            this.softwareEngineeringRadioButton.TabIndex = 8;
            this.softwareEngineeringRadioButton.TabStop = true;
            this.softwareEngineeringRadioButton.Text = "Software Engineering";
            this.softwareEngineeringRadioButton.UseVisualStyleBackColor = true;
            // 
            // infoSystemsRadioButton
            // 
            this.infoSystemsRadioButton.AutoSize = true;
            this.infoSystemsRadioButton.Location = new System.Drawing.Point(168, 126);
            this.infoSystemsRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoSystemsRadioButton.Name = "infoSystemsRadioButton";
            this.infoSystemsRadioButton.Size = new System.Drawing.Size(180, 24);
            this.infoSystemsRadioButton.TabIndex = 7;
            this.infoSystemsRadioButton.TabStop = true;
            this.infoSystemsRadioButton.Text = "Information Systems";
            this.infoSystemsRadioButton.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(168, 74);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(176, 26);
            this.idTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(168, 34);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // outputRequiredHoursLabel
            // 
            this.outputRequiredHoursLabel.AutoSize = true;
            this.outputRequiredHoursLabel.Location = new System.Drawing.Point(22, 223);
            this.outputRequiredHoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputRequiredHoursLabel.Name = "outputRequiredHoursLabel";
            this.outputRequiredHoursLabel.Size = new System.Drawing.Size(125, 20);
            this.outputRequiredHoursLabel.TabIndex = 3;
            this.outputRequiredHoursLabel.Text = "Required Hours:";
            // 
            // inputAcademicTrackLabel
            // 
            this.inputAcademicTrackLabel.AutoSize = true;
            this.inputAcademicTrackLabel.Location = new System.Drawing.Point(16, 148);
            this.inputAcademicTrackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputAcademicTrackLabel.Name = "inputAcademicTrackLabel";
            this.inputAcademicTrackLabel.Size = new System.Drawing.Size(126, 20);
            this.inputAcademicTrackLabel.TabIndex = 2;
            this.inputAcademicTrackLabel.Text = "Academic Track:";
            // 
            // inputIDlLabel
            // 
            this.inputIDlLabel.AutoSize = true;
            this.inputIDlLabel.Location = new System.Drawing.Point(57, 78);
            this.inputIDlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputIDlLabel.Name = "inputIDlLabel";
            this.inputIDlLabel.Size = new System.Drawing.Size(90, 20);
            this.inputIDlLabel.TabIndex = 1;
            this.inputIDlLabel.Text = "ID Number:";
            // 
            // inputNameLabel
            // 
            this.inputNameLabel.AutoSize = true;
            this.inputNameLabel.Location = new System.Drawing.Point(92, 38);
            this.inputNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputNameLabel.Name = "inputNameLabel";
            this.inputNameLabel.Size = new System.Drawing.Size(55, 20);
            this.inputNameLabel.TabIndex = 0;
            this.inputNameLabel.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 403);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getHoursButton);
            this.Controls.Add(this.studentDataGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Computer Science Student";
            this.studentDataGroupBox.ResumeLayout(false);
            this.studentDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getHoursButton;
        private System.Windows.Forms.GroupBox studentDataGroupBox;
        private System.Windows.Forms.Label requiredHoursLabel;
        private System.Windows.Forms.RadioButton softwareEngineeringRadioButton;
        private System.Windows.Forms.RadioButton infoSystemsRadioButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label outputRequiredHoursLabel;
        private System.Windows.Forms.Label inputAcademicTrackLabel;
        private System.Windows.Forms.Label inputIDlLabel;
        private System.Windows.Forms.Label inputNameLabel;
    }
}

