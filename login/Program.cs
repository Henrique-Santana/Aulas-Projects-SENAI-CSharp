using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string Usuario;
            string senha;

            Console.WriteLine("Usuario");
            Usuario = Console.ReadLine();

            Console.WriteLine("Senha");
            senha = Console.ReadLine();

           if ((Usuario =="admin") && (senha =="admin")){
               Console.WriteLine("Bem vindo Administrador");
           } else{
               Console.WriteLine("Bem vindo Usuario");
           }
            
        }
    }
}
