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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        public static string X1;


        private void BTNENVIAR_Click(object sender, EventArgs e)
        {
            
                dataGridView1.DataSource = InsertaeliminaModifica.BuscarAlumnos(TxtFrase.Text);
            if(dataGridView1.Rows.Count == 0)
            {

               X1 = TxtFrase.Text;

                this.Hide();

               Form2 frm = new Form2();

                frm.Show();
               
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[0];
                X1 = Convert.ToString(row.Cells[1].Value);
                pene.Text = X1;
            }
               

        }
    }
}
