using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CinemaKino
{
    public class Dato
    {
        private readonly IMongoCollection<Dato> _datos;

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("firstname")]
        public string FirstName { get; set; }

        [BsonElement("lastname")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; }

        [BsonElement("moviegenres")]
        public string MovieGenres { get; set; }

        [BsonElement("movietitle")]
        public string MovieTitle { get; set; }

        [BsonElement("date")]
        public DateOnly Date { get; set; }

        [BsonElement("time")]
        public TimeOnly Time { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("seat")]
        public int Seat { get; set; }

        [BsonElement("cinemaroom")]
        public int CinemaRoom { get; set; }

        public Dato()
        {
            string connectionString = "mongodb://localhost:27017";

            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("cinemakino");
            _datos = database.GetCollection<Dato>("datos");
        }

        public List<Dato> ObtenerTodos()
        {
            try
            {
                return _datos.Find(_ => true).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Agregar(List<Dato> datos)
        {
            try
            {
                _datos.InsertMany(datos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Dato Obtener(string firstName)
        {
            try
            {
                return _datos.Find(x => x.FirstName == firstName).FirstOrDefault<Dato>();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
