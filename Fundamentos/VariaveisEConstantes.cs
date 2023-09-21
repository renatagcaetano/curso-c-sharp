using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 2.1415;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos internos
            bool estaChovendo = true;
            bool naoEstaChovendo = false;
            Console.WriteLine("Está chovendo " + estaChovendo);

            sbyte menorValorSbyte = sbyte.MinValue;
            sbyte maiorValorSbyte = sbyte.MaxValue;

            byte menorValorByte = byte.MinValue;
            byte maiorValorByte = byte.MaxValue;

            short menorValorShort = short.MinValue;
            short maiorValorShort = short.MaxValue;

            int menorValorInt = int.MinValue;
            int maiorValorInt = int.MaxValue;

            uint menorValorIntSemSinal = uint.MinValue;
            uint maiorValorIntSemSinal = uint.MaxValue;

            long menorValorLong = long.MinValue;
            long maiorValorLong = long.MaxValue;

            ulong menorValorLongSemSinal = ulong.MinValue;
            ulong maiorValorLongSemSinal = ulong.MaxValue;

            float menorValorFloat = float.MinValue;
            float maiorValorFloat = float.MaxValue;
            float valorFloat = 1299.99f; //ou 1299.99F

            double valorMinimoDouble = double.MinValue;
            double valorMaximoDouble = double.MaxValue;

            decimal valorMinimoDecimal = decimal.MinValue;
            decimal valorMaximoDecimal = decimal.MaxValue;

            char letra = 'a';

            string conjuntoDeCaracteres = "Esta é uma string.";
        }
    }
}
