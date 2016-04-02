namespace Algorithm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnSimpleSelectionSort = new System.Windows.Forms.Button();
            this.panel1 = new Algorithm.MyPanel();
            this.btnBinarySelectionSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(39, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(876, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "快速排序";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(120, 43);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.btnBubbleSort.TabIndex = 5;
            this.btnBubbleSort.Text = "冒泡排序";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(201, 43);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(98, 23);
            this.btnInsertionSort.TabIndex = 6;
            this.btnInsertionSort.Text = "直接插入排序";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Location = new System.Drawing.Point(305, 43);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(75, 23);
            this.btnShellSort.TabIndex = 7;
            this.btnShellSort.Text = "希尔排序";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // btnSimpleSelectionSort
            // 
            this.btnSimpleSelectionSort.Location = new System.Drawing.Point(386, 43);
            this.btnSimpleSelectionSort.Name = "btnSimpleSelectionSort";
            this.btnSimpleSelectionSort.Size = new System.Drawing.Size(98, 23);
            this.btnSimpleSelectionSort.TabIndex = 8;
            this.btnSimpleSelectionSort.Text = "简单选择排序";
            this.btnSimpleSelectionSort.UseVisualStyleBackColor = true;
            this.btnSimpleSelectionSort.Click += new System.EventHandler(this.btnSimpleSelectionSort_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(39, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 406);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBinarySelectionSort
            // 
            this.btnBinarySelectionSort.Location = new System.Drawing.Point(490, 43);
            this.btnBinarySelectionSort.Name = "btnBinarySelectionSort";
            this.btnBinarySelectionSort.Size = new System.Drawing.Size(98, 23);
            this.btnBinarySelectionSort.TabIndex = 9;
            this.btnBinarySelectionSort.Text = "二元选择排序";
            this.btnBinarySelectionSort.UseVisualStyleBackColor = true;
            this.btnBinarySelectionSort.Click += new System.EventHandler(this.btnBinarySelectionSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(594, 43);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(75, 23);
            this.btnMergeSort.TabIndex = 10;
            this.btnMergeSort.Text = "归并排序";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 515);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnBinarySelectionSort);
            this.Controls.Add(this.btnSimpleSelectionSort);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "算法演示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private MyPanel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnSimpleSelectionSort;
        private System.Windows.Forms.Button btnBinarySelectionSort;
        private System.Windows.Forms.Button btnMergeSort;
    }
}

