using Microsoft.Extensions.Configuration;
using Npgsql;


namespace AC4.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static ComarcaDTO GetComarca(NpgsqlDataReader reader)
        {
            ComarcaDTO comarca = new ComarcaDTO
            {
                Year = reader.GetInt32(0), // Suponiendo que el primer campo es para 'Year'
                CodiComarca = reader.GetInt32(1), // Suponiendo que el segundo campo es para 'CodiComarca'
                NomComarca = reader.GetString(2), // Suponiendo que el tercer campo es para 'NomComarca'
                Poblacio = reader.GetInt32(3), // Suponiendo que el cuarto campo es para 'Poblacio'
                DomesticXarxa = reader.GetInt32(4), // Suponiendo que el quinto campo es para 'DomesticXarxa'
                ActivitatsEconomiques = reader.GetInt32(5), // Suponiendo que el sexto campo es para 'ActivitatsEconomiques'
                Total = reader.GetInt32(6), // Suponiendo que el séptimo campo es para 'Total'
                ConsumDomesticPerCapita = reader.GetDouble(7) // Suponiendo que el octavo campo es para 'ConsumDomesticPerCapita'
            };

            return comarca;

        }

    }
}