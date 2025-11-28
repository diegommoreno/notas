using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace bdd_5to_3parcial.clases
{
    internal class _2CConection
    {
        private static MongoClient? client;
        private static string connectionString = "";
        private static string databaseName = "";

        static _2CConection()
        {
            var json = File.ReadAllText("appsettings.json");
            var config = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);

            connectionString = config["MongoDB"]["ConnectionString"];
            databaseName = config["MongoDB"]["Database"];

            client = new MongoClient(connectionString);
        }

        public static IMongoDatabase GetDatabase()
        {
            return client.GetDatabase(databaseName);
        }
    }
}