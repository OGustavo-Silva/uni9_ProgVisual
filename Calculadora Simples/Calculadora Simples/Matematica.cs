using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Simples
{
    class Matematica
    {
        float a, b;

        public Matematica(String v1, String v2)
        {
            try
            {
                a = float.Parse(v1);
                b = float.Parse(v2);
            }
            catch
            {
                throw new Exception("Erro!");
            }

        }

        public float soma()
        {
            return a + b;
        }

        public float subtracao()
        {
            return a - b;
        }

        public float multiplicacao()
        {
            return a * b;
        }

        public float divisao()
        {
            if (b != 0)

                return a / b;

            else

                return float.NaN;


        }
    }
}
