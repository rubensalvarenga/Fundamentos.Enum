using System;

namespace Fundamentos.Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Uso do Enum");


        Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        DiasDaSemana dia = DiasDaSemana.Terça;
        Console.WriteLine($"Dia da semana : {dia}");  // Saída: Terça

        Console.WriteLine("");
        TamanhoCamiseta tamanho = TamanhoCamiseta.Grande;
        Console.WriteLine($"Tamanho da camiseta : {tamanho}");  // Saída: Grande

        Console.WriteLine("");
        TipoVeiculo veiculo = TipoVeiculo.Caminhao;
        Console.WriteLine($"Veículo escolhido : {veiculo}");  // Saída: Moto

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }

        enum DiasDaSemana
        {
            Segunda,
            Terça,
            Quarta,
            Quinta,
            Sexta,
            Sabado,
            Domingo
        }


        enum TamanhoCamiseta
        {
            Pequeno,
            Medio,
            Grande,
            ExtraGrande
        }

        enum TipoVeiculo
        {
            Carro,
            Moto,
            Caminhao,
            Onibus
        }

       


    }


}


