using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        List<int> Caja = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        /// Escribir una función recursiva que devuelva los primeros N númerospares
        private int Pares(int num, List<int> lista)
        {
            if( num > 1 )
            {
                if( num % 2 == 0)
                {
                    lista.Add(num);
                    return Pares(num - 2, lista);
                }
                else
                {
                    return Pares(num - 1, lista);
                }
            }
            else
            {
                return 0;
            }
        }

        private void BTN_Comenzar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TX_1.Text))
            {
                if (Int32.TryParse(TX_1.Text, out int num))
                {

                    Pares(num, Caja);

                    // Agrega los números pares a la lista LT_1
                    foreach (int par in Caja)
                    {
                        LT_1.Items.Add(par.ToString());
                    }
                }
            }
        }
    }
}
