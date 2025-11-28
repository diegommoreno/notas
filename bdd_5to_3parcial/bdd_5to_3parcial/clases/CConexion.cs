using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;


namespace bdd_5to_3parcial.clases
{
    internal class CConexion
    {
       

        public static MongoClient Client = new MongoClient("mongodb://localhost:27017");

        public MongoClient EstablecerConexion()
        {
            try
            {
                List<String> NombreBaseDatos = Client.ListDatabaseNames().ToList();

                foreach(var BD in NombreBaseDatos)
                {
                   MessageBox.Show("Base de datos encontrada: " + BD.ToString());
                }
            }
            catch(MongoClientException e)
            {
                MessageBox.Show("no se logro conectar a la base de datos"+ e.ToString());
            }
            return Client;
        }
        

    }
}
