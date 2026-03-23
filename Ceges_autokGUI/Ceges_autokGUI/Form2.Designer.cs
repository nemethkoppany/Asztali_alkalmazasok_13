namespace Ceges_autokGUI
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            KihajtasRadioButton = new RadioButton();
            BehajtasRadioButton = new RadioButton();
            NameComboBox = new ComboBox();
            CarComboBox = new ComboBox();
            DateDateTimePicker = new DateTimePicker();
            TimeDateTimePicker = new DateTimePicker();
            MilageNumericUpDown = new NumericUpDown();
            felvetelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MilageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 0;
            label1.Text = "Új bérlés felvétele";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Név: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Autó:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Dátum:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 191);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Időpont: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 235);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Km Óra állás:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(53, 361);
            label7.Name = "label7";
            label7.Size = new Size(303, 15);
            label7.TabIndex = 6;
            label7.Text = "Kötelező kiválasztani a \"Kihajtás\" vagy \"behajtás\" opciót!";
            // 
            // KihajtasRadioButton
            // 
            KihajtasRadioButton.AutoSize = true;
            KihajtasRadioButton.Location = new Point(102, 313);
            KihajtasRadioButton.Name = "KihajtasRadioButton";
            KihajtasRadioButton.Size = new Size(66, 19);
            KihajtasRadioButton.TabIndex = 7;
            KihajtasRadioButton.TabStop = true;
            KihajtasRadioButton.Text = "Kihajtás";
            KihajtasRadioButton.UseVisualStyleBackColor = true;
            // 
            // BehajtasRadioButton
            // 
            BehajtasRadioButton.AutoSize = true;
            BehajtasRadioButton.Location = new Point(234, 313);
            BehajtasRadioButton.Name = "BehajtasRadioButton";
            BehajtasRadioButton.Size = new Size(69, 19);
            BehajtasRadioButton.TabIndex = 8;
            BehajtasRadioButton.TabStop = true;
            BehajtasRadioButton.Text = "Behajtás";
            BehajtasRadioButton.UseVisualStyleBackColor = true;
            // 
            // NameComboBox
            // 
            NameComboBox.FormattingEnabled = true;
            NameComboBox.Location = new Point(156, 65);
            NameComboBox.Name = "NameComboBox";
            NameComboBox.Size = new Size(200, 23);
            NameComboBox.TabIndex = 9;
            // 
            // CarComboBox
            // 
            CarComboBox.FormattingEnabled = true;
            CarComboBox.Location = new Point(156, 102);
            CarComboBox.Name = "CarComboBox";
            CarComboBox.Size = new Size(200, 23);
            CarComboBox.TabIndex = 10;
            // 
            // DateDateTimePicker
            // 
            DateDateTimePicker.Format = DateTimePickerFormat.Short;
            DateDateTimePicker.Location = new Point(156, 147);
            DateDateTimePicker.Name = "DateDateTimePicker";
            DateDateTimePicker.Size = new Size(200, 23);
            DateDateTimePicker.TabIndex = 11;
            DateDateTimePicker.Value = new DateTime(2026, 3, 23, 0, 0, 0, 0);
            // 
            // TimeDateTimePicker
            // 
            TimeDateTimePicker.Format = DateTimePickerFormat.Time;
            TimeDateTimePicker.Location = new Point(156, 185);
            TimeDateTimePicker.Name = "TimeDateTimePicker";
            TimeDateTimePicker.Size = new Size(200, 23);
            TimeDateTimePicker.TabIndex = 12;
            // 
            // MilageNumericUpDown
            // 
            MilageNumericUpDown.Location = new Point(156, 227);
            MilageNumericUpDown.Name = "MilageNumericUpDown";
            MilageNumericUpDown.Size = new Size(120, 23);
            MilageNumericUpDown.TabIndex = 13;
            // 
            // felvetelButton
            // 
            felvetelButton.Location = new Point(156, 397);
            felvetelButton.Name = "felvetelButton";
            felvetelButton.Size = new Size(75, 23);
            felvetelButton.TabIndex = 14;
            felvetelButton.Text = "Felvétel";
            felvetelButton.UseVisualStyleBackColor = true;
            felvetelButton.Click += felvetelButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 432);
            Controls.Add(felvetelButton);
            Controls.Add(MilageNumericUpDown);
            Controls.Add(TimeDateTimePicker);
            Controls.Add(DateDateTimePicker);
            Controls.Add(CarComboBox);
            Controls.Add(NameComboBox);
            Controls.Add(BehajtasRadioButton);
            Controls.Add(KihajtasRadioButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)MilageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton KihajtasRadioButton;
        private RadioButton BehajtasRadioButton;
        private ComboBox NameComboBox;
        private ComboBox CarComboBox;
        private DateTimePicker DateDateTimePicker;
        private DateTimePicker TimeDateTimePicker;
        private NumericUpDown MilageNumericUpDown;
        private Button felvetelButton;
    }
}