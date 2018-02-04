using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHATINTERACTIVO
{

    

    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Lo siento no tengo una respuesta para \n " + Form1.X1 + " \n ¿podrias ayudarme?";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            OBTENER Obtener = new OBTENER();
            Obtener.Frase = Form1.X1;
            Obtener.Respuesta = TxtRespuesta2.Text;

            int resultado = InsertaeliminaModifica.Agregar(Obtener);
            if (resultado > 0)
            {
                MessageBox.Show("Frase agregada, ", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("La frase no se pudo guardar, ", "Datos No Guardados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            this.Hide();

            Form1 frm = new Form1();

            frm.Show();

        }

        private void TxtFrase2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
