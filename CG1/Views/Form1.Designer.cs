namespace CG1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addConvolutionFilter = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.filterCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDownKMeans = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAvgGreyscale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKMeans)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1693, 974);
            this.splitContainer1.SplitterDistance = 1455;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1449, 968);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxAvgGreyscale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownKMeans);
            this.groupBox1.Controls.Add(this.addConvolutionFilter);
            this.groupBox1.Controls.Add(this.revertButton);
            this.groupBox1.Controls.Add(this.filterCheckedListBox);
            this.groupBox1.Controls.Add(this.applyButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 951);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "settings";
            // 
            // addConvolutionFilter
            // 
            this.addConvolutionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addConvolutionFilter.Location = new System.Drawing.Point(6, 340);
            this.addConvolutionFilter.Name = "addConvolutionFilter";
            this.addConvolutionFilter.Size = new System.Drawing.Size(218, 95);
            this.addConvolutionFilter.TabIndex = 5;
            this.addConvolutionFilter.Text = "Add/Edit Convolution filter";
            this.addConvolutionFilter.UseVisualStyleBackColor = true;
            this.addConvolutionFilter.Click += new System.EventHandler(this.addConvolutionFilter_Click);
            // 
            // revertButton
            // 
            this.revertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revertButton.Location = new System.Drawing.Point(6, 440);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(218, 95);
            this.revertButton.TabIndex = 4;
            this.revertButton.Text = "Revert filters";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // filterCheckedListBox
            // 
            this.filterCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterCheckedListBox.FormattingEnabled = true;
            this.filterCheckedListBox.Location = new System.Drawing.Point(6, 624);
            this.filterCheckedListBox.Name = "filterCheckedListBox";
            this.filterCheckedListBox.Size = new System.Drawing.Size(218, 326);
            this.filterCheckedListBox.TabIndex = 3;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(6, 238);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(218, 95);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply filters";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(6, 137);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(218, 95);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(6, 35);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(218, 95);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load image";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDownKMeans
            // 
            this.numericUpDownKMeans.Location = new System.Drawing.Point(6, 547);
            this.numericUpDownKMeans.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownKMeans.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKMeans.Name = "numericUpDownKMeans";
            this.numericUpDownKMeans.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownKMeans.TabIndex = 6;
            this.numericUpDownKMeans.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKMeans.ValueChanged += new System.EventHandler(this.numericUpDownKMeans_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "K in KMeans";
            // 
            // checkBoxAvgGreyscale
            // 
            this.checkBoxAvgGreyscale.AutoSize = true;
            this.checkBoxAvgGreyscale.Location = new System.Drawing.Point(6, 579);
            this.checkBoxAvgGreyscale.Name = "checkBoxAvgGreyscale";
            this.checkBoxAvgGreyscale.Size = new System.Drawing.Size(150, 24);
            this.checkBoxAvgGreyscale.TabIndex = 8;
            this.checkBoxAvgGreyscale.Text = "Greyscale dither";
            this.checkBoxAvgGreyscale.UseVisualStyleBackColor = true;
            this.checkBoxAvgGreyscale.CheckedChanged += new System.EventHandler(this.checkBoxAvgGreyscale_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 974);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1321, 828);
            this.Name = "Form1";
            this.Text = "Filters";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKMeans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox filterCheckedListBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addConvolutionFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownKMeans;
        private System.Windows.Forms.CheckBox checkBoxAvgGreyscale;
    }
}

