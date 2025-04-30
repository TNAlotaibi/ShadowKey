using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

class DatabaseClass
{
    static string dbFile = "URI=file:users.db";
    public IEnumerable<string> GetAllRows()
    {
        using (SQLiteConnection sqc = new SQLiteConnection(dbFile))
        {
            sqc.Open();
            string command = "SELECT * FROM users";
            using (SQLiteCommand sqlCommand = new SQLiteCommand(command, sqc))
            using (SQLiteDataReader r = sqlCommand.ExecuteReader())
            {
                int rowsCount = 0;
                while (r.Read())
                {
                    rowsCount++;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("-------------------------------");
                    sb.AppendLine($"Username : {r["username"]}");
                    sb.AppendLine($"Userid : {r["userid"]}");
                    sb.AppendLine($"Password : {r["passwd"]}");
                    sb.AppendLine($"Email : {r["email"]}");
                    yield return sb.ToString();
                }
                yield return $"----------{rowsCount} row{(rowsCount == 1 ? "" : "s")}-----------";
            }
        }
    }
    public IEnumerable<string> GetData(string query)
    {
        SQLiteConnection sqc = new SQLiteConnection(dbFile);

        sqc.Open();
        string command = $"select * from users";
        SQLiteCommand sqlCommand = new SQLiteCommand(command, sqc);
        SQLiteDataReader r = sqlCommand.ExecuteReader();
        while (r.Read())
        {
            string targetQuery = r[query].ToString();
            yield return targetQuery;
        }
        sqc.Close();
    }
    //public string Login(string query, string targetData)
    //{
    //    SQLiteConnection sqc = new SQLiteConnection(dbFile);

    //    sqc.Open();
    //    string command = $"select * from users";
    //    SQLiteCommand sqlCommand = new SQLiteCommand(command, sqc);
    //    SQLiteDataReader r = sqlCommand.ExecuteReader();
    //    while (r.Read())
    //    {
    //        string valueFromDb = r[query]?.ToString().Trim();
    //        string userInput = targetData?.Trim();
    //        if (!string.IsNullOrEmpty(valueFromDb) && valueFromDb == userInput)
    //        {
    //            System.Windows.Forms.MessageBox.Show("[1] : " + userInput);
    //            System.Windows.Forms.MessageBox.Show("[2] : " + targetData);
    //            return userInput;
    //        }

    //    }
    //    sqc.Close();
    //    return null;
    //}
    public bool Login(string username, string password)
    {
        using (var connection = new SQLiteConnection(dbFile))
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND passwd = @password";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username.Trim());
                command.Parameters.AddWithValue("@password", password.Trim());

                long count = (long)command.ExecuteScalar();
                return count > 0;
            }
        }
    }


    public string GetEmailByUsername(string targetData)
    {
        SQLiteConnection sqc = new SQLiteConnection(dbFile);

        sqc.Open();
        string command = $"select * from users";
        SQLiteCommand sqlCommand = new SQLiteCommand(command, sqc);
        SQLiteDataReader r = sqlCommand.ExecuteReader();
        while (r.Read())
        {
            string targetQuery = r["username"].ToString();
            if (targetQuery == targetData)
            {
                return r["email"].ToString();
            }
        }
        sqc.Close();
        return null;
    }
    public IEnumerable<string> getUsernameAndEmail()
    {
        SQLiteConnection sqc = new SQLiteConnection(dbFile);

        sqc.Open();
        string command = $"select * from USERS";
        SQLiteCommand sqlCommand = new SQLiteCommand(command, sqc);
        SQLiteDataReader r = sqlCommand.ExecuteReader();
        while (r.Read())
        {
            string username = (string)r["username"];
            string email = (string)r["email"];

            yield return username + " " + email;
        }
        sqc.Close();
    }
    public bool register(string[] items)
    {
        SQLiteConnection sqc = new SQLiteConnection(dbFile);
        try
        {
            sqc.Open();
        generateIdAgain:
            string userid = generateUserid();
            if (GetData("userid").ToList().Contains(userid))
                goto generateIdAgain;
            string command = $"INSERT INTO USERS (USERNAME,PASSWD, USERID ,EMAIL) VALUES ('{items[0].ToLower()}' , '{items[1]}',{userid},'{items[2].ToLower()}')";
            SQLiteCommand sqlCommand = new SQLiteCommand(command, sqc);
            sqlCommand.ExecuteNonQuery();
            sqc.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public void deleteRow(string userid)
    {
        SQLiteConnection sqc = new SQLiteConnection(dbFile);

        sqc.Open();
        string command = "DELETE from USERS where userid=53324";
        SQLiteCommand sqlCommand = new SQLiteCommand(command, sqc);
        sqlCommand.ExecuteNonQuery();
        sqc.Close();
    }
    private static string generateUserid() => new Random().Next(9999999, 999999999).ToString();
}