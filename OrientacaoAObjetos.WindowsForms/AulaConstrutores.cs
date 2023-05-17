using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrientacaoAObjetos.Dia2;
using OrientacaoAObjetos.Dia3;

namespace OrientacaoAObjetos.WindowsForms
{
    public partial class AulaConstrutores : Form
    {
        public AulaConstrutores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado();
             MessageBox.Show(segurado.Teste());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("Erick");
            MessageBox.Show(segurado.Nome);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado(42);
            MessageBox.Show(segurado.Id.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("095.785.658.98", "Erick");
            MessageBox.Show(segurado.CPF, segurado.Nome);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado(4,"Erick","879.654.321-56");
            MessageBox.Show($"|-Id:{segurado.Id}  |-Nome:{segurado.Nome}  |-CPF:{segurado.CPF}");
            
            
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new RevisaoConstrutores().Show();
        }
    }
}
