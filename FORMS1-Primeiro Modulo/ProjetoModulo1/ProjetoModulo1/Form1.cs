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
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
        }
        
        private void validate_txtnome(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Length < 1)
            {
                MessageBox.Show("invalid");
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
        }

    }
}
