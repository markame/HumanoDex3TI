using HumanoDex3TI.Service;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;


namespace HumanoDex3TI.Model
{
    public class Humano : HumanoDexMongoService
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private ObjectId id;
        private string nome;
        private decimal peso;
        private decimal altura;
        private string genero;
        private string foto;

        public ObjectId Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public decimal Altura { get => altura; set => altura = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Foto { get => foto; set => foto = value; }

        public  string insertMongo(Humano obj)
        {
            try
            {
                base.insertMongoAsync(obj);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
       
            

    }

   
}
