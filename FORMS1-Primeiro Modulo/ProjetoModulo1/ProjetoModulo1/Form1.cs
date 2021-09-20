using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo1
{
    public partial class form : Form
    {
        private int iSelecionado = -1;

        public form()
        {
            InitializeComponent();
        }

        private void btnBotao1_Click(object sender, EventArgs e)
        {
            if (iSelecionado > -1)
            {
                listBox1.Items[iSelecionado] = txtNome.Text;
                Ordenar();
                btnLimpar_Click(btnLimpar, new EventArgs());
                iSelecionado = -1;
                btnCadastrar.Text = "Cadastrar";
                return;
            }
            listBox1.Items.Add(txtNome.Text);
            txtNome.Text = String.Empty;
            Ordenar();
            btnLimpar_Click(btnLimpar, new EventArgs());
        }

        private void Ordenar()
        {
            ListBox.ObjectCollection lista = listBox1.Items;
            List<String> listaString = new List<String>();
            foreach (var item in lista)
            {
                listaString.Add(item.ToString());
            }
            listaString = (from s in listaString select s).OrderBy(x => x).ToList();
            listBox1.Items.Clear();
            foreach (var item in listaString)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBotao1_Click(btnCadastrar, new EventArgs());
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            iSelecionado = listBox1.SelectedIndex;
            txtNome.Text = listBox1.Items[iSelecionado].ToString();
            btnCadastrar.Text = "Alterar";
        }
    }
}
