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

        public static string fechaNac(string a,string m,string d)
        {
            string[] meses = {"enero","febrero","marzo","abril","mayo",
                "junio","julio","agosto","septiembre","octubre","noviembre",
                "diciembre"};
            string año, mes, dia;

            int n = int.Parse(m);

            if (m[0] == '0')
                mes = meses[n-1];
            else
                mes = meses[n-1];

            if (a[0] == '0')
                año = "20" + a;
            else
                año = "19" + a;

            return (d + " de " + mes + " de " + año);
        }
        public Fechas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            //DateTime nacimiento = dtpNacimiento.Value;
            //DateTime calculo = dtpCalculo.Value;
            //resultado(nacimiento, calculo);
            DateTime nacimiento = dtpNacimiento.Value;
            DateTime calculo = dtpCalculo.Value;
            int edad = calculo.Year - nacimiento.Year;
            int meses = calculo.Month - nacimiento.Month;
            int dias = calculo.Day - nacimiento.Day;

            if (calculo.Day < nacimiento.Day)
            {
                meses--;
                dias += DateTime.DaysInMonth(nacimiento.Year, nacimiento.Month - 1);

            }

            if (calculo.Month < nacimiento.Month)
            {
                edad--;
                meses += 12;
            }
            

            MessageBox.Show("Años:" + edad + " Meses:" + meses + " Dias:" + dias, "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            labelNac.Text = fechaNac(año,mes,dia);
            
        }
    }
}
