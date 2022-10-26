namespace Exec_Fee
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.womanRadioButton = new System.Windows.Forms.RadioButton();
            this.manRadioButton = new System.Windows.Forms.RadioButton();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.womanRadioButton);
            this.groupBox1.Controls.Add(this.manRadioButton);
            this.groupBox1.Controls.Add(this.calcButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Location = new System.Drawing.Point(33, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客戶資訊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "性別:";
            // 
            // womanRadioButton
            // 
            this.womanRadioButton.AutoSize = true;
            this.womanRadioButton.Location = new System.Drawing.Point(280, 32);
            this.womanRadioButton.Name = "womanRadioButton";
            this.womanRadioButton.Size = new System.Drawing.Size(37, 19);
            this.womanRadioButton.TabIndex = 4;
            this.womanRadioButton.TabStop = true;
            this.womanRadioButton.Text = "女";
            this.womanRadioButton.UseVisualStyleBackColor = true;
            // 
            // manRadioButton
            // 
            this.manRadioButton.AutoSize = true;
            this.manRadioButton.Location = new System.Drawing.Point(237, 32);
            this.manRadioButton.Name = "manRadioButton";
            this.manRadioButton.Size = new System.Drawing.Size(37, 19);
            this.manRadioButton.TabIndex = 3;
            this.manRadioButton.TabStop = true;
            this.manRadioButton.Text = "男";
            this.manRadioButton.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(63, 71);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "計算";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "年齡:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(54, 31);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 23);
            this.ageTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultLabel);
            this.groupBox2.Location = new System.Drawing.Point(33, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "計算結果";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(28, 33);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(68, 15);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "resultLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button calcButton;
        private Label label1;
        private TextBox ageTextBox;
        private GroupBox groupBox2;
        private RadioButton womanRadioButton;
        private RadioButton manRadioButton;
        private Label label2;
        private Label resultLabel;
    }
}