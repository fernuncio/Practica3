using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica3
{
    public partial class Fechas : Form
    {


        public static void resultado(DateTime inicio, DateTime fin)
        {
            int totalD = (fin - inicio).Days;
            int años = totalD / 365;
            int meses = (1529 - (años * 365)) / 30;
            int dias = (1529 - (años * 365)) - (meses * 30);
            MessageBox.Show("Años: " + años + " Meses: " + meses + " Días: " + dias,
                "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static string estado(string edo)
        {
            string[] abreviaciones = {"AS", "BC", "BS", "CC", "CS", "CH", "CL", "CM", "DF", "DG",
                "GT", "GR", "HG", "JC", "MC", "MN", "MS", "NT", "NL", "OC",
                "PL", "QT", "QR", "SP", "SL", "SR", "TC", "TS", "TL", "VZ",
                "YN", "ZS", "NE"};
            string[] edos = {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas",
                "Chihuahua", "Coahuila", "Colima", "Ciudad de México", "Durango",
                "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Estado de México",
                "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca",
                "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa",
                "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz",
                "Yucatán", "Zacatecas", "Nacido en el Extranjero"};
            for(int i = 0;i<abreviaciones.Length;i++)
            {
                if (abreviaciones[i].Equals(edo))
                    return edos[i];
            }

            return "No encontrado";
        }
        public Fechas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpNacimiento.Value;
            DateTime calculo = dtpCalculo.Value;
            resultado(nacimiento, calculo);
        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            string año = textBoxCurp.Text.Substring(4, 2);
            string mes = textBoxCurp.Text.Substring(6, 2);
            string dia = textBoxCurp.Text.Substring(8, 2);
            string sexo = textBoxCurp.Text.Substring(10, 1);
            string edo = textBoxCurp.Text.Substring(11, 2);
            
            if (sexo == "M")
                labelSexo.Text = "Mujer";
            else
                labelSexo.Text = "Hombre";

            labelEdo.Text = estado(edo);

            if (año[0] == '0')
                labelNac.Text = dia + "-" + mes + "-20" + año;
            else
                labelNac.Text = dia + "-" + mes + "-19" + año;
        }
    }
}
