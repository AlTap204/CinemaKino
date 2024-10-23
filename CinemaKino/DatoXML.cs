using System.Collections.Generic;
using System.Xml.Serialization;

namespace CinemaKino
{
    internal class DatoXML
    {
        [XmlRoot("dataset")]
        public class Dataset
        {
            [XmlElement("record")]
            public List<Record> Records { get; set; }
        }

        public class Record
        {
            [XmlElement("id")]
            public int Id { get; set; }

            [XmlElement("first_name")]
            public string FirstName { get; set; }

            [XmlElement("last_name")]
            public string LastName { get; set; }

            [XmlElement("email")]
            public string Email { get; set; }

            [XmlElement("phone")]
            public string Phone { get; set; }

            [XmlElement("gender")]
            public string Gender { get; set; }

            [XmlElement("movie_genres")]
            public string MovieGenres { get; set; }

            [XmlElement("movie_title")]
            public string MovieTitle { get; set; }

            [XmlElement("date")]
            public string Date { get; set; }

            [XmlElement("time")]
            public string Time { get; set; }

            [XmlElement("price")]
            public string Price { get; set; }

            [XmlElement("seat")]
            public int Seat { get; set; }

            [XmlElement("cinema_room")]
            public int CinemaRoom { get; set; }
        }
    }
}
