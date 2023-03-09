using Microsoft.Data.Sqlite;

namespace Db {
    class DbConnection
    {
        private SqliteConnection DbConn;

        public DbConnection(string URL) {
            this.DbConn = this.DbConnect(URL);
            this.DbMigrations();
        }

        private SqliteConnection DbConnect(string URL)
        {
            return new SqliteConnection(URL); 
        }

        private void DbMigrations()
        {
            this.DbConn.Open();
            var command = this.DbConn.CreateCommand(); 

            command.CommandText = 
                @"
                CREATE TABLE IF NOT EXISTS Messages
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                 text VARCHAR(255),
                 from VARCHAR(255),
                 ts DATE)
                ";

            command.ExecuteScalar();

            this.DbConn.Close();
        }

        // TODO
        public void AddUser() {

        }
    }
}
