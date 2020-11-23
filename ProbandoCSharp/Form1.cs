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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(this.txtnum1.Text);
            num2 = int.Parse(this.txtnum2.Text);
            int suma = num1 + num2;
            this.lblresultado.Text = "Resultado: " + suma.ToString();
        }
    }
}
