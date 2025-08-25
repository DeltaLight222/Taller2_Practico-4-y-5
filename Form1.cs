using System.Windows.Forms;

namespace Practico_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int desde;
            int hasta;

            // Validar campos vac�os
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Debe ingresar valores en ambos campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que sean n�meros
            if (!int.TryParse(TDesde.Text, out desde) || !int.TryParse(THasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese solo n�meros v�lidos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar el ListBox antes de agregar
            LBNumeros.Items.Clear();

            // Usando While
            int i = desde;
            while (i <= hasta)
            {
                LBNumeros.Items.Add(i);
                i++;
            }
        }

        private void BPares_Click(object sender, EventArgs e)
        {
            int desde;
            int hasta;

            // Validar campos vac�os
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Debe ingresar valores en ambos campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que sean n�meros
            if (!int.TryParse(TDesde.Text, out desde) || !int.TryParse(THasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese solo n�meros v�lidos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar el ListBox antes de agregar
            LBNumeros.Items.Clear();

            // Usando While
            int i = desde;
            while (i <= hasta)
            {
                if (i % 2 == 0) // Pares
                {
                    LBNumeros.Items.Add(i);
                }
                i++;
            }
        }

        private void BImpares_Click(object sender, EventArgs e)
        {
            int desde;
            int hasta;

            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Debe ingresar valores en ambos campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(TDesde.Text, out desde) || !int.TryParse(THasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese solo n�meros v�lidos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LBNumeros.Items.Clear();

            int i = desde;
            while (i <= hasta)
            {
                if (i % 2 != 0) // Impares
                {
                    LBNumeros.Items.Add(i);
                }
                i++;
            }

        }

        private void BPrimos_Click(object sender, EventArgs e)
        {
            int desde;
            int hasta;

            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Debe ingresar valores en ambos campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(TDesde.Text, out desde) || !int.TryParse(THasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese solo n�meros v�lidos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LBNumeros.Items.Clear();

            int i = desde;
            while (i <= hasta)
            {
                if (EsPrimo(i)) // Verificar primo
                {
                    LBNumeros.Items.Add(i);
                }
                i++;
            }
        }

        // Funci�n auxiliar para saber si un n�mero es primo
        private bool EsPrimo(int num)
        {
            if (num <= 1) return false;
            for (int j = 2; j <= Math.Sqrt(num); j++)
            {
                if (num % j == 0) return false;
            }
            return true;
        }

      
    }
}
