using System.Data;
using System.Xml;
using CsvHelper;
using AC4;
using System.Globalization;
using CsvHelper.Configuration;
using System;

namespace AC4
{
    public class Helper
    {
        public static List<ComarcaDTO> LlegirDadesCSV(string path)
        {
            var comarques = new List<ComarcaDTO>();
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var Year = csv.GetField<int>("Year");
                    var codiComarca = csv.GetField<int>("Codi comarca");
                    var nomComarca = csv.GetField("Comarca");
                    var poblacio = csv.GetField<int>("Població");
                    var domesticXarxa = csv.GetField<int>("Domèstic xarxa");
                    var activitatsEconomiques = csv.GetField<int>("Activitats econòmiques i fonts pròpies");
                    var total = csv.GetField<int>("Total");
                    var consumDomesticPerCapita = csv.GetField<double>("Consum domèstic per càpita");

                    var comarca = new ComarcaDTO
                    {
                        Year = Year,
                        CodiComarca = codiComarca,
                        NomComarca = nomComarca,
                        Poblacio = poblacio,
                        DomesticXarxa = domesticXarxa,
                        ActivitatsEconomiques = activitatsEconomiques,
                        Total = total,
                        ConsumDomesticPerCapita = consumDomesticPerCapita
                    };

                    comarques.Add(comarca);


                }
            }
            return comarques;
        }



        public static void CrearXmlDesdeCsv(string rutaArchivo, string rutaXml)
        {
            // Creamos un nuevo documento XML
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xmlDoc.CreateElement("Comarcas");
            xmlDoc.InsertBefore(xmlDeclaration, xmlDoc.DocumentElement);
            xmlDoc.AppendChild(root);

            // Leemos todas las líneas del archivo CSV
            string[] lineas = File.ReadAllLines(rutaArchivo);

            // Iteramos sobre las líneas para crear elementos XML
            for (int i = 1; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');
                if (campos.Length < 3)
                    continue;
                
                // Creamos un nuevo elemento para cada línea del CSV
                XmlElement comarca = xmlDoc.CreateElement("Comarca");
                comarca.SetAttribute("Codigo", campos[1]);
                comarca.InnerText = campos[2] + "," + campos[3];

                root.AppendChild(comarca);
            }

            // Guardamos el documento XML
            xmlDoc.Save(rutaXml);
        }

        public static void CargarXmlEnComboBox(string rutaXml, ComboBox comboBox)
        {
            // Limpiamos el ComboBox antes de cargar nuevos datos
            comboBox.Items.Clear();

            // Cargamos el documento XML
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rutaXml);

            // Iteramos sobre los elementos XML y agregamos los datos al ComboBox
            foreach (XmlNode nodo in xmlDoc.DocumentElement.ChildNodes)
            {
                
                string nombre = nodo.InnerText;
                comboBox.Items.Add(nombre);
            }

            // Seleccionamos el primer elemento del ComboBox (opcional)
            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;
        }

        public static void AppendCsv(List<ComarcaDTO> comarcas)
        {
            //en afegir registres, no cal afegir la capçalera
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using var stream = File.Open(@"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).csv", FileMode.Append);
            using var writer = new StreamWriter(stream);
            using var csvWriter = new CsvWriter(writer, config);
            csvWriter.WriteRecords(comarcas);
        }
    }
}
