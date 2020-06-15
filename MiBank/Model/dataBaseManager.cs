using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MiBank {
    public class dataBaseManager {


        private string server = "wdt2020.australiasoutheast.cloudapp.azure.com";
        private string database = "s3549218";
        private string user = "s3549218";
        private string password = "abc123";
        private string Trusted_Connection = "false";
        private string encrypt = "True";





      




        public void CheckTables() {

            using (SqlConnection conn = new SqlConnection($"Server={server};Database={database};User Id={user};Password={password};")) {
                conn.Open();

                DataTable dTable = conn.GetSchema("TABLES",
                               new string[] { null, null, "MyTableName" });

                Console.WriteLine($"Tables Exists -- {dTable.Rows.Count > 0}");
            }

        }

    }
}
