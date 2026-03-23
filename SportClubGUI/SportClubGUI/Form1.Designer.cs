namespace SportClubGUI
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
            listBox1 = new ListBox();
            tagNeveCimke = new Label();
            label2 = new Label();
            tagNeve_Cimke = new Label();
            telefonszamCimke = new Label();
            edzesekSzama_Button = new Button();
            label5 = new Label();
            edzesekSzamaCimke = new Label();
            legutobbiEdzesTipusaButton = new Button();
            label7 = new Label();
            legutobbiEdzesTipusaCimke = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(269, 439);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += MemberNamesListBox_SelectedIndexChanged;
            // 
            // tagNeveCimke
            // 
            tagNeveCimke.AutoSize = true;
            tagNeveCimke.Location = new Point(323, 42);
            tagNeveCimke.Name = "tagNeveCimke";
            tagNeveCimke.Size = new Size(56, 15);
            tagNeveCimke.TabIndex = 1;
            tagNeveCimke.Text = "Tag neve:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 74);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefonszám:";
            // 
            // tagNeve_Cimke
            // 
            tagNeve_Cimke.AutoSize = true;
            tagNeve_Cimke.Location = new Point(474, 41);
            tagNeve_Cimke.Name = "tagNeve_Cimke";
            tagNeve_Cimke.Size = new Size(29, 15);
            tagNeve_Cimke.TabIndex = 3;
            tagNeve_Cimke.Text = "N/A";
            // 
            // telefonszamCimke
            // 
            telefonszamCimke.AutoSize = true;
            telefonszamCimke.Location = new Point(474, 74);
            telefonszamCimke.Name = "telefonszamCimke";
            telefonszamCimke.Size = new Size(29, 15);
            telefonszamCimke.TabIndex = 4;
            telefonszamCimke.Text = "N/A";
            // 
            // edzesekSzama_Button
            // 
            edzesekSzama_Button.Location = new Point(326, 106);
            edzesekSzama_Button.Name = "edzesekSzama_Button";
            edzesekSzama_Button.Size = new Size(174, 23);
            edzesekSzama_Button.TabIndex = 5;
            edzesekSzama_Button.Text = "Edzések száma";
            edzesekSzama_Button.UseVisualStyleBackColor = true;
            edzesekSzama_Button.Click += edzesekSzama_Button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 132);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 6;
            label5.Text = "Edzések száma";
            // 
            // edzesekSzamaCimke
            // 
            edzesekSzamaCimke.AutoSize = true;
            edzesekSzamaCimke.Location = new Point(474, 132);
            edzesekSzamaCimke.Name = "edzesekSzamaCimke";
            edzesekSzamaCimke.Size = new Size(29, 15);
            edzesekSzamaCimke.TabIndex = 7;
            edzesekSzamaCimke.Text = "N/A";
            // 
            // legutobbiEdzesTipusaButton
            // 
            legutobbiEdzesTipusaButton.Location = new Point(326, 181);
            legutobbiEdzesTipusaButton.Name = "legutobbiEdzesTipusaButton";
            legutobbiEdzesTipusaButton.Size = new Size(185, 23);
            legutobbiEdzesTipusaButton.TabIndex = 8;
            legutobbiEdzesTipusaButton.Text = "Legutóbbi edzés típusa";
            legutobbiEdzesTipusaButton.UseVisualStyleBackColor = true;
            legutobbiEdzesTipusaButton.Click += legutobbiEdzesTipusaButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(323, 207);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 9;
            label7.Text = "Legutóbbi edzés típusa:";
            // 
            // legutobbiEdzesTipusaCimke
            // 
            legutobbiEdzesTipusaCimke.AutoSize = true;
            legutobbiEdzesTipusaCimke.Location = new Point(474, 207);
            legutobbiEdzesTipusaCimke.Name = "legutobbiEdzesTipusaCimke";
            legutobbiEdzesTipusaCimke.Size = new Size(29, 15);
            legutobbiEdzesTipusaCimke.TabIndex = 10;
            legutobbiEdzesTipusaCimke.Text = "N/A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(legutobbiEdzesTipusaCimke);
            Controls.Add(label7);
            Controls.Add(legutobbiEdzesTipusaButton);
            Controls.Add(edzesekSzamaCimke);
            Controls.Add(label5);
            Controls.Add(edzesekSzama_Button);
            Controls.Add(telefonszamCimke);
            Controls.Add(tagNeve_Cimke);
            Controls.Add(label2);
            Controls.Add(tagNeveCimke);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label tagNeveCimke;
        private Label label2;
        private Label tagNeve_Cimke;
        private Label telefonszamCimke;
        private Button edzesekSzama_Button;
        private Label label5;
        private Label edzesekSzamaCimke;
        private Button legutobbiEdzesTipusaButton;
        private Label label7;
        private Label legutobbiEdzesTipusaCimke;
    }
}
