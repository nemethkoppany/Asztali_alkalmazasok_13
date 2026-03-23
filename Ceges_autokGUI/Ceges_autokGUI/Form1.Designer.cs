namespace Ceges_autokGUI
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
            dataGridView1 = new DataGridView();
            datum = new DataGridViewTextBoxColumn();
            rendszam = new DataGridViewTextBoxColumn();
            auto = new DataGridViewTextBoxColumn();
            kmAllas = new DataGridViewTextBoxColumn();
            irany = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ujBerlesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(1, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(187, 454);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { datum, rendszam, auto, kmAllas, irany });
            dataGridView1.Location = new Point(194, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 189);
            dataGridView1.TabIndex = 1;
            // 
            // datum
            // 
            datum.HeaderText = "Dátum";
            datum.Name = "datum";
            // 
            // rendszam
            // 
            rendszam.HeaderText = "Rendszám";
            rendszam.Name = "rendszam";
            // 
            // auto
            // 
            auto.HeaderText = "Autó";
            auto.Name = "auto";
            // 
            // kmAllas
            // 
            kmAllas.HeaderText = "km óra állás";
            kmAllas.Name = "kmAllas";
            // 
            // irany
            // 
            irany.HeaderText = "Irány";
            irany.Name = "irany";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // ujBerlesButton
            // 
            ujBerlesButton.Location = new Point(652, 11);
            ujBerlesButton.Name = "ujBerlesButton";
            ujBerlesButton.Size = new Size(75, 23);
            ujBerlesButton.TabIndex = 3;
            ujBerlesButton.Text = "Új bérlés felvétele";
            ujBerlesButton.UseVisualStyleBackColor = true;
            ujBerlesButton.Click += ujBerlesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ujBerlesButton);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn datum;
        private DataGridViewTextBoxColumn rendszam;
        private DataGridViewTextBoxColumn auto;
        private DataGridViewTextBoxColumn kmAllas;
        private DataGridViewTextBoxColumn irany;
        private Button ujBerlesButton;
    }
}
