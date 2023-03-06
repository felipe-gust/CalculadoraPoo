using System;

namespace CalculadoraPOO
{
    public class Operadores
    {
        public float Valor1 { get; set; }        
        public float Valor2 { get; set; }
        public float Resultado { get; set; }

        public Operadores(){}

        public void Somar()
        {
            Console.Clear();
            Console.WriteLine("** Soma **");
            Dados();
            
            Resultado = Valor1 + Valor2;
            
            Imprimir();
        }

        public void Subtrair()
        {
            Console.Clear();
            Console.WriteLine("** Subtração **");
            Dados();

            Resultado = Valor1 - Valor2;

            Imprimir();
        }

        public void Dividir()
        {
            Console.Clear();
            Console.WriteLine("** Divisão **");
            Dados();

            Resultado = Valor1 / Valor2;

            Imprimir();
        }

        public void Multiplicar()
        {
            Console.Clear();
            Console.WriteLine("** Multiplicação **");
            Dados();

            Resultado = Valor1 * Valor2;

            Imprimir();
        }

        public void Resto()
        {
            Console.Clear();
            Console.WriteLine("** Resto da divisão **");
            Dados();

            Resultado = Valor1 % Valor2;
            
            Imprimir();
        }

        public void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja realizar? Digite uma das opções abaixo: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Resto da divisão");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Somar(); break;
                case 2: Subtrair(); break;
                case 3: Dividir(); break;
                case 4: Multiplicar(); break;
                case 5: Resto(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        public void Dados()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            Valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            Valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
        }

        public void Imprimir()
        {            
            Console.WriteLine($"Resultado: {Resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
