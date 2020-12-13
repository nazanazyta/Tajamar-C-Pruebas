using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbandoCSharp
{
    public partial class Form2_30_11_2020__0_26 : Form
    {
        List<TextBox> cajas;

        public Form2_30_11_2020__0_26()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            this.btnmostrartabla.Click += MostrarTabla;
            foreach (Control control in this.groupBox1.Controls)
            {
                this.cajas.Add((TextBox)control);
            }
        }

        private void MostrarTabla(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtnumero.Text);
            for (int i = 1; i <= this.cajas.Count; i++)
            {
                int multi = numero * (i);
                this.cajas[this.cajas.Count - i].Text = multi.ToString();
            }
            this.txtnumero.SelectAll();
            this.txtnumero.Focus();
        }
    }
}
