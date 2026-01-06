namespace RealEstateGUI
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
            splitContainer1 = new SplitContainer();
            SellerNamesListBox = new ListBox();
            button1 = new Button();
            HirdetesekSzamaCimke = new Label();
            label5 = new Label();
            eladoTelefonszamaCimke = new Label();
            label3 = new Label();
            eladoNeveCimke = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(SellerNamesListBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(HirdetesekSzamaCimke);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(eladoTelefonszamaCimke);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(eladoNeveCimke);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(652, 341);
            splitContainer1.SplitterDistance = 217;
            splitContainer1.TabIndex = 0;
            // 
            // SellerNamesListBox
            // 
            SellerNamesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SellerNamesListBox.FormattingEnabled = true;
            SellerNamesListBox.ItemHeight = 15;
            SellerNamesListBox.Location = new Point(0, 0);
            SellerNamesListBox.Name = "SellerNamesListBox";
            SellerNamesListBox.Size = new Size(214, 349);
            SellerNamesListBox.TabIndex = 0;
            SellerNamesListBox.SelectedIndexChanged += SellerNamesListBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(33, 96);
            button1.Name = "button1";
            button1.Size = new Size(395, 23);
            button1.TabIndex = 6;
            button1.Text = "Hirdetések betöltése";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HirdetesekSzamaCimke
            // 
            HirdetesekSzamaCimke.AutoSize = true;
            HirdetesekSzamaCimke.Location = new Point(173, 135);
            HirdetesekSzamaCimke.Name = "HirdetesekSzamaCimke";
            HirdetesekSzamaCimke.Size = new Size(13, 15);
            HirdetesekSzamaCimke.TabIndex = 5;
            HirdetesekSzamaCimke.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 135);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 4;
            label5.Text = "Hirdetések száma";
            // 
            // eladoTelefonszamaCimke
            // 
            eladoTelefonszamaCimke.AutoSize = true;
            eladoTelefonszamaCimke.Location = new Point(173, 67);
            eladoTelefonszamaCimke.Name = "eladoTelefonszamaCimke";
            eladoTelefonszamaCimke.Size = new Size(0, 15);
            eladoTelefonszamaCimke.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 67);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Eladó telefonszáma";
            // 
            // eladoNeveCimke
            // 
            eladoNeveCimke.AutoSize = true;
            eladoNeveCimke.Location = new Point(173, 23);
            eladoNeveCimke.Name = "eladoNeveCimke";
            eladoNeveCimke.Size = new Size(0, 15);
            eladoNeveCimke.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Eladó neve";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 341);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox SellerNamesListBox;
        private Button button1;
        private Label HirdetesekSzamaCimke;
        private Label label5;
        private Label eladoTelefonszamaCimke;
        private Label label3;
        private Label eladoNeveCimke;
        private Label label1;
    }
}
