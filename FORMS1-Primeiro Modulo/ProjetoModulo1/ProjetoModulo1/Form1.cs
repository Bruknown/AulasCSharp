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
        private int iSelecionado;

        public form()
        {
            InitializeComponent();
        }

        private void btnBotao1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtNome.Text);
            txtNome.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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
            txtNome.Text = ListBox1.Items[iSelecionado];
            btnCadastrar.Text = "Alterar";
        }
    }
}
