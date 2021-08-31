using System;
using System.Globalization;

namespace UdemyObjetos {
    class Program {
        static void Main(string[] args) {
            int opcao = ImprimirMenu();
            while (opcao != 0) {
                IniciarExercicio(opcao);
                opcao = ImprimirMenu();
            }
        }

        static void Exercicio1() {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre com a largura e a altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(retangulo);
        }

        static void Exercicio2() {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }

        static void Exercicio3() {

            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Entre com as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL: "
                + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO!");
            } else {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM "
                    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS.");

            }
        }

        static int ImprimirMenu() {
            Console.WriteLine("Qual exercício você deseja executar?");
            Console.WriteLine("[1] - Cálculos com Retangulo;");
            Console.WriteLine("[2] - Cálculos com salário de um Funcionario;");
            Console.WriteLine("[3] - Cálculo nota final de um aluno.");

            Console.Write("Digite a opção ou digite 0 para sair do programa: ");
            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

        static void ImprimirTituloExercicio(int numeroExercicio) {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("     Exercício {0}     ", numeroExercicio);
            Console.WriteLine("---------------------");
            Console.WriteLine();
        }


        static void IniciarExercicio(int opcao) {
            switch (opcao) {
                case 1:
                    ImprimirTituloExercicio(opcao);
                    Exercicio1();
                    break;
                case 2:
                    ImprimirTituloExercicio(opcao);
                    Exercicio2();
                    break;
                case 3:
                    ImprimirTituloExercicio(opcao);
                    Exercicio3();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Exercício inexistente.");
                    break;
            }
        }
    }
}
