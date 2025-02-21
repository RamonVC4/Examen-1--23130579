namespace Examen_1__23130579
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialogExamen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFileDialogExamen.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialogExamen.FileName);
                string[] ren = text.Split('\n');
                string[] col = ren[0].Split(',');

                dgvDatos.RowCount = ren.Length;
                dgvDatos.ColumnCount = col.Length;

                for (int i = 0; i < ren.Length - 1; i++)
                {
                    int años = int.Parse(ren[i].Substring(4,2).ToString());


                    String sexo = ren[i].Substring(10,1);
                    if (sexo == "M")
                    {
                        sexo = "Mujer";
                    }
                    else if (sexo == "H")
                    {
                        sexo = "Hombre";
                    }
                    
                    dgvCalculo.Rows.Add(años,sexo);

                    string[] linea = ren[i].Split(",");
                    for (int j = 0; j < linea.Length; j++)
                    {
                        string datos = linea[j];
                        dgvDatos.Rows[i].Cells[j].Value = datos;
                    }
                }
            }
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
 
            
        }
    }
}
