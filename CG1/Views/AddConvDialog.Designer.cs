﻿namespace CG1
{
    partial class AddConvDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.columnsTextBox = new System.Windows.Forms.TextBox();
            this.generateKernel = new System.Windows.Forms.Button();
            this.divisorTextBox = new System.Windows.Forms.TextBox();
            this.saveKernelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.automaticDivisorCheckBox = new System.Windows.Forms.CheckBox();
            this.offsetTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.anchorRowTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.anchorColTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(104, 396);
            this.rowsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rowsTextBox.MaxLength = 1;
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(45, 22);
            this.rowsTextBox.TabIndex = 3;
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Location = new System.Drawing.Point(239, 396);
            this.columnsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(45, 22);
            this.columnsTextBox.TabIndex = 4;
            // 
            // generateKernel
            // 
            this.generateKernel.Location = new System.Drawing.Point(337, 389);
            this.generateKernel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateKernel.Name = "generateKernel";
            this.generateKernel.Size = new System.Drawing.Size(132, 38);
            this.generateKernel.TabIndex = 5;
            this.generateKernel.Text = "Create grid";
            this.generateKernel.UseVisualStyleBackColor = true;
            this.generateKernel.Click += new System.EventHandler(this.generateKernel_Click);
            // 
            // divisorTextBox
            // 
            this.divisorTextBox.Location = new System.Drawing.Point(104, 446);
            this.divisorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.divisorTextBox.Name = "divisorTextBox";
            this.divisorTextBox.Size = new System.Drawing.Size(45, 22);
            this.divisorTextBox.TabIndex = 6;
            // 
            // saveKernelButton
            // 
            this.saveKernelButton.Location = new System.Drawing.Point(337, 531);
            this.saveKernelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveKernelButton.Name = "saveKernelButton";
            this.saveKernelButton.Size = new System.Drawing.Size(132, 34);
            this.saveKernelButton.TabIndex = 7;
            this.saveKernelButton.Text = "Save";
            this.saveKernelButton.UseVisualStyleBackColor = true;
            this.saveKernelButton.Click += new System.EventHandler(this.saveKernelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(202, 543);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(89, 22);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Text = "test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Columns:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Divisor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kernel name (existing for edit)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Provide odd kernel size from range [1,9] ";
            // 
            // automaticDivisorCheckBox
            // 
            this.automaticDivisorCheckBox.AutoSize = true;
            this.automaticDivisorCheckBox.Checked = true;
            this.automaticDivisorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.automaticDivisorCheckBox.Location = new System.Drawing.Point(159, 448);
            this.automaticDivisorCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.automaticDivisorCheckBox.Name = "automaticDivisorCheckBox";
            this.automaticDivisorCheckBox.Size = new System.Drawing.Size(93, 21);
            this.automaticDivisorCheckBox.TabIndex = 15;
            this.automaticDivisorCheckBox.Text = "Automatic";
            this.automaticDivisorCheckBox.UseVisualStyleBackColor = true;
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Location = new System.Drawing.Point(349, 448);
            this.offsetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(64, 22);
            this.offsetTextBox.TabIndex = 16;
            this.offsetTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 451);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Offset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 511);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Row:";
            // 
            // anchorRowTextBox
            // 
            this.anchorRowTextBox.Location = new System.Drawing.Point(104, 507);
            this.anchorRowTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anchorRowTextBox.Name = "anchorRowTextBox";
            this.anchorRowTextBox.Size = new System.Drawing.Size(45, 22);
            this.anchorRowTextBox.TabIndex = 19;
            this.anchorRowTextBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 511);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Column:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 487);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Coordinates of anchor point (0,0 at top left corner)";
            // 
            // anchorColTextBox
            // 
            this.anchorColTextBox.Location = new System.Drawing.Point(239, 508);
            this.anchorColTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anchorColTextBox.Name = "anchorColTextBox";
            this.anchorColTextBox.Size = new System.Drawing.Size(45, 22);
            this.anchorColTextBox.TabIndex = 22;
            this.anchorColTextBox.Text = "0";
            // 
            // AddConvDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 608);
            this.Controls.Add(this.anchorColTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.anchorRowTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.offsetTextBox);
            this.Controls.Add(this.automaticDivisorCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveKernelButton);
            this.Controls.Add(this.divisorTextBox);
            this.Controls.Add(this.generateKernel);
            this.Controls.Add(this.columnsTextBox);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(503, 664);
            this.MinimumSize = new System.Drawing.Size(503, 664);
            this.Name = "AddConvDialog";
            this.Text = "Add or edit filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.TextBox columnsTextBox;
        private System.Windows.Forms.Button generateKernel;
        private System.Windows.Forms.TextBox divisorTextBox;
        private System.Windows.Forms.Button saveKernelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox automaticDivisorCheckBox;
        private System.Windows.Forms.TextBox offsetTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox anchorRowTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox anchorColTextBox;
    }
}