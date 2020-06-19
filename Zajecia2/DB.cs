using Dapper;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;

namespace Zajecia2
{
    class DB
    {

        public void insert(SqlConnection con)
        {

            string sql = "INSERT INTO Authors (au_id, au_lname, au_fname, phone, contract) Values (@au_id, @au_lname, @au_fname, @phone, @contract);";


            
            
            con.Execute(sql, new { 
                au_id = "888-88-8888",
                au_lname = "Zywczak",
                au_fname = "Artur",
                phone = "888888888",
                contract = "0"});


        }
        public void delete(SqlConnection con)
        {
            string sql = "DELETE FROM Authors WHERE au_id = @au_id";

            
            con.Execute(sql, new { au_id = "888-88-8888"});
        }
        public void select(SqlConnection con)
        {
            string sql = "SELECT * FROM Authors WHERE au_id = @au_id";

            var results = con.Query<Authors>(sql, new { au_id = "888-88-8888"});

            foreach (Authors x in results)
            {
                Console.WriteLine(x.au_id + " " + x.au_lname + " " + x.au_fname + " " + x.phone + " " + x.adress
                    + " " + x.city + " " + x.state + " " + x.zip + " " + x.contract);
            }

        }

        public void update(SqlConnection con)
        {
            string sql = "UPDATE Authors SET phone = @phone, contract = @contract where au_id = '888-88-8888'";

            con.Execute(sql, new
            {
                phone = "777777777",
                contract = 1
            });
        }
    }

       
    }

