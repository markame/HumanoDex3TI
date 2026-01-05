using HumanoDex3TI.Model;

using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.AccessControl;
using System.Text;

namespace HumanoDex3TI.Service
{
    public  class HumanoDexMongoService
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Humano> _collection;
        public HumanoDexMongoService()
        {
            const string connectionUri = "mongodb+srv://markame:5OvizmRUyqWUUkIg@cluster0.wv8fy3o.mongodb.net/?appName=Cluster0";

            var settings = MongoClientSettings.
                FromConnectionString(connectionUri);

            settings.ServerApi = new 
                ServerApi(ServerApiVersion.V1);

            var client = new MongoClient(settings);
            _database = client.GetDatabase("HumanoDexDB");
            _collection = _database.GetCollection<Humano>
                (typeof(Humano).Name); 
        }
        public async void insertMongoAsync(Humano obj)
        {
            try
            {
                await _collection.InsertOneAsync(obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir documento: " + ex.Message);

            }
        }

        public async Task<ObservableCollection<Humano>> getAllHumano()
        {
            try
            {
                var filter = Builders<Humano>.Filter.Empty;
                var humano = await _collection.Find(filter).ToListAsync();
                return new ObservableCollection<Humano>(humano);
            }
            catch{

                return null;
            }
        } 

        public async Task<Humano> getHumanoById(string id)
        {
            try
            {
                var filter = Builders<Humano>.Filter.Eq("_id", ObjectId.Parse(id));
                var humano = await _collection.Find(filter).FirstOrDefaultAsync();
                return humano;
            }
            catch
            {
                return null;
            }
        }

    }
}
