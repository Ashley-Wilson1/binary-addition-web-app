namespace WcfClientBinaryCalc
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
            Add_btn = new Button();
            BinaryInput1 = new TextBox();
            BinaryInput2 = new TextBox();
            label1 = new Label();
            OutputLabel = new Label();
            Sub_btn = new Button();
            SuspendLayout();
            // 
            // Add_btn
            // 
            Add_btn.BackColor = SystemColors.ControlDark;
            Add_btn.Location = new Point(57, 136);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(91, 34);
            Add_btn.TabIndex = 0;
            Add_btn.Text = "ADD";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // BinaryInput1
            // 
            BinaryInput1.Location = new Point(57, 49);
            BinaryInput1.Name = "BinaryInput1";
            BinaryInput1.PlaceholderText = "enter a binary number";
            BinaryInput1.Size = new Size(200, 23);
            BinaryInput1.TabIndex = 1;
            // 
            // BinaryInput2
            // 
            BinaryInput2.Location = new Point(57, 92);
            BinaryInput2.Name = "BinaryInput2";
            BinaryInput2.PlaceholderText = "enter another binary button";
            BinaryInput2.Size = new Size(200, 23);
            BinaryInput2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(120, 173);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 3;
            label1.Text = "Output:";
            // 
            // OutputLabel
            // 
            OutputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OutputLabel.ForeColor = SystemColors.ButtonFace;
            OutputLabel.Location = new Point(12, 206);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(289, 21);
            OutputLabel.TabIndex = 4;
            OutputLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Sub_btn
            // 
            Sub_btn.BackColor = SystemColors.ControlDark;
            Sub_btn.Location = new Point(166, 136);
            Sub_btn.Name = "Sub_btn";
            Sub_btn.Size = new Size(91, 34);
            Sub_btn.TabIndex = 5;
            Sub_btn.Text = "SUB";
            Sub_btn.UseVisualStyleBackColor = false;
            Sub_btn.Click += Sub_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(313, 275);
            Controls.Add(Sub_btn);
            Controls.Add(OutputLabel);
            Controls.Add(label1);
            Controls.Add(BinaryInput2);
            Controls.Add(BinaryInput1);
            Controls.Add(Add_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add_btn;
        private TextBox BinaryInput1;
        private TextBox BinaryInput2;
        private Label label1;
        private Label OutputLabel;
        private Button Sub_btn;
    }
}
