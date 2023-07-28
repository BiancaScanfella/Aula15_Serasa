using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula15_Serasa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void atualiza_interface()
        {
            listView1.Clear();
            for(int i = 0; i< Program.cliente.Count; i++)
            {
                listView1.Items.Add(Program.cliente[i].nome);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            atualiza_interface();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioCadastro = txtUsuarioCadas.Text;
            string nome = txtNomeComp.Text;
            string senha = txtSenhaCadas.Text;
            int idade = 2023 - int.Parse(txtDataNasc.Text);

            Usuario usuario = new Usuario(usuarioCadastro, senha);
            Cliente cliente = new Cliente(nome, idade, usuario);
            Program.cliente.Add(cliente);

            atualiza_interface();
        }
    }
}
