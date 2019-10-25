using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
        int Dis;
        int Temp;
        int Velo;
        double Lt;
        string Abast;
        double Pc1;
        double Pc2;
        double Gast1;
        double Gast2;
        int Ltv1;
        int Ltv2;
        
        System.Console.WriteLine("Digite o tempo em Minutos: ");
        Temp = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a Velocidade Media: ");
        Velo = int.Parse(Console.ReadLine());        

        Dis = (Temp * Velo)/60;
        Lt = Dis /12;

        System.Console.WriteLine($"A Distancia percorrida foi: {Dis}km.");
        System.Console.WriteLine($"A litragem Consumida foi: {Lt}.");

        System.Console.WriteLine("Aperte ENTER para Prosseguir");
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Quantidade de vezes que o automovél foi abastecido: ");
        Abast = (Console.ReadLine());

        switch (Abast){
            case "1":
            System.Console.WriteLine("Preço do combustivel no posto: ");
            Pc1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Litragem total abastecida no veiculo: ");
            Ltv1 = int.Parse (Console.ReadLine());

            Gast1 = Pc1 * Ltv1;
            System.Console.WriteLine($"Você gastou nesta viagem: R${Gast1}");
            
            break;
            case "2":
            System.Console.WriteLine("Preço do combustivel no primeiro posto de gasolina : ");
            Pc1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Litragem total abastecida no veiculo no primeiro abastecimento: ");
            Ltv1 = int.Parse (Console.ReadLine());
            System.Console.WriteLine("Preço do combustivel no segundo posto de gasolina : ");
            Pc2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Litragem total abastecida no veiculo no segundo abastecimento: ");
            Ltv2 = int.Parse (Console.ReadLine());

            Gast1 = Pc1 * Ltv1;
            Gast2 = (Pc2 * Ltv2) + Gast1;

            System.Console.WriteLine($"Você gastou nesta viagem: R${Gast2}");
            break;
        }
        }
    }
}
