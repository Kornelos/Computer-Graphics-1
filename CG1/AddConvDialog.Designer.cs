namespace CG1
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
            this.autoDivisorRadioButton = new System.Windows.Forms.RadioButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 12);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(117, 551);
            this.rowsTextBox.MaxLength = 1;
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(51, 26);
            this.rowsTextBox.TabIndex = 3;
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Location = new System.Drawing.Point(269, 551);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(51, 26);
            this.columnsTextBox.TabIndex = 4;
            // 
            // generateKernel
            // 
            this.generateKernel.Location = new System.Drawing.Point(344, 540);
            this.generateKernel.Name = "generateKernel";
            this.generateKernel.Size = new System.Drawing.Size(149, 49);
            this.generateKernel.TabIndex = 5;
            this.generateKernel.Text = "Create grid";
            this.generateKernel.UseVisualStyleBackColor = true;
            this.generateKernel.Click += new System.EventHandler(this.generateKernel_Click);
            // 
            // divisorTextBox
            // 
            this.divisorTextBox.Location = new System.Drawing.Point(163, 620);
            this.divisorTextBox.Name = "divisorTextBox";
            this.divisorTextBox.Size = new System.Drawing.Size(100, 26);
            this.divisorTextBox.TabIndex = 6;
            // 
            // saveKernelButton
            // 
            this.saveKernelButton.Location = new System.Drawing.Point(344, 683);
            this.saveKernelButton.Name = "saveKernelButton";
            this.saveKernelButton.Size = new System.Drawing.Size(149, 53);
            this.saveKernelButton.TabIndex = 7;
            this.saveKernelButton.Text = "Save";
            this.saveKernelButton.UseVisualStyleBackColor = true;
            this.saveKernelButton.Click += new System.EventHandler(this.saveKernelButton_Click);
            // 
            // autoDivisorRadioButton
            // 
            this.autoDivisorRadioButton.AutoSize = true;
            this.autoDivisorRadioButton.Checked = true;
            this.autoDivisorRadioButton.Location = new System.Drawing.Point(306, 624);
            this.autoDivisorRadioButton.Name = "autoDivisorRadioButton";
            this.autoDivisorRadioButton.Size = new System.Drawing.Size(154, 24);
            this.autoDivisorRadioButton.TabIndex = 8;
            this.autoDivisorRadioButton.TabStop = true;
            this.autoDivisorRadioButton.Text = "Automatic divisor";
            this.autoDivisorRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(163, 696);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Columns:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Divisor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 699);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kernel name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Provide odd kernel size from range [1,9] ";
            // 
            // AddConvDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 769);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.autoDivisorRadioButton);
            this.Controls.Add(this.saveKernelButton);
            this.Controls.Add(this.divisorTextBox);
            this.Controls.Add(this.generateKernel);
            this.Controls.Add(this.columnsTextBox);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(566, 825);
            this.MinimumSize = new System.Drawing.Size(566, 825);
            this.Name = "AddConvDialog";
            this.Text = "Form2";
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
        private System.Windows.Forms.RadioButton autoDivisorRadioButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}