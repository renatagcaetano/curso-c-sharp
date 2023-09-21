using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar() {
            // double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("nota > 10.0 -> {0}", nota > 10.0);
            Console.WriteLine("nota < 0.0 -> {0}", nota < 0.0);
            Console.WriteLine("nota == 10.0 -> {0}", nota == 10.0);
            Console.WriteLine("nota != 10.0 -> {0}", nota != 10.0);
            Console.WriteLine("nota >= notaDeCorte -> {0}", nota >= notaDeCorte);
            Console.WriteLine("nota < notaDeCorte -> {0}", nota < notaDeCorte);
            Console.WriteLine("nota <= 3.0 -> {0}", nota <= 3.0);
        }
    }
}
