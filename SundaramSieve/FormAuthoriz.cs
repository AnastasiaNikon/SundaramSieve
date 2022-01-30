using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SundaramSieve
{
    public partial class FormAuthoriz : Form
    {
        private User user = new User();
        public FormAuthoriz()
        {
            InitializeComponent();
        }

        private void addUserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            confirmTextBox.Visible = !confirmTextBox.Visible;
            confirmGroupBox.Visible = !confirmGroupBox.Visible;
            confirmTextBox.Text = "";
            confirmInfoLabel.Visible = false;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length < 8)
            {
                usernameInfoLabel.Text = "Минимум 8 символов!";
                usernameInfoLabel.Visible = true;
                authorizButton.Enabled = false;
            }
            else
            {
                usernameInfoLabel.Visible = false;
                if (passwordTextBox.Text.Length >= 8)
                {
                    authorizButton.Enabled = true;
                }
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length < 8)
            {
                passwordInfoLabel.Text = "Минимум 8 символов!";
                passwordInfoLabel.Visible = true;
                authorizButton.Enabled = false;
            }
            else
            {
                passwordInfoLabel.Visible = false;
                if (usernameTextBox.Text.Length >= 8)
                {
                    authorizButton.Enabled = true;
                }
            }
        }

        private void confirmTextBox_TextChanged(object sender, EventArgs e)
        {
            if (confirmTextBox.Text.Length < 8)
            {
                confirmInfoLabel.Text = "Минимум 8 символов!";
                confirmInfoLabel.Visible = true;
            }
            else
            {
                confirmInfoLabel.Visible = false;
            }
        }

        private void authorizButton_Click(object sender, EventArgs e)
        {
            if (addUserCheckBox.Checked)
            {
                signup(); // регестрируем пользователя
            }
            else
            {
                signin(); // входим в систему
            }
        }

        /// <summary>
        /// Регистрирует нового пользователя
        /// </summary>
        private void signup()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirm = confirmTextBox.Text;

            if (password != confirm)
            {
                ShowMessage("Пароли не совпадают!", "Ошибка регистрации");
            }
            else if (user.Exists(username))
            {
                ShowMessage("Данное имя пользователя уже занято!", "Ошибка регистрации");
            }
            else
            {
                user.Add(username, password);
                ShowMessage("Регистрация прошла успешно", "С пополнением");

                this.Hide();
                var form = new FormSieve();
                form.FormClosed += (s, args) => this.Close();
                form.Show();
            }
        }

        /// <summary>
        /// Входит в систему как существующий пользователь
        /// </summary>
        private void signin()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (user.Valid(username, password))
            {
                this.Hide();
                var form = new FormSieve();
                form.FormClosed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
                ShowMessage("Неверное имя пользователя или пароль!", "Ошибка входа");
            }
        }

        /// <summary>
        /// Показывает на экран заданное сообщение
        /// </summary>
        /// <param name="main">Основной текст</param>
        /// <param name="handler">Шапка сообщения</param>
        /// <param name="button">Необходимые кнопки. По умолчанию ОК</param>
        /// <param name="icon">Иконка сообщения. По умолчанию Информация</param>
        private void ShowMessage(string main, string handler, MessageBoxButtons button = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            MessageBox.Show(main, handler, button, icon);
        }
    }
}
