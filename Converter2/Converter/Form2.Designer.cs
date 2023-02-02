namespace Converter
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
            this.buttonInter = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonCompleteRegistration = new System.Windows.Forms.Button();
            this.buttonCancelReg = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxRepeatedPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInter
            // 
            this.buttonInter.Location = new System.Drawing.Point(8, 100);
            this.buttonInter.Name = "buttonInter";
            this.buttonInter.Size = new System.Drawing.Size(164, 26);
            this.buttonInter.TabIndex = 0;
            this.buttonInter.Text = "Вход";
            this.buttonInter.UseVisualStyleBackColor = true;
            this.buttonInter.Click += new System.EventHandler(this.buttonInter_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(8, 129);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(164, 26);
            this.buttonRegistration.TabIndex = 1;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonCompleteRegistration
            // 
            this.buttonCompleteRegistration.Location = new System.Drawing.Point(8, 144);
            this.buttonCompleteRegistration.Name = "buttonCompleteRegistration";
            this.buttonCompleteRegistration.Size = new System.Drawing.Size(164, 23);
            this.buttonCompleteRegistration.TabIndex = 2;
            this.buttonCompleteRegistration.Text = "Зарегистрироваться";
            this.buttonCompleteRegistration.UseVisualStyleBackColor = true;
            this.buttonCompleteRegistration.Visible = false;
            this.buttonCompleteRegistration.Click += new System.EventHandler(this.buttonCompleteRegistration_Click);
            // 
            // buttonCancelReg
            // 
            this.buttonCancelReg.Location = new System.Drawing.Point(8, 173);
            this.buttonCancelReg.Name = "buttonCancelReg";
            this.buttonCancelReg.Size = new System.Drawing.Size(164, 23);
            this.buttonCancelReg.TabIndex = 3;
            this.buttonCancelReg.Text = "Отмена";
            this.buttonCancelReg.UseVisualStyleBackColor = true;
            this.buttonCancelReg.Visible = false;
            this.buttonCancelReg.Click += new System.EventHandler(this.buttonCancelReg_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(8, 28);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(164, 22);
            this.textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(8, 72);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(164, 22);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxRepeatedPassword
            // 
            this.textBoxRepeatedPassword.Location = new System.Drawing.Point(8, 116);
            this.textBoxRepeatedPassword.Name = "textBoxRepeatedPassword";
            this.textBoxRepeatedPassword.PasswordChar = '*';
            this.textBoxRepeatedPassword.Size = new System.Drawing.Size(164, 22);
            this.textBoxRepeatedPassword.TabIndex = 6;
            this.textBoxRepeatedPassword.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(64, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Повтор пароля";
            this.label3.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 158);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRepeatedPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonCancelReg);
            this.Controls.Add(this.buttonCompleteRegistration);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonInter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInter;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonCompleteRegistration;
        private System.Windows.Forms.Button buttonCancelReg;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRepeatedPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxLogin;
    }
}