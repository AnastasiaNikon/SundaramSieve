using System.Data.SQLite;
using System.IO;
using System.Data.Common;

namespace SundaramSieve
{
    class Database
    {
        private string path = @"database.db";

        public Database()
        {
            if (!File.Exists(path))
            {
                Initialize();
            }
        }

        /// <summary>
        /// Инициализирует базу данных
        /// Создает таблицу users и столбцы для имени пользователя (username) и пароля (password)
        /// </summary>
        private void Initialize()
        {
            File.Create(path).Close();
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", path));
            SQLiteCommand command = new SQLiteCommand("DROP TABLE IF EXISTS users;"
                                                        + "CREATE TABLE users("
                                                        + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                                                        + "username TEXT, "
                                                        + "password TEXT); ", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Ищет пользователя с заданными данными в базе
        /// </summary>
        /// <param name="username">имя пользователя</param>
        /// <param name="password">пароль</param>
        /// <returns>True - пользователь существует, False - не найден</returns>
        public bool Valid(string username, string password)
        {
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", path));
            connection.Open();
            SQLiteCommand command1 = new SQLiteCommand("SELECT * FROM 'users'; ", connection);
            SQLiteDataReader reader = command1.ExecuteReader();

            string currUsername = "";
            string currPassword = "";
            foreach (DbDataRecord record in reader)
            {
                currUsername = record["username"].ToString();
                currPassword = record["password"].ToString();
                if (username == currUsername && password == currPassword)
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        /// <summary>
        /// Проверяет существование имени пользователя в базе данных
        /// </summary>
        /// <param name="username">имя пользователя</param>
        /// <returns>True - имя пользователя есть, False - нет</returns>
        public bool Exists(string username)
        {
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", path));
            connection.Open();
            SQLiteCommand command1 = new SQLiteCommand("SELECT * FROM 'users'; ", connection);
            SQLiteDataReader reader = command1.ExecuteReader();

            string currUsername;
            foreach (DbDataRecord record in reader)
            {
                currUsername = record["username"].ToString();
                if (username == currUsername)
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        /// <summary>
        /// Добавляет пользователя в базу данных
        /// </summary>
        /// <param name="username">имя пользователя</param>
        /// <param name="password">пароль</param>
        public bool Add(string username, string password)
        {
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", path));
            connection.Open();
            SQLiteCommand command = new SQLiteCommand($"INSERT INTO 'users' ('username', 'password') VALUES('{username}', '{password}'); ", connection);
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
    }
}
