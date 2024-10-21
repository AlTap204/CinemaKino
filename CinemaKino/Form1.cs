using System.Runtime.InteropServices;
using System.Xml.Serialization;
using CinemaKino;

namespace CinemaKino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //List<Dato> datos = LeerCSV();
                List<Dato> datos = LeerTAB();
                Insertar(datos);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void Insertar(List<Dato> datos)
        {
            try
            {
                Dato dato = new Dato();
                dato.Agregar(datos);
                MessageBox.Show("Datos agregados correctamente :D");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Busqueda()
        {
            try
            {
                Dato dato = new Dato();
                dato = dato.Obtener("Joseito");

                MessageBox.Show(dato.FirstName + dato.LastName);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<Dato> LeerTexto(string archivo, string delimitador)
        {
            try
            {
                string[] data = File.ReadAllLines(archivo);

                bool isHeader = true;
                List<Dato> datos = new List<Dato>();

                foreach (string line in data)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }
                    var renglon = line.Split(delimitador);

                    DateOnly.TryParse(renglon[8], out DateOnly date);
                    TimeOnly.TryParse(renglon[9], out TimeOnly time);
                    decimal.TryParse(renglon[10], out decimal price);
                    int.TryParse(renglon[11], out int seat);
                    int.TryParse(renglon[12], out int cinemaRoom);

                    Dato dato = new Dato
                    {
                        FirstName = renglon[1],
                        LastName = renglon[2],
                        Email = renglon[3],
                        Phone = renglon[4],
                        Gender = renglon[5],
                        MovieGenres = renglon[6],
                        MovieTitle = renglon[7],
                        Date = date,
                        Time = time,
                        Price = price,
                        Seat = seat,
                        CinemaRoom = cinemaRoom
                    };

                    datos.Add(dato);
                }
                return datos;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Dato> LeerCSV()
        {
            try
            {

                string archivo = "Archivos\\MOCK_DATA.csv";
                string delimitador = ",";
                List<Dato> datos = LeerTexto(archivo, delimitador);


                return datos;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Dato> LeerTAB()
        {
            try
            {

                string archivo = "Archivos\\MOCK_DATA_TAB.txt";
                string delimitador = "\t";
                List<Dato> datos = LeerTexto(archivo, delimitador);


                return datos;

            }
            catch (Exception)
            {

                throw;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Busqueda();
        }

        private List<Dato> LeerJson()
        {
            try
            {
                string data = File.ReadAllText("Archivos\\MOCK_DATA.json");
                var options = new System.Text.Json.JsonSerializerOptions();
                options.PropertyNameCaseInsensitive = true;

                var datosJson = System.Text.Json.JsonSerializer.Deserialize<List<DatoJson>>(data, options);

                List<Dato> datos = new List<Dato>();

                foreach (var datoJson in datosJson)
                {
                    Dato dato = new Dato();
                    dato.FirstName = datoJson.FirstName;
                    dato.LastName = datoJson.LastName;
                    dato.Email = datoJson.Email;
                    dato.Phone = datoJson.Phone;
                    dato.Gender = datoJson.Gender;
                    dato.MovieGenres = datoJson.MovieGenres;
                    dato.MovieTitle = datoJson.MovieTitle;
                    dato.Date = DateOnly.Parse(datoJson.Date);
                    dato.Time = TimeOnly.Parse(datoJson.Time);
                    dato.Price = decimal.Parse(datoJson.Price.Trim('$'));
                    dato.Seat = datoJson.Seat;
                    dato.CinemaRoom = datoJson.CinemaRoom;
                    datos.Add(dato);
                }
                return datos;



            }
            catch (Exception)
            {

                throw;
            }
        }
        private List<Dato> LeerXML()
        {
            try
            {
                string archivo = "Archivos\\MOCK_DATA.xml";
                XmlSerializer serializer = new XmlSerializer(typeof(Dataset));

                using (FileStream fs = new FileStream(archivo, FileMode.Open))
                {
                    var dataset = (Dataset)serializer.Deserialize(fs);

                    List<Dato> datos = new List<Dato>();

                    foreach (var record in dataset.Records)
                    {
                        Dato dato = new Dato
                        {
                            FirstName = record.FirstName,
                            LastName = record.LastName,
                            Email = record.Email,
                            Phone = record.Phone,
                            Gender = record.Gender,
                            MovieGenres = record.MovieGenres,
                            MovieTitle = record.MovieTitle,
                            Date = DateOnly.Parse(record.Date),
                            Time = TimeOnly.Parse(record.Time),
                            Price = decimal.Parse(record.Price.Trim('$')),
                            Seat = record.Seat,
                            CinemaRoom = record.CinemaRoom
                        };

                        datos.Add(dato);
                    }

                    return datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer archivo XML: " + ex.Message);
                throw;
            }
        }
        private void btnJson_Click(object sender, EventArgs e)
        {
            try
            {
                //List<Dato> datos = LeerCSV();
                List<Dato> datos = LeerJson();
                //Insertar(datos);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                List<Dato> datos = LeerXML();

                Insertar(datos);

                MessageBox.Show("Datos de XML agregados correctamente a MongoDB");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
