using System;

namespace matr {
    class Program {
        static void Main (string[] args) {

      int[]  dados  =  new int[6];
      int pares = 0;
      int impares = 0;
      
      for(int cont = 0; cont<=5; cont++){ 
        Console.Write("digite um número");
        dados[cont] = int.Parse(Console.ReadLine());

      }
      /*foreach ""para cada"" -- "cada elemento que tiver dentro do vetor'dados' sera armazenado dentro  do num" */
      foreach (int num in dados){
        if(num%2 ==0){
          pares +=1;
          /*ou
          pares = pares + 1; ou pares++; */
        }
        else {
          impares++;
        }
      }
      


      Console.WriteLine($"Você tem {pares} numeros pares e {impares} números impares");

    }
  }
}
    
