namespace SNG
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
            this.genSerialsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateSerialButton = new System.Windows.Forms.Button();
            this.numOfChunksUpDown = new System.Windows.Forms.NumericUpDown();
            this.numOfDigitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.WriteToFileBox = new System.Windows.Forms.GroupBox();
            this.numofLinesUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOfChunksUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDigitsUpDown)).BeginInit();
            this.WriteToFileBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numofLinesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // genSerialsBox
            // 
            this.genSerialsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.genSerialsBox.Location = new System.Drawing.Point(148, 403);
            this.genSerialsBox.Name = "genSerialsBox";
            this.genSerialsBox.ReadOnly = true;
            this.genSerialsBox.Size = new System.Drawing.Size(365, 22);
            this.genSerialsBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(41, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "# of Chunks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(1, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "# of Digits/Chunk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(54, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Generated:";
            // 
            // GenerateSerialButton
            // 
            this.GenerateSerialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.GenerateSerialButton.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateSerialButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.GenerateSerialButton.Location = new System.Drawing.Point(245, 304);
            this.GenerateSerialButton.Name = "GenerateSerialButton";
            this.GenerateSerialButton.Size = new System.Drawing.Size(147, 63);
            this.GenerateSerialButton.TabIndex = 8;
            this.GenerateSerialButton.Text = "Generate";
            this.GenerateSerialButton.UseVisualStyleBackColor = false;
            this.GenerateSerialButton.Click += new System.EventHandler(this.GenerateSerialButton_Click);
            // 
            // numOfChunksUpDown
            // 
            this.numOfChunksUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.numOfChunksUpDown.Location = new System.Drawing.Point(148, 107);
            this.numOfChunksUpDown.Name = "numOfChunksUpDown";
            this.numOfChunksUpDown.Size = new System.Drawing.Size(365, 22);
            this.numOfChunksUpDown.TabIndex = 9;
            // 
            // numOfDigitsUpDown
            // 
            this.numOfDigitsUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.numOfDigitsUpDown.Location = new System.Drawing.Point(148, 180);
            this.numOfDigitsUpDown.Name = "numOfDigitsUpDown";
            this.numOfDigitsUpDown.Size = new System.Drawing.Size(365, 22);
            this.numOfDigitsUpDown.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.checkBox1.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.checkBox1.Location = new System.Drawing.Point(148, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(119, 18);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Write to file";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckChanged);
            // 
            // WriteToFileBox
            // 
            this.WriteToFileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.WriteToFileBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WriteToFileBox.Controls.Add(this.label4);
            this.WriteToFileBox.Controls.Add(this.numofLinesUpDown);
            this.WriteToFileBox.Enabled = false;
            this.WriteToFileBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WriteToFileBox.Location = new System.Drawing.Point(148, 227);
            this.WriteToFileBox.Name = "WriteToFileBox";
            this.WriteToFileBox.Size = new System.Drawing.Size(365, 44);
            this.WriteToFileBox.TabIndex = 12;
            this.WriteToFileBox.TabStop = false;
            // 
            // numofLinesUpDown
            // 
            this.numofLinesUpDown.Location = new System.Drawing.Point(170, 16);
            this.numofLinesUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numofLinesUpDown.Name = "numofLinesUpDown";
            this.numofLinesUpDown.Size = new System.Drawing.Size(120, 22);
            this.numofLinesUpDown.TabIndex = 0;
            this.numofLinesUpDown.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of lines in file?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SNG.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(598, 500);
            this.Controls.Add(this.WriteToFileBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numOfDigitsUpDown);
            this.Controls.Add(this.numOfChunksUpDown);
            this.Controls.Add(this.GenerateSerialButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genSerialsBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Serial Generator V1";
            ((System.ComponentModel.ISupportInitialize)(this.numOfChunksUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDigitsUpDown)).EndInit();
            this.WriteToFileBox.ResumeLayout(false);
            this.WriteToFileBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numofLinesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox genSerialsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateSerialButton;
        private System.Windows.Forms.NumericUpDown numOfChunksUpDown;
        private System.Windows.Forms.NumericUpDown numOfDigitsUpDown;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numofLinesUpDown;
        private System.Windows.Forms.GroupBox WriteToFileBox;
    }
}

