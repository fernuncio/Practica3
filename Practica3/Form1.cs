using System.Text;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //limpiar los datos
            dataGridViewDatos.Rows.Clear();
            dataGridViewDatos.Columns.Clear();
            dataGridViewDatos.AutoGenerateColumns = false;

            DialogResult resultado = openFileDialog.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string texto = File.ReadAllText(filePath);
                    List<string[]> datos = new List<string[]>();
                    List<string> fila = new List<string>();
                    string datoS = "";
                    bool titulo = true;

                    for (int i = 0; i < texto.Length; i++)
                    {
                        //guardar en car cada caracter de texto
                        char car = texto[i];
                        //si es diferente a , o \n entonces guardarlo en 
                        // datoS 
                        if (car != ',' && car != '\n')
                            datoS += car;
                        else
                        {
                            //agregamos la columna
                            fila.Add(datoS);
                            //limpiar la cadena
                            datoS = "";
                            if (car == '\n')
                            {

                                if (titulo)
                                {
                                    //crear las columnas con los titulos
                                    foreach (string columna in fila)
                                    {
                                        dataGridViewDatos.Columns.Add(columna, columna);
                                    }
                                    titulo = false;
                                }
                                else
                                {
                                    datos.Add(fila.ToArray());
                                }
                                fila = new List<string>();
                            }
                        }
                    }
                    //if (!string.IsNullOrEmpty(datoS))
                    //{
                    //    fila.Add((datoS));
                    //    datos.Add(fila.ToArray());
                    //}
                    //vaciamos datos en el dtaGridView 
                    foreach (string[] renglon in datos)
                    {
                        dataGridViewDatos.Rows.Add(renglon);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo" + ex.Message);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                int total = dataGridViewDatos.Rows.Count - 1;
                string linea = "";
                for (int c = 0; c < dataGridViewDatos.ColumnCount; c++)
                {
                    linea += dataGridViewDatos.Columns[c].HeaderText;
                    if (c == dataGridViewDatos.Columns.Count - 1)
                        linea += ",";
                }
                linea += '\n';
                for (int i = 0; i < total; i++)
                {

                    for (int j = 0; j < dataGridViewDatos.Columns.Count; j++)
                    {
                        if (j == dataGridViewDatos.Columns.Count - 1)
                            linea += dataGridViewDatos.Rows[i].Cells[j].Value.ToString() + "\n";
                        else
                            linea += dataGridViewDatos.Rows[i].Cells[j].Value.ToString() + ",";
                    }

                }
                File.WriteAllText(filename, linea);
            }
        }
    }
}
