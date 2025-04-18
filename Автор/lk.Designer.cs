namespace Авторизация
{
    partial class lk
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
            this.Dolj_ComboBox = new System.Windows.Forms.ComboBox();
            this.dolj_label = new System.Windows.Forms.Label();
            this.Label_Experience = new System.Windows.Forms.Label();
            this.Education_label = new System.Windows.Forms.Label();
            this.Education_ComboBox = new System.Windows.Forms.ComboBox();
            this.Experience_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sumbit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Experience_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dolj_ComboBox
            // 
            this.Dolj_ComboBox.FormattingEnabled = true;
            this.Dolj_ComboBox.Location = new System.Drawing.Point(109, 71);
            this.Dolj_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Dolj_ComboBox.Name = "Dolj_ComboBox";
            this.Dolj_ComboBox.Size = new System.Drawing.Size(209, 24);
            this.Dolj_ComboBox.TabIndex = 0;
            // 
            // dolj_label
            // 
            this.dolj_label.AutoSize = true;
            this.dolj_label.BackColor = System.Drawing.Color.Transparent;
            this.dolj_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dolj_label.Location = new System.Drawing.Point(105, 32);
            this.dolj_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dolj_label.Name = "dolj_label";
            this.dolj_label.Size = new System.Drawing.Size(154, 29);
            this.dolj_label.TabIndex = 21;
            this.dolj_label.Text = "Должность: ";
            // 
            // Label_Experience
            // 
            this.Label_Experience.AutoSize = true;
            this.Label_Experience.BackColor = System.Drawing.Color.Transparent;
            this.Label_Experience.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Experience.Location = new System.Drawing.Point(408, 32);
            this.Label_Experience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Experience.Name = "Label_Experience";
            this.Label_Experience.Size = new System.Drawing.Size(178, 29);
            this.Label_Experience.TabIndex = 23;
            this.Label_Experience.Text = "Опыт работы: ";
            // 
            // Education_label
            // 
            this.Education_label.AutoSize = true;
            this.Education_label.BackColor = System.Drawing.Color.Transparent;
            this.Education_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Education_label.Location = new System.Drawing.Point(713, 32);
            this.Education_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Education_label.Name = "Education_label";
            this.Education_label.Size = new System.Drawing.Size(182, 29);
            this.Education_label.TabIndex = 26;
            this.Education_label.Text = "Образование: ";
            // 
            // Education_ComboBox
            // 
            this.Education_ComboBox.FormattingEnabled = true;
            this.Education_ComboBox.Location = new System.Drawing.Point(717, 71);
            this.Education_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Education_ComboBox.Name = "Education_ComboBox";
            this.Education_ComboBox.Size = new System.Drawing.Size(209, 24);
            this.Education_ComboBox.TabIndex = 25;
            // 
            // Experience_NumericUpDown
            // 
            this.Experience_NumericUpDown.Location = new System.Drawing.Point(413, 73);
            this.Experience_NumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.Experience_NumericUpDown.Name = "Experience_NumericUpDown";
            this.Experience_NumericUpDown.Size = new System.Drawing.Size(211, 22);
            this.Experience_NumericUpDown.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(817, 325);
            this.dataGridView1.TabIndex = 27;
            // 
            // Sumbit_button
            // 
            this.Sumbit_button.Location = new System.Drawing.Point(397, 119);
            this.Sumbit_button.Margin = new System.Windows.Forms.Padding(4);
            this.Sumbit_button.Name = "Sumbit_button";
            this.Sumbit_button.Size = new System.Drawing.Size(245, 37);
            this.Sumbit_button.TabIndex = 28;
            this.Sumbit_button.Text = "Sumbit";
            this.Sumbit_button.UseVisualStyleBackColor = true;
            this.Sumbit_button.Click += new System.EventHandler(this.Sumbit_button_Click);
            // 
            // lk
            // 
            this.AcceptButton = this.Sumbit_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Sumbit_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Education_label);
            this.Controls.Add(this.Education_ComboBox);
            this.Controls.Add(this.Experience_NumericUpDown);
            this.Controls.Add(this.Label_Experience);
            this.Controls.Add(this.dolj_label);
            this.Controls.Add(this.Dolj_ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "lk";
            this.Text = "Кадровое агентсво";
            this.Load += new System.EventHandler(this.lk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Experience_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Dolj_ComboBox;
        private System.Windows.Forms.Label dolj_label;
        private System.Windows.Forms.Label Label_Experience;
        private System.Windows.Forms.Label Education_label;
        private System.Windows.Forms.ComboBox Education_ComboBox;
        private System.Windows.Forms.NumericUpDown Experience_NumericUpDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Sumbit_button;
    }
}