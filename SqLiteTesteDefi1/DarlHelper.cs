using System;
using System.Data;
using System.Data.SQLite;



namespace SqLiteTesteDefi1 {
    public class DalHelper {

        private static SQLiteConnection sqliteConnection;
        public DalHelper() { }


        public static SQLiteConnection DbConnection() {
            sqliteConnection = new SQLiteConnection("Data Source=banco.db;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        public static void CriarBancoSQLite() {
            try {
                SQLiteConnection.CreateFile(@"c:\dados\Cadastro.sqlite");
            }
            catch {
                throw;
            }
        }
        public static void CriarTabelaSQlite() {
            try {
                using (var cmd = DbConnection().CreateCommand()) {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS DadosPessoas(Id int, Nome Varchar(50), Email VarChar(50), Endereço VarChar(50), Telefone int)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static DataTable GetClientes() {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try {
                using (var cmd = DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM DadosPessoas";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public static DataTable GetCliente(int id) {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try {
                using (var cmd = DbConnection().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM DadosPessoas Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public static void Add(DadosPessoas cliente) {
             try {
                 using (var cmd = DbConnection().CreateCommand()) {
                     cmd.CommandText = "INSERT INTO DadosPessoas(Nome, Email, Endereço, Telefone) values (@Nome, @Email, @Endereço, @Telefone)";
                     cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                     cmd.Parameters.AddWithValue("@Email", cliente.Email);
                     cmd.Parameters.AddWithValue("@Endereço", cliente.Endereço);
                     cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                     
                     cmd.ExecuteNonQuery();
                 }
             }
             catch (Exception ex) {
                 throw ex;
             }
        }
        public static void Update(DadosPessoas cliente) {
             try {
                 using (var cmd = new SQLiteCommand(DbConnection())) {
                     if (cliente.Id != null) {

                         cmd.CommandText = "UPDATE DadosPessoas SET Nome=@Nome, Email=@Email, Telefone=@Telefone, Endereço=@Endereço WHERE Id=@Id";
                         cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                         cmd.Parameters.AddWithValue("@Email", cliente.Email);
                         cmd.Parameters.AddWithValue("@Endereço", cliente.Endereço);
                         cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                        cmd.Parameters.AddWithValue("@Id", cliente.Id);
                                                 
                         cmd.ExecuteNonQuery();
                     }
                 }
             }
             catch (Exception ex) {
                 throw ex;
             }
        }


        



        public static void Delete(int Id) {
             try {
                 using (var cmd = new SQLiteCommand(DbConnection())) {
                     cmd.CommandText = "DELETE FROM DadosPessoas Where Id=@Id";
                     cmd.Parameters.AddWithValue("@Id", Id);
                     cmd.ExecuteNonQuery();
                 }
             }
             catch (Exception ex) {
                 throw ex;
             }
        }
    }
}