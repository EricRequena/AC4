using Npgsql;

using AC4;

namespace dao.Persistence.Mapping
{
    public class ComarcaDAO : IComarcaDAO
    {
        private readonly string connectionString;

   

        public ComarcaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public ComarcaDTO GetComarcaById(int CodiComarca)
        {
            ComarcaDTO comarca = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"Year\", \"CodiComarca\", \"NomComarca\", \"Poblacio\", \"DomesticXarxa\", " +
                               "\"ActivitatsEconomiques\", \"Total\", \"ConsumDomesticPerCapita\" " +
                               "FROM \"Comarca\" WHERE \"CodiComarca\" = @CodiComarca";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@CodiComarca", CodiComarca);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // ORM: [--,--,--] -----> ContactDTO
                    comarca = NpgsqlUtils.GetComarca(reader);
                }
            }

            return comarca;
        }

        public void AddComarca(ComarcaDTO comarca)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO \"Comarca\" (\"Year\", \"CodiComarca\", \"NomComarca\", \"Poblacio\", \"DomesticXarxa\", \"ActivitatsEconomiques\", \"Total\", \"ConsumDomesticPerCapita\") " +
                               "VALUES (@Year, @CodiComarca, @NomComarca, @Poblacio, @DomesticXarxa, @ActivitatsEconomiques, @Total, @ConsumDomesticPerCapita)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Year", comarca.Year);
                command.Parameters.AddWithValue("@CodiComarca", comarca.CodiComarca);
                command.Parameters.AddWithValue("@NomComarca", comarca.NomComarca);
                command.Parameters.AddWithValue("@Poblacio", comarca.Poblacio);
                command.Parameters.AddWithValue("@DomesticXarxa", comarca.DomesticXarxa);
                command.Parameters.AddWithValue("@ActivitatsEconomiques", comarca.ActivitatsEconomiques);
                command.Parameters.AddWithValue("@Total", comarca.Total);
                command.Parameters.AddWithValue("@ConsumDomesticPerCapita", comarca.ConsumDomesticPerCapita);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateComarca(ComarcaDTO comarca)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "UPDATE \"Comarca\" SET \"NomComarca\" = @NomComarca, \"Poblacio\" = @Poblacio, " +
                               "\"DomesticXarxa\" = @DomesticXarxa, \"ActivitatsEconomiques\" = @ActivitatsEconomiques, " +
                               "\"Total\" = @Total, \"ConsumDomesticPerCapita\" = @ConsumDomesticPerCapita " +
                               "WHERE \"Year\" = @Year AND \"CodiComarca\" = @CodiComarca"; NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Year", comarca.Year);
                command.Parameters.AddWithValue("@CodiComarca", comarca.CodiComarca);
                command.Parameters.AddWithValue("@NomComarca", comarca.NomComarca);
                command.Parameters.AddWithValue("@Poblacio", comarca.Poblacio);
                command.Parameters.AddWithValue("@DomesticXarxa", comarca.DomesticXarxa);
                command.Parameters.AddWithValue("@ActivitatsEconomiques", comarca.ActivitatsEconomiques);
                command.Parameters.AddWithValue("@Total", comarca.Total);
                command.Parameters.AddWithValue("@ConsumDomesticPerCapita", comarca.ConsumDomesticPerCapita);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteComarca(int CodiComarca)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "DELETE FROM \"Comarca\" WHERE \"CodiComarca\" = @CodiComarca";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@CodiComarca", CodiComarca);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ComarcaDTO> GetAllComarcas()
        {
            List<ComarcaDTO> comarcas = new List<ComarcaDTO>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"Year\", \"CodiComarca\", \"NomComarca\", \"Poblacio\", \"DomesticXarxa\", " +
                               "\"ActivitatsEconomiques\", \"Total\", \"ConsumDomesticPerCapita\" FROM \"Comarca\""; NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ComarcaDTO comarca = NpgsqlUtils.GetComarca(reader);
                    comarcas.Add(comarca);
                }
            }
            return comarcas;
        }
    }

}