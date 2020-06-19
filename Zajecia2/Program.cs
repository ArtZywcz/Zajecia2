using System;
using System.Data.SqlClient;
using Dapper;

namespace Zajecia2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-7TDH2OL\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=SSPI";
            SqlConnection connection = new SqlConnection(connectionString);

            DB db = new DB();

            db.delete(connection); //usuń wszelkie poprzednie jeśli jest

            db.select(connection); //pokazuje nic
            db.insert(connection); //wstaw nowy
            db.select(connection); //pokaz wstawiony

            db.update(connection); //edytuj wstawiony
            db.select(connection); //pokaz zedytowany

            db.delete(connection); //usun nowy
            db.select(connection); //pokaz ze nic nie ma
        }
    }
}
