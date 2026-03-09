namespace Performance_Testing
{
    partial class frmPerformanceTesting
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numArrayNumber = new NumericUpDown();
            btnGenerate = new Button();
            btnSort = new Button();
            lblGenerateTime = new Label();
            lblSortTime = new Label();
            ((System.ComponentModel.ISupportInitialize)numArrayNumber).BeginInit();
            SuspendLayout();
            // 
            // numArrayNumber
            // 
            numArrayNumber.Location = new Point(71, 120);
            numArrayNumber.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numArrayNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numArrayNumber.Name = "numArrayNumber";
            numArrayNumber.Size = new Size(300, 47);
            numArrayNumber.TabIndex = 0;
            numArrayNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(71, 233);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(188, 58);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(71, 336);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(188, 58);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += this.btnSort_Click;
            // 
            // lblGenerateTime
            // 
            lblGenerateTime.AutoSize = true;
            lblGenerateTime.Location = new Point(308, 242);
            lblGenerateTime.Name = "lblGenerateTime";
            lblGenerateTime.Size = new Size(212, 41);
            lblGenerateTime.TabIndex = 3;
            lblGenerateTime.Text = "Generate Time";
            // 
            // lblSortTime
            // 
            lblSortTime.AutoSize = true;
            lblSortTime.Location = new Point(308, 336);
            lblSortTime.Name = "lblSortTime";
            lblSortTime.Size = new Size(145, 41);
            lblSortTime.TabIndex = 4;
            lblSortTime.Text = "Sort Time";
            // 
            // frmPerformanceTesting
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 526);
            Controls.Add(lblSortTime);
            Controls.Add(lblGenerateTime);
            Controls.Add(btnSort);
            Controls.Add(btnGenerate);
            Controls.Add(numArrayNumber);
            Name = "frmPerformanceTesting";
            Text = "Performance Testing";
            ((System.ComponentModel.ISupportInitialize)numArrayNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numArrayNumber;
        private Button btnGenerate;
        private Button btnSort;
        private Label lblGenerateTime;
        private Label lblSortTime;
    }
}
