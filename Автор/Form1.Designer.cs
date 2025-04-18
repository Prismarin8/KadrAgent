
namespace Авторизация
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Login_TextBox = new System.Windows.Forms.TextBox();
            this.Button_Authorization = new System.Windows.Forms.Button();
            this.LinkLabel_Registration_for_Candidate = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_Registration_for_employer_company = new System.Windows.Forms.LinkLabel();
            this.label_slash_link = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(204, 81);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(267, 46);
            this.title.TabIndex = 0;
            this.title.Text = "Authorization";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.BackColor = System.Drawing.Color.Transparent;
            this.Login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_label.Location = new System.Drawing.Point(68, 159);
            this.Login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(73, 29);
            this.Login_label.TabIndex = 1;
            this.Login_label.Text = "Login";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.BackColor = System.Drawing.Color.Transparent;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(68, 238);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(120, 29);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Password_TextBox.Location = new System.Drawing.Point(73, 277);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(532, 26);
            this.Password_TextBox.TabIndex = 4;
            this.Password_TextBox.Text = "Enter your password";
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.Login_TextBox.Location = new System.Drawing.Point(73, 198);
            this.Login_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.Size = new System.Drawing.Size(532, 26);
            this.Login_TextBox.TabIndex = 3;
            this.Login_TextBox.Text = "Enter your login";
            // 
            // Button_Authorization
            // 
            this.Button_Authorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(94)))), ((int)(((byte)(240)))));
            this.Button_Authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Authorization.ForeColor = System.Drawing.Color.White;
            this.Button_Authorization.Location = new System.Drawing.Point(253, 343);
            this.Button_Authorization.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Authorization.Name = "Button_Authorization";
            this.Button_Authorization.Size = new System.Drawing.Size(187, 62);
            this.Button_Authorization.TabIndex = 5;
            this.Button_Authorization.Text = "Log in";
            this.Button_Authorization.UseVisualStyleBackColor = false;
            this.Button_Authorization.Click += new System.EventHandler(this.Button_Authorization_Click);
            // 
            // LinkLabel_Registration_for_Candidate
            // 
            this.LinkLabel_Registration_for_Candidate.AutoSize = true;
            this.LinkLabel_Registration_for_Candidate.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel_Registration_for_Candidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Registration_for_Candidate.Location = new System.Drawing.Point(96, 409);
            this.LinkLabel_Registration_for_Candidate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel_Registration_for_Candidate.Name = "LinkLabel_Registration_for_Candidate";
            this.LinkLabel_Registration_for_Candidate.Size = new System.Drawing.Size(204, 20);
            this.LinkLabel_Registration_for_Candidate.TabIndex = 6;
            this.LinkLabel_Registration_for_Candidate.TabStop = true;
            this.LinkLabel_Registration_for_Candidate.Text = "Registration for Candidate";
            this.LinkLabel_Registration_for_Candidate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Registration_for_Candidate_LinkClicked);
            // 
            // LinkLabel_Registration_for_employer_company
            // 
            this.LinkLabel_Registration_for_employer_company.AutoSize = true;
            this.LinkLabel_Registration_for_employer_company.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel_Registration_for_employer_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabel_Registration_for_employer_company.Location = new System.Drawing.Point(308, 409);
            this.LinkLabel_Registration_for_employer_company.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel_Registration_for_employer_company.Name = "LinkLabel_Registration_for_employer_company";
            this.LinkLabel_Registration_for_employer_company.Size = new System.Drawing.Size(297, 20);
            this.LinkLabel_Registration_for_employer_company.TabIndex = 7;
            this.LinkLabel_Registration_for_employer_company.TabStop = true;
            this.LinkLabel_Registration_for_employer_company.Text = "Registration for the employer company";
            this.LinkLabel_Registration_for_employer_company.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Registration_for_employer_company_LinkClicked);
            // 
            // label_slash_link
            // 
            this.label_slash_link.AutoSize = true;
            this.label_slash_link.BackColor = System.Drawing.Color.Transparent;
            this.label_slash_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slash_link.Location = new System.Drawing.Point(297, 411);
            this.label_slash_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_slash_link.Name = "label_slash_link";
            this.label_slash_link.Size = new System.Drawing.Size(14, 20);
            this.label_slash_link.TabIndex = 8;
            this.label_slash_link.Text = "/";
            // 
            // Form1
            // 
            this.AcceptButton = this.Button_Authorization;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.label_slash_link);
            this.Controls.Add(this.LinkLabel_Registration_for_employer_company);
            this.Controls.Add(this.LinkLabel_Registration_for_Candidate);
            this.Controls.Add(this.Button_Authorization);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Login_TextBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.TextBox Login_TextBox;
        private System.Windows.Forms.Button Button_Authorization;
        private System.Windows.Forms.LinkLabel LinkLabel_Registration_for_Candidate;
        private System.Windows.Forms.LinkLabel LinkLabel_Registration_for_employer_company;
        private System.Windows.Forms.Label label_slash_link;
    }
}

