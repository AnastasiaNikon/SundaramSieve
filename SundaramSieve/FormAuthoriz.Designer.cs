
namespace SundaramSieve
{
    partial class FormAuthoriz
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
            this.usernameGroupBox = new System.Windows.Forms.GroupBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.usernameInfoLabel = new System.Windows.Forms.Label();
            this.passwordInfoLabel = new System.Windows.Forms.Label();
            this.confirmInfoLabel = new System.Windows.Forms.Label();
            this.authorizButton = new System.Windows.Forms.Button();
            this.addUserCheckBox = new System.Windows.Forms.CheckBox();
            this.usernameGroupBox.SuspendLayout();
            this.passwordGroupBox.SuspendLayout();
            this.confirmGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameGroupBox
            // 
            this.usernameGroupBox.Controls.Add(this.usernameInfoLabel);
            this.usernameGroupBox.Controls.Add(this.usernameTextBox);
            this.usernameGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameGroupBox.Location = new System.Drawing.Point(12, 12);
            this.usernameGroupBox.Name = "usernameGroupBox";
            this.usernameGroupBox.Size = new System.Drawing.Size(350, 100);
            this.usernameGroupBox.TabIndex = 0;
            this.usernameGroupBox.TabStop = false;
            this.usernameGroupBox.Text = "Имя пользователя";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(6, 28);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(338, 29);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.passwordInfoLabel);
            this.passwordGroupBox.Controls.Add(this.passwordTextBox);
            this.passwordGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordGroupBox.Location = new System.Drawing.Point(12, 118);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(350, 100);
            this.passwordGroupBox.TabIndex = 0;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(6, 28);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(338, 29);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // confirmGroupBox
            // 
            this.confirmGroupBox.Controls.Add(this.confirmInfoLabel);
            this.confirmGroupBox.Controls.Add(this.confirmTextBox);
            this.confirmGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmGroupBox.Location = new System.Drawing.Point(12, 224);
            this.confirmGroupBox.Name = "confirmGroupBox";
            this.confirmGroupBox.Size = new System.Drawing.Size(350, 100);
            this.confirmGroupBox.TabIndex = 0;
            this.confirmGroupBox.TabStop = false;
            this.confirmGroupBox.Text = "Подтверждение пароля";
            this.confirmGroupBox.Visible = false;
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.Location = new System.Drawing.Point(6, 28);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Size = new System.Drawing.Size(338, 29);
            this.confirmTextBox.TabIndex = 0;
            this.confirmTextBox.UseSystemPasswordChar = true;
            this.confirmTextBox.Visible = false;
            this.confirmTextBox.TextChanged += new System.EventHandler(this.confirmTextBox_TextChanged);
            // 
            // usernameInfoLabel
            // 
            this.usernameInfoLabel.AutoSize = true;
            this.usernameInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameInfoLabel.Location = new System.Drawing.Point(6, 60);
            this.usernameInfoLabel.Name = "usernameInfoLabel";
            this.usernameInfoLabel.Size = new System.Drawing.Size(42, 17);
            this.usernameInfoLabel.TabIndex = 1;
            this.usernameInfoLabel.Text = "label1";
            this.usernameInfoLabel.Visible = false;
            // 
            // passwordInfoLabel
            // 
            this.passwordInfoLabel.AutoSize = true;
            this.passwordInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordInfoLabel.Location = new System.Drawing.Point(6, 60);
            this.passwordInfoLabel.Name = "passwordInfoLabel";
            this.passwordInfoLabel.Size = new System.Drawing.Size(42, 17);
            this.passwordInfoLabel.TabIndex = 1;
            this.passwordInfoLabel.Text = "label1";
            this.passwordInfoLabel.Visible = false;
            // 
            // confirmInfoLabel
            // 
            this.confirmInfoLabel.AutoSize = true;
            this.confirmInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmInfoLabel.Location = new System.Drawing.Point(6, 60);
            this.confirmInfoLabel.Name = "confirmInfoLabel";
            this.confirmInfoLabel.Size = new System.Drawing.Size(42, 17);
            this.confirmInfoLabel.TabIndex = 1;
            this.confirmInfoLabel.Text = "label1";
            this.confirmInfoLabel.Visible = false;
            // 
            // authorizButton
            // 
            this.authorizButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizButton.Enabled = false;
            this.authorizButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizButton.Location = new System.Drawing.Point(12, 357);
            this.authorizButton.Name = "authorizButton";
            this.authorizButton.Size = new System.Drawing.Size(350, 33);
            this.authorizButton.TabIndex = 4;
            this.authorizButton.Text = "Войти";
            this.authorizButton.UseVisualStyleBackColor = true;
            this.authorizButton.Click += new System.EventHandler(this.authorizButton_Click);
            // 
            // addUserCheckBox
            // 
            this.addUserCheckBox.AutoSize = true;
            this.addUserCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserCheckBox.Location = new System.Drawing.Point(12, 332);
            this.addUserCheckBox.Name = "addUserCheckBox";
            this.addUserCheckBox.Size = new System.Drawing.Size(189, 19);
            this.addUserCheckBox.TabIndex = 2;
            this.addUserCheckBox.Text = "Создать нового пользователя";
            this.addUserCheckBox.UseVisualStyleBackColor = true;
            this.addUserCheckBox.CheckedChanged += new System.EventHandler(this.addUserCheckBox_CheckedChanged);
            // 
            // FormAuthoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 402);
            this.Controls.Add(this.addUserCheckBox);
            this.Controls.Add(this.authorizButton);
            this.Controls.Add(this.confirmGroupBox);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.usernameGroupBox);
            this.MaximumSize = new System.Drawing.Size(393, 441);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(393, 441);
            this.Name = "FormAuthoriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в программу";
            this.usernameGroupBox.ResumeLayout(false);
            this.usernameGroupBox.PerformLayout();
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.confirmGroupBox.ResumeLayout(false);
            this.confirmGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox usernameGroupBox;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.GroupBox confirmGroupBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox confirmTextBox;
        private System.Windows.Forms.Label usernameInfoLabel;
        private System.Windows.Forms.Label passwordInfoLabel;
        private System.Windows.Forms.Label confirmInfoLabel;
        private System.Windows.Forms.Button authorizButton;
        private System.Windows.Forms.CheckBox addUserCheckBox;
    }
}