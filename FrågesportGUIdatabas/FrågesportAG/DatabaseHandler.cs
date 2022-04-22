using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FrågesportAG
{
    class DatabaseHandler
    {
        private string dbName = "frågesportDB.db";
        private string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public string GetPathAndDbName()
        {
            return Path.Combine(docPath, dbName); ;
        }

        /// <summary>
        /// Create database if not exists.
        /// 
        /// Add table towers to database if it does not exist.
        /// 
        /// Add some towers if the table is empty.
        /// </summary>




        /// <summary>
        /// Get a list of all towers.
        /// </summary>
        /// <returns></returns>
        public List<MainCard> GetQusetions()
        {
            //List<String> entries = new List<string>();
            List<MainCard> fragesporten = new List<MainCard>();


            using (SqliteConnection db =
               new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT * from fragesport", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                // add each tower to the list
                while (query.Read())
                {

                    {
                        MainCard fragesport = new QuestionCard(query.GetString(1), query.GetString(2));


                        fragesporten.Add(fragesport);
                    }

                }

                db.Close();
            }

            return fragesporten;
        }


        private string dbName2 = "frågesportDBmulti.db";
        private string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public string GetPathAndDbName2()
        {
            return Path.Combine(docPath2, dbName2); ;
        }

        /// <summary>
        /// Create database if not exists.
        /// 
        /// Add table towers to database if it does not exist.
        /// 
        /// Add some towers if the table is empty.
        /// </summary>




        /// <summary>
        /// Get a list of all towers.
        /// </summary>
        /// <returns></returns>
        public List<MainCard> GetQusetions2()
        {
            //List<String> entries = new List<string>();
            List<MainCard> fragesporten2 = new List<MainCard>();


            using (SqliteConnection db =
               new SqliteConnection($"Filename={GetPathAndDbName2()}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT * from fragesportMulti", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                // add each tower to the list
                while (query.Read())
                {

                    {
                        


                        MainCard fragesport2 = new MultiAnswer(query.GetString(1), query.GetString(2), query.GetString(3));


                        fragesporten2.Add(fragesport2);
                    }

                }

                db.Close();
            }

            return fragesporten2;
        }

       
       

        // Count rows in table.
        private int NumberOfQuestions()
        {
            int count = 0;
            using (SqliteConnection db =
              new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand sqlCommand = new SqliteCommand();
                sqlCommand.Connection = db;

                sqlCommand.CommandText = "SELECT COUNT (id) FROM fragesport";
                SqliteDataReader query = sqlCommand.ExecuteReader();
                if (query.Read())
                {
                    count = int.Parse(query.GetString(0));
                }

                db.Close();
            }

            return count;
        }
    }
}


