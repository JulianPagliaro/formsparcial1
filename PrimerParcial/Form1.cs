namespace PRIMERPARCIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double altura, radio, area, baseCilindro, volumen;
            int contador = 0;
            bool finalizar = false;

            while (!finalizar)
            {
                if (!double.TryParse(txtaltura.Text, out altura) || altura < 0)
                {
                    MessageBox.Show("La altura debe ser un valor numérico mayor a 0. Por favor, ingrésela nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtradio.Text, out radio) || radio < 0)
                {
                    MessageBox.Show("El radio debe ser un valor numérico mayor a 0. Por favor, ingréselo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!finalizar)
                {
                    baseCilindro = 3.1416 * Math.Pow(radio, 2);
                    area = 2 * 3.1416 * radio * (altura + radio);
                    volumen = baseCilindro * altura;
                    dataGridView1.Rows.Add (area, volumen, contador);



                }
            }
        }
    }
}