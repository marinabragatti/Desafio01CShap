
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto
{
    class Veiculo
    {
        private String marca { get; set; }
        private String modelo { get; set; }
        private String placa { get; set; }
        private String cor { get; set; }
        private float km { get; set; }
        private Boolean isLigado { get; set; }
        private int litrosCombustivel { get; set; }
        private int velocidade { get; set; }
        private double preco { get; set; }

        //Métodos

        public void ligar()
        {
            if (this.isLigado)
                Console.WriteLine("O carro já está ligado");
            else
            {
                this.isLigado = true;
                Console.WriteLine("Você ligou o carro.");
            }
        }

        public void desligar()
        {
            if (this.isLigado)
            {
                this.isLigado = false;
                Console.WriteLine("Você desligou o carro");
            }
            else
                Console.WriteLine("O carro já está desligado.");
        }

        public void acelerar()
        {
            if (this.isLigado && this.velocidade <= 140 && this.litrosCombustivel > 0)
            {
                this.velocidade += 20;
                this.litrosCombustivel -= 1;
                Console.WriteLine("Você está a " + this.velocidade + "km/h");
                Console.WriteLine("Seu carro tem " + this.litrosCombustivel + " litros de combustível");
            }
            else if(this.isLigado == false)
                Console.WriteLine("Ligue o carro para acelerar");
            else if(this.litrosCombustivel <= 0)
                Console.WriteLine("O carro não tem combustível, abasteça.");
            else
                Console.WriteLine("Você está acima do limite de velocidade, não é possível acelerar mais.");
        }

        public void frear()
        {
            if(this.isLigado && this.velocidade > 0)
            {
                this.velocidade -= 10;
                Console.WriteLine("Seu carro agora está a " + this.velocidade + "km/h");
            }
            else if(this.isLigado == false)
                Console.WriteLine("Seu carro está desligado.");
            else
                Console.WriteLine("Seu carro está parado.");
        }

        public void abastecer(int qtdeLitros)
        {
            if(qtdeLitros <= 0)
                Console.WriteLine("Não é possível abastecer um valor inferior a 1 litro");
            else if(this.isLigado)
                Console.WriteLine("Desligue o carro para abastecer");
            else if(this.velocidade > 0)
                Console.WriteLine("O carro está em movimento, pare o carro para abastecer");
            else if((this.litrosCombustivel + qtdeLitros) > 100)
                Console.WriteLine("Não é possível abastecer, faltam " + (this.velocidade + qtdeLitros - 100) + " para completar o tanque");
            else
            {
                this.litrosCombustivel += qtdeLitros;
                Console.WriteLine("O tanque tem " + this.litrosCombustivel + " litros.");
            }
        }

        public void pintar(String cor)
        {
            this.cor = cor;
            Console.WriteLine("Seu carro agora é " + this.cor);
        }
    }
}
