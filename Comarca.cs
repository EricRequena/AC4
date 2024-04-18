using Npgsql;

namespace AC4
{
    public class Comarca
    {
        public int Year { get; set; }
        public int CodiComarca { get; set; }
        public string NomComarca { get; set; }
        public int Poblacio { get; set; }
        public int DomesticXarxa { get; set; }
        public int ActivitatsEconomiques { get; set; }
        public int Total { get; set; }
        public double ConsumDomesticPerCapita { get; set; }

       

        public Comarca(int Year, int codiComarca, string nomComarca, int poblacio, int domesticXarxa, int activitatsEconomiques, int total, double consumDomesticPerCapita)
        {
            Year = Year;
            CodiComarca = codiComarca;
            NomComarca = nomComarca;
            Poblacio = poblacio;
            DomesticXarxa = domesticXarxa;
            ActivitatsEconomiques = activitatsEconomiques;
            Total = total;
            ConsumDomesticPerCapita = consumDomesticPerCapita;
        }

        public Comarca()
        {
        }
    }
}