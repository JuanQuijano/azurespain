using System;
using System.Collections.Generic;
using System.Text;

namespace NumerosPrimosFunction
{
    public static class Calcula
    {

        public static Resultado TiempoNumeroTotal(int numerosMax)
        {
            var resultado = new Resultado();
            for (int num = 0; num <= numerosMax; num++)
            {
                if (esPrimo(num)){ 
                resultado.ultimoPrimo = num; }
            }
            return resultado;
        }

        private static bool esPrimo(int numero)
        {
            int divisor = 2;
            int resto = 0;
            while (divisor < numero)
            {
                resto = numero % divisor;
                if (resto == 0)
                {
                    return false;
                }
                divisor = divisor + 1;
            }
            return true;
        }
    }
}
