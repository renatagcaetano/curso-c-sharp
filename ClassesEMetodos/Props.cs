using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class CarroOpcional {
        double desconto = 0.1;
        string nome;

        public string Nome {
            get {
                return "Opcional: " + nome;
            }

            set {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto {
            // get => Preco - (desconto * Preco);
            get {
                return Preco - (desconto * Preco);
            }
        }

        public CarroOpcional() { 
        
        }

        public CarroOpcional(string nome, double preco) {
            // this.nome = nome;
            Nome = nome;
            Preco = preco;
        }

    }

    internal class Props {
        public static void Executar() {
            var opcional1 = new CarroOpcional("Ar Condicionado", 3499.9);

            Console.WriteLine(opcional1.PrecoComDesconto);

            var opcional2 = new CarroOpcional();
            opcional2.Nome = "Direção Elétrica";
            opcional2.Preco = 2349.9;

            Console.WriteLine(opcional1.Nome);
            Console.WriteLine(opcional1.Preco);

            Console.WriteLine(opcional2.Nome);
            Console.WriteLine(opcional2.Preco);
            Console.WriteLine(opcional2.PrecoComDesconto);
        }
    }
}
