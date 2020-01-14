using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Veiculo();

            int opcao = 0;
            int qtdeLitros = 0;
            String cor;
            String opcao1;

            do
            {
                Console.WriteLine("\n----------------------MENU-----------------------");
                Console.WriteLine("1 - Ligar");
                Console.WriteLine("2 - Desligar");
                Console.WriteLine("3 - Acelerar");
                Console.WriteLine("4 - Frear");
                Console.WriteLine("5 - Abastecer");
                Console.WriteLine("6 - Pintar");
                Console.WriteLine("7 - Sair");

                Console.WriteLine("Escolha uma opção: ");
                opcao1 = Console.ReadLine();
                opcao = Convert.ToInt32(opcao1);

                switch (opcao)
                {
                    case 1:
                        carro.ligar();
                        break;
                    case 2:
                        carro.desligar();
                        break;
                    case 3:
                        carro.acelerar();
                        break;
                    case 4:
                        carro.frear();
                        break;
                    case 5:
                        {
                            Console.WriteLine("Quantos litros você deseja abastecer? ");
                            if(int.TryParse(Console.ReadLine(), out qtdeLitros))
                                carro.abastecer(qtdeLitros);
                            else
                                Console.WriteLine("Valor inválido. Insira um valor inteiro.");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Qual cor você deseja pintar seu carro? ");
                            cor = Console.ReadLine();
                            carro.pintar(cor);
                            break;
                        }
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != 7);
        }
    }
}
