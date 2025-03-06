using System;

using System.Data;

using Npgsql;



namespace ADOExemples

{

    static class Program

    {

        public static void Main()

        {

            NpgsqlConnection maCnx; // ! déclaration avant le bloc Try

            NpgsqlDataReader jeuEnr = null; // jeu d'enregistrements

            // on déclare jeuEnr ici pour qu'il soit accessible de tout Try Catch



            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=admin;Database=Biblio;");

            try

            {

                string requête;

                maCnx.Open(); // on se connecte



                // NOTA BENE : title est un nom de champ, titles le nom de la table !

                // DEBUT requête paramétrée

                requête = "Select title, isbn from titles where year_published =@annee";

                var maCde = new NpgsqlCommand(requête, maCnx);

                maCde.Parameters.AddWithValue("@annee", 1979);

                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus

                // FIN requête paramétrée



                // DEBUT requête par concaténation

                // requête = "Select title, isbn from titles where year_published =1979" ;

                // var maCde = new NpgsqlCommand(requête, maCnx) ;

                // FIN requête par concaténation



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

                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé

                }



                if (maCnx is object & maCnx.State == ConnectionState.Open)

                {

                    maCnx.Close(); // on se déconnecte

                }

            }

            Console.ReadLine();

        }

    }

}