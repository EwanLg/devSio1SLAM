using System;

using System.Data;

using Npgsql;



namespace ADOExemples

{

    static class Program

    {

        public static void Main()

        {

            NpgsqlConnection maCnx;

            NpgsqlDataReader jeuEnr = null; 


            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Ex36;");

            try

            {

                string requête;

                maCnx.Open(); 

                requête = "Select title, isbn from titles where year_published =@annee";

                var maCde = new NpgsqlCommand(requête, maCnx);

                maCde.Parameters.AddWithValue("@annee", 1979);

                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())

                {

                    Console.Write(jeuEnr["title"] + "\t");

                    Console.Write(jeuEnr["isbn"] + "\t");

                    Console.WriteLine();

                }

            }

            catch (NpgsqlException e)

            {

                Console.WriteLine("Erreur " + e.ToString());

            }

            finally

            {

                if (jeuEnr is object & !jeuEnr.IsClosed)

                {

                    jeuEnr.Close();

                }



                if (maCnx is object & maCnx.State == ConnectionState.Open)

                {

                    maCnx.Close(); 

                }

            }

            Console.ReadLine();

        }

    }

}