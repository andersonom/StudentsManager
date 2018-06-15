using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace StudentsManager.DataMongo.Context
{
    public class StudentsManagerContext
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }
        public static bool IsSSL { get; set; }
        public IMongoDatabase database { get; }
        public StudentsManagerContext(string connectionString)
        {
            ConnectionString = connectionString;
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));

                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                }

                var mongoClient = new MongoClient(settings);

                database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        } 
    }
}
