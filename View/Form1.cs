using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using System.Linq;
using Npgsql;
using Npgsql;
using AC4.Persistence.DAO;
using AC4.Persistence.Mapping;
using AC4.Persistence.Utils;

namespace AC4
{
    public partial class Form1 : Form
    {
        private int lineaActual = 0;
        private List<ComarcaDTO> comarcas;

        public Form1()
        {
            InitializeComponent();
            LBLPoblacio.Text = "";
            LBLCM.Text = "";
            LBLCMA.Text = "";
            LBLCMB.Text = "";
            CargarDatosCSV();
            string rutaXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).xml";
            if (!File.Exists(rutaXML))
            {
                CreateXML();
            }
            ChargeComboBoxComarca();
            Cuadro.CellClick += DataGridView1_CellClick;

        }

        private void CargarDatosCSV()
        {

            string rutaArchivo = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).csv";
            comarcas = Helper.LlegirDadesCSV(rutaArchivo);
            MostrarSiguientes10Lineas();

        }

        private void CreateXML()
        {
            string rutaXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).xml";
            string rutaArchivo = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).csv";
            Helper.CrearXmlDesdeCsv(rutaArchivo, rutaXML);
        }

        private void ChargeComboBoxComarca()
        {
            string rutaXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).xml";
            Helper.CargarXmlEnComboBox(rutaXML, ComboBoxComarca);


        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                DataGridViewRow row = Cuadro.Rows[n];
                List<ComarcaDTO> comarcas = Helper.LlegirDadesCSV(@"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).csv");

                int poblacio = Convert.ToInt32(row.Cells[3].Value);
                LBLPoblacio.Text = (poblacio > 20000) ? "SI" : "NO";

                string comarca = row.Cells[2].Value.ToString();
                var filterComarcasName = comarcas.Where(c => c.NomComarca == comarca);
                double consum = filterComarcasName.Average(c => c.ConsumDomesticPerCapita);
                LBLCM.Text = $"{consum:N0}";

                double consumDomesticPerCapita = Convert.ToDouble(row.Cells[7].Value);
                var filterComarcaALT = filterComarcasName.OrderByDescending(c => c.ConsumDomesticPerCapita).First();
                LBLCMA.Text = filterComarcaALT.ConsumDomesticPerCapita == consumDomesticPerCapita ? "SI" : "NO";

                var filterComarcaBAX = filterComarcasName.OrderByDescending(c => c.ConsumDomesticPerCapita).Last();
                LBLCMB.Text = filterComarcaBAX.ConsumDomesticPerCapita == consumDomesticPerCapita ? "SI" : "NO";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBoxPopulation.Text = "";
            ComboBoxYear.Text = "";
            ComboBoxComarca.Text = "";
            TxtBoxDomestic.Text = "";
            TxtBoxActivities.Text = "";
            TxtBoxTotal.Text = "";
            TxtBoxConsum.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                List<ComarcaDTO> comarques = new List<ComarcaDTO>() {

                    new ComarcaDTO
                    {
                        Year = Convert.ToInt32(ComboBoxYear.Text),
                        CodiComarca = Convert.ToInt32(ComboBoxComarca.SelectedValue),
                        NomComarca = ComboBoxComarca.Text,
                        Poblacio = Convert.ToInt32(TxtBoxPopulation.Text),
                        DomesticXarxa = Convert.ToInt32(TxtBoxDomestic.Text),
                        ActivitatsEconomiques = Convert.ToInt32(TxtBoxActivities.Text),
                        Total = Convert.ToInt32(TxtBoxTotal.Text),
                        ConsumDomesticPerCapita = Convert.ToDouble(TxtBoxConsum.Text)
                    }
                };

                Helper.AppendCsv(comarques);

                CargarDatosCSV();

            }
        }

        private void YearText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ComboBoxYear.Text))
            {
                e.Cancel = true;
                ComboBoxYear.Focus();
                Void.SetError(ComboBoxYear, "Slecciona un año");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(ComboBoxYear, null);
            }
        }

        private void ComarcaText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(ComboBoxYear.Text))
            {
                e.Cancel = true;
                ComboBoxYear.Focus();
                Void.SetError(ComboBoxYear, "Selecciona una Comarca");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(ComboBoxYear, null);
            }

        }

        private void PoblacióText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxPopulation.Text))
            {
                e.Cancel = true;
                TxtBoxPopulation.Focus();
                Void.SetError(TxtBoxPopulation, "Introduce una población");
            }
            else if (!int.TryParse(TxtBoxPopulation.Text, out int result))
            {
                e.Cancel = true;
                TxtBoxPopulation.Focus();
                Void.SetError(TxtBoxPopulation, "Introduce un número");
            }
            else if (int.Parse(TxtBoxPopulation.Text) < 0)
            {
                e.Cancel = true;
                TxtBoxPopulation.Focus();
                Void.SetError(TxtBoxPopulation, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(TxtBoxPopulation, null);
            }
        }

        private void DomésticText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxDomestic.Text))
            {
                e.Cancel = true;
                TxtBoxDomestic.Focus();
                Void.SetError(TxtBoxDomestic, "Introduce un número");
            }
            else if (!int.TryParse(TxtBoxDomestic.Text, out int result))
            {
                e.Cancel = true;
                TxtBoxDomestic.Focus();
                Void.SetError(TxtBoxDomestic, "Introduce un número");
            }
            else if (int.Parse(TxtBoxDomestic.Text) < 0)
            {
                e.Cancel = true;
                TxtBoxDomestic.Focus();
                Void.SetError(TxtBoxDomestic, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(TxtBoxDomestic, null);
            }
        }

        private void ActivitatsText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxActivities.Text))
            {
                e.Cancel = true;
                TxtBoxActivities.Focus();
                Void.SetError(TxtBoxActivities, "Introduce un número");
            }
            else if (!int.TryParse(TxtBoxActivities.Text, out int result))
            {
                e.Cancel = true;
                TxtBoxActivities.Focus();
                Void.SetError(TxtBoxActivities, "Introduce un número");
            }
            else if (int.Parse(TxtBoxActivities.Text) < 0)
            {
                e.Cancel = true;
                TxtBoxActivities.Focus();
                Void.SetError(TxtBoxActivities, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(TxtBoxActivities, null);
            }
        }

        private void ConsumText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxConsum.Text))
            {
                e.Cancel = true;
                TxtBoxConsum.Focus();
                Void.SetError(TxtBoxConsum, "Introduce un número");
            }
            else if (!double.TryParse(TxtBoxConsum.Text, out double result))
            {
                e.Cancel = true;
                TxtBoxConsum.Focus();
                Void.SetError(TxtBoxConsum, "Introduce un número");
            }
            else if (double.Parse(TxtBoxConsum.Text) < 0)
            {
                e.Cancel = true;
                TxtBoxConsum.Focus();
                Void.SetError(TxtBoxConsum, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(TxtBoxConsum, null);
            }
        }

        private void TotalText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxTotal.Text))
            {
                e.Cancel = true;
                TxtBoxTotal.Focus();
                Void.SetError(TxtBoxTotal, "Introduce un número");
            }
            else if (!int.TryParse(TxtBoxTotal.Text, out int result))
            {
                e.Cancel = true;
                TxtBoxTotal.Focus();
                Void.SetError(TxtBoxTotal, "Introduce un número");
            }
            else if (int.Parse(TxtBoxTotal.Text) < 0)
            {
                e.Cancel = true;
                TxtBoxTotal.Focus();
                Void.SetError(TxtBoxTotal, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(TxtBoxTotal, null);
            }
        }

        private void MostrarSiguientes10Lineas()
        {
            int lineasAMostrar = 10;
            var lineasRestantes = comarcas.Skip(lineaActual).Take(lineasAMostrar).ToList();
            Cuadro.DataSource = lineasRestantes;
            Cuadro.Columns[1].Visible = false;
            lineaActual += lineasAMostrar;
        }


        private void BTNAfter_Click_1(object sender, EventArgs e)
        {
            if (lineaActual >= 10)
            {
                lineaActual -= 10;
                MostrarSiguientes10Lineas();
            }

        }

        private void BTNNext_Click_1(object sender, EventArgs e)
        {
            MostrarSiguientes10Lineas();
        }



        private void bttnPersist_Click(object sender, EventArgs e)
        {
            
            int Year = Convert.ToInt32(ComboBoxYear.Text);
            string nomComarca = ComboBoxComarca.Text;
            int poblacio = Convert.ToInt32(TxtBoxPopulation.Text);
            int domesticXarxa = Convert.ToInt32(TxtBoxDomestic.Text);
            int activitatsEconomiques = Convert.ToInt32(TxtBoxActivities.Text);
            int total = Convert.ToInt32(TxtBoxTotal.Text);
            double consumDomesticPerCapita = Convert.ToDouble(TxtBoxConsum.Text);


            IComarcaDAO comarcaDAO = new ComarcaDAO(NpgsqlUtils.OpenConnection());

            ComarcaDTO comarca = new ComarcaDTO
            {
                Year = 2012,
                CodiComarca = 1,
                NomComarca = "Alt Camp",
                Poblacio = 1000,
                DomesticXarxa = 1000,
                ActivitatsEconomiques = 1000,
                Total = 1000,
                ConsumDomesticPerCapita = 1000

               
            };

            try
            {
                comarcaDAO.AddComarca(comarca);
                MessageBox.Show("Comarca persistida correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al persistir la comarca: {ex.Message}");
            }

        }
    }
}
