using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_de_un_circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {

            string radioc = txtradio.Text;
            string resultadoc = txtresultado.Text;

            float radio = float.Parse(radioc);
            float total = 3.1415F * (radio * radio);
           

            txtresultado.Text = total.ToString();


            
        }
    }
}
