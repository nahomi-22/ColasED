using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//en la parte de using System; se pone esta línea para poder usar los MessageBox.Show("");

namespace ColasED
{
    internal class colas
    {
        private int frente;
        private int atras;
        private int[] lacola;
        private int maximo;

        public colas() { }
        public colas(int max)
        {
            frente = -1;
            atras = -1;
            maximo = max;
            lacola = new int[maximo];
        }

        public Boolean cola_llena()
        {
            if (atras == maximo - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean cola_vacia()
        {
            if (frente == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void agregar_cola(int n)
        {
            if (cola_llena() == true)
            {
                MessageBox.Show("Cola llena");
            }
            else
            {
                atras++;
                lacola[atras] = n;
                if (atras == 0)
                {
                    frente = 0;
                }
            }
        }

        public int del_cola()
        {
            int n = -666;
            if (cola_vacia() == true)
            {
                MessageBox.Show("Cola vacia");
            }

            else
            {
                n = lacola[frente];
                if (frente == atras)
                {
                    frente = -1;
                    atras = -1;
                }
                else
                {
                    frente++;
                }
            }
            return n;
        }

    }
}
