using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raiz
{
   public class Raiz
   {

        private double numero;

        public void setNumero(double total)
        {
            this.numero = total;
        }

        public double getNumero()
        {
            return this.numero;
        }

        public double calcularRaiz()
        {
            return Math.Sqrt(this.getNumero());
        }
   }
}
