using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class UsandoDelegates {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }

        public static void Executar() {
            Soma operacao1 = MinhaSoma;
            Console.WriteLine(operacao1(2, 3.9));

            ImprimirSoma operacao2 = MeuImprimirSoma;
            operacao2(5.4, 8);

            Func<double, double, double> operacao3 = MinhaSoma;
            Console.WriteLine(operacao3(2.5, 3));

            Action<double, double> operacao4 = MeuImprimirSoma;
            operacao4(7.7, 23.4);
        }
    }
}
