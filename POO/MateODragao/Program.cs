using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadornaodesistiu = true;
            do {

                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("        Mate o Dragão!");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - sair do jogo");

                string opcaojogador = Console.ReadLine ();

                switch (opcaojogador) {
                    case "1":
                        Console.Clear ();
                        Guerreiro guerreiro = new Guerreiro ();
                        guerreiro.Nome = "Joelino";
                        guerreiro.Sobrenome = "Shibuia";
                        guerreiro.CidadeNatal = "Hogwart";
                        guerreiro.DataNascimento = DateTime.Parse ("25/12/1450");
                        guerreiro.FerramentaAtaque = "Espadas";
                        guerreiro.FerramentoProtecao = "Armadura";
                        guerreiro.Forca = 2;
                        guerreiro.Destreza = 3;
                        guerreiro.Inteligencia = 3;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "dragonildo";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /* INICIO - Primeiro Diálogo */
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, seu louco! Vim-lhe derrotar-te-lhe!");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: kkk! Humano tolinho. Quem pensas que és?");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        System.Console.ReadLine ();

                        /* FIM - Primeiro Diálogo */

                        /* INICIO - Segundo Diálogo */
                        Console.Clear ();
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! da casa {guerreiro.Sobrenome}, ó criatura morfética!");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Quem? de onde? bom, que seja...fritar-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        System.Console.ReadLine ();
                        /* FIM - segundo Diálogo */
                        Console.Clear ();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNaoCorreu = true;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        /* INICIO da Treta */
                        if (jogadorAtacaPrimeiro) {
                            Console.Clear ();
                            System.Console.WriteLine ("Turno do jogador");
                            System.Console.WriteLine ("Escolha sua Ação:");
                            System.Console.WriteLine ("1 - Atacar");
                            System.Console.WriteLine ("2 - Fugir");

                            string opcaoBatalhajogador = Console.ReadLine ();
                            switch (opcaoBatalhajogador) {
                                case "1":
                                    Random geradorNumeroAleatório = new Random ();
                                    int NumeroAleatórioJogador = geradorNumeroAleatório.Next (0, 5);
                                    int NumeroAleatórioDragao = geradorNumeroAleatório.Next (0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatórioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatórioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: tOMA essa largato nojento!!");
                                        dragao.Vida = dragao.Vida - poderAtaqueGuerreiro + 5; /*OU dragao.Vida -= poderAtaqueGuerreiro + 5 */
                                        System.Console.WriteLine ("--------");
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrrrou, humanóide tosco!");
                                    }
                                    break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fii! FLW VLW!");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:  GG EZ!");
                                    break;
                            }

                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {
                                Console.Clear ();
                                System.Console.WriteLine ("*** Turno do Dragão ***");
                                Random geradorNumeroAleatório = new Random ();
                                int NumeroAleatórioJogador = geradorNumeroAleatório.Next (0, 5);
                                int NumeroAleatórioDragao = geradorNumeroAleatório.Next (0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatórioJogador;
                                int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatórioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: chamuscou o foifó? foi");
                                    guerreiro.Vida -= dragao.Forca; /*OU guerreiro.Vida = guerreiro.Vida - dragao.Forca; */
                                    System.Console.WriteLine ("--------");
                                    System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                } else {
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vem tranquilo, não se afóbe!");
                                }
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();
                                /* INICIO - Turno Jogador */
                                Console.Clear ();
                                System.Console.WriteLine ("Turno do jogador");
                                System.Console.WriteLine ("Escolha sua Ação:");
                                System.Console.WriteLine ("1 - Atacar");
                                System.Console.WriteLine ("2 - Fugir");

                                opcaoBatalhajogador = Console.ReadLine ();
                                switch (opcaoBatalhajogador) {
                                    case "1":
                                        geradorNumeroAleatório = new Random ();
                                        NumeroAleatórioJogador = geradorNumeroAleatório.Next (0, 5);
                                        NumeroAleatórioDragao = geradorNumeroAleatório.Next (0, 5);

                                        guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatórioJogador;
                                        dragaoDestrezaTotal = dragao.Destreza + NumeroAleatórioDragao;

                                        if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: tOMA essa largato nojento!!");
                                            dragao.Vida = dragao.Vida - poderAtaqueGuerreiro + 5; /*OU dragao.Vida -= poderAtaqueGuerreiro + 5 */
                                            System.Console.WriteLine ("--------");
                                            System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                            System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrrrou, humanóide tosco!");
                                        }

                                        if (guerreiro.Vida <= 0){
                                            System.Console.WriteLine("Jogador Morreu!");
                                        }
                                        if (dragao.Vida <= 0){
                                            System.Console.WriteLine("el dragão murio!");                                            
                                        }
                                        System.Console.WriteLine();
                                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                                        Console.ReadLine();
                                        Console.Clear();
                                        

                                        break;
                                    case "2":
                                        jogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fii! FLW VLW!");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:  GG EZ!");
                                        break;
                                }

                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();

                                /* FIM - Turno Jogador */

                            }

                        }
                        /* FIM da Treta */

                        break;
                    case "0":
                        jogadornaodesistiu = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando desconhecido");
                        break;
                }
            } while (jogadornaodesistiu);

        }
    }
}