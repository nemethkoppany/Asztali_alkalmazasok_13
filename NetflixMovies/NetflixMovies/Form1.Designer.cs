namespace NetflixMovies
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
            kereses_button = new Button();
            tol_numericUpDown = new NumericUpDown();
            ig_NumericUpDown = new NumericUpDown();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tol_numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ig_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 0;
            label1.Text = "Netflixes Film keresés";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 59);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Értékelés";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 67);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 2;
            label3.Text = "-tól";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 65);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 3;
            label4.Text = "-ig";
            // 
            // kereses_button
            // 
            kereses_button.Location = new Point(343, 105);
            kereses_button.Name = "kereses_button";
            kereses_button.Size = new Size(75, 23);
            kereses_button.TabIndex = 4;
            kereses_button.Text = "Keresés";
            kereses_button.UseVisualStyleBackColor = true;
            kereses_button.Click += kereses_button_Click;
            // 
            // tol_numericUpDown
            // 
            tol_numericUpDown.DecimalPlaces = 4;
            tol_numericUpDown.Location = new Point(153, 59);
            tol_numericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            tol_numericUpDown.Name = "tol_numericUpDown";
            tol_numericUpDown.Size = new Size(120, 23);
            tol_numericUpDown.TabIndex = 5;
            // 
            // ig_NumericUpDown
            // 
            ig_NumericUpDown.DecimalPlaces = 4;
            ig_NumericUpDown.Location = new Point(453, 57);
            ig_NumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ig_NumericUpDown.Name = "ig_NumericUpDown";
            ig_NumericUpDown.Size = new Size(120, 23);
            ig_NumericUpDown.TabIndex = 6;
            ig_NumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(117, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(537, 304);
            dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cím";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Rendező";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Értékelés";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Nyelv";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Dátum";
            Column5.Name = "Column5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(ig_NumericUpDown);
            Controls.Add(tol_numericUpDown);
            Controls.Add(kereses_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Netflix Movies";
            ((System.ComponentModel.ISupportInitialize)tol_numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ig_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button kereses_button;
        private NumericUpDown tol_numericUpDown;
        private NumericUpDown ig_NumericUpDown;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
