namespace Abstract_Fabric
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            colorBox = new ComboBox();
            shapeBox = new ComboBox();
            label5 = new Label();
            AddingButton = new Button();
            SizeUpDown = new NumericUpDown();
            XUpDown = new NumericUpDown();
            YUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)SizeUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)XUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Shape:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Size:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "X cord:";
            // 
            // colorBox
            // 
            colorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorBox.FormattingEnabled = true;
            colorBox.Location = new Point(12, 32);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(151, 28);
            colorBox.TabIndex = 4;
            // 
            // shapeBox
            // 
            shapeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shapeBox.FormattingEnabled = true;
            shapeBox.Location = new Point(12, 86);
            shapeBox.Name = "shapeBox";
            shapeBox.Size = new Size(151, 28);
            shapeBox.TabIndex = 5;
            shapeBox.SelectedIndexChanged += shapeBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 223);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 8;
            label5.Text = "Y cord:";
            // 
            // AddingButton
            // 
            AddingButton.Location = new Point(12, 279);
            AddingButton.Name = "AddingButton";
            AddingButton.Size = new Size(150, 29);
            AddingButton.TabIndex = 10;
            AddingButton.Text = "Add";
            AddingButton.UseVisualStyleBackColor = true;
            AddingButton.Click += AddingButton_Click;
            // 
            // SizeUpDown
            // 
            SizeUpDown.Location = new Point(12, 140);
            SizeUpDown.Name = "SizeUpDown";
            SizeUpDown.ReadOnly = true;
            SizeUpDown.Size = new Size(150, 27);
            SizeUpDown.TabIndex = 11;
            // 
            // XUpDown
            // 
            XUpDown.Location = new Point(12, 193);
            XUpDown.Name = "XUpDown";
            XUpDown.ReadOnly = true;
            XUpDown.Size = new Size(150, 27);
            XUpDown.TabIndex = 12;
            // 
            // YUpDown
            // 
            YUpDown.Location = new Point(13, 246);
            YUpDown.Name = "YUpDown";
            YUpDown.ReadOnly = true;
            YUpDown.Size = new Size(150, 27);
            YUpDown.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 325);
            Controls.Add(YUpDown);
            Controls.Add(XUpDown);
            Controls.Add(SizeUpDown);
            Controls.Add(AddingButton);
            Controls.Add(label5);
            Controls.Add(shapeBox);
            Controls.Add(colorBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)SizeUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)XUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)YUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox colorBox;
        private ComboBox shapeBox;
        private Label label5;
        private Button AddingButton;
        private NumericUpDown SizeUpDown;
        private NumericUpDown XUpDown;
        private NumericUpDown YUpDown;
    }
}
