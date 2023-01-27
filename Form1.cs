using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6CoyRoldaPablo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.ToUpper();
            listBox1.Items.Add("Libro: " + nombre);

            string autor = textBox2.Text.ToUpper();
            listBox1.Items.Add("Autor: " + autor);


            string genero = comboBox1.SelectedItem.ToString().ToUpper();
            listBox1.Items.Add("Género: " + genero);



            int paginas = int.Parse(textBox3.Text);
            listBox1.Items.Add("Páginas: " + paginas);


            if (checkImportado.Checked)
            {
                string origen = "IMPORTADO";
                listBox1.Items.Add("Origen: " + origen);
            }
            else if(checkNacional.Checked)
            {
                string origen1 = "NACIONAL";
                listBox1.Items.Add("Origen: " + origen1);
            }


            decimal precio = decimal.Parse(textBox4.Text);
            listBox1.Items.Add("Precio: " + "$" + precio);



        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }
        /*//Boton de borrar campos eliminado
private void button1_Click(object sender, EventArgs e)
{
   textBox1.Clear();
   textBox2.Clear();
   listBox1.ClearSelected();
   comboBox1.SelectedIndex = -1;
   checkNacional.Checked = false;
   checkImportado.Checked = false;
   textBox4.Clear();
   textBox5.Clear();

}*/


    }
}

