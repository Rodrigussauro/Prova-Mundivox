using System;    //Espero que gostem do programa, foi o melhor que pude fazer, dentro do prazo que me foi dado. 
                //Me apaixonei por C# e .Net, apesar de nunca ter estudado anteriormente.
                //Com certeza, vou estudar ainda mais para o resto da vida!

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Selecao01, Selecao02, Selecao03, Selecao04, Gol1, Gol2, Gol3, Gol4, GolFinal1, GolFinal2, Finalista01,  Finalista02;
            
            int Gol01 = 0;
            int Gol02 = 0;
            int Gol03 = 0;
            int Gol04 = 0;
            int GolFinal01 = 0;
            int GolFinal02 = 0;

                Console.WriteLine("Eliminatórias da Copa do Mundo do Catar\r\n");
                Console.WriteLine("\r\n SEMI FINAL \r\n");
           
                    Console.WriteLine();
                    Console.WriteLine("[Primeira Chave] Digite o nome da primeira seleção: \r\n");
                    Selecao01 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Digite o nome da segunda seleção: \r\n\r\n");
                    Selecao02 = Console.ReadLine();                        
                    Console.WriteLine();
                    Console.WriteLine();

                        Console.WriteLine("Primeiro Jogo:\r\n");
                        Console.WriteLine(Selecao01 + "    vs    " + Selecao02 + "\r\n\r\n");

                            Console.WriteLine("Quantos gols o " + Selecao01 + " fez?\r\n" +
                                " (Digite o total de gols, considerando também penaltis.)");
                            Gol1 = Console.ReadLine();
                            Gol01 = Convert.ToInt32 (Gol1);
                            Console.WriteLine();
                            Console.WriteLine();
                       
                            Console.WriteLine("Quantos gols o " + Selecao02 + " fez?\r\n" +
                                "(Digite o total de gols, considerando também penaltis.)");
                            Gol2 = Console.ReadLine();
                            Gol02 = Convert.ToInt32(Gol2);
                            Console.WriteLine();
                            Console.WriteLine();


                                Console.WriteLine("Placar 1° Chave: \r\n\r\n" + Selecao01 + " :" + Gol01 + " " +
                                    "\r\n vs \r\n" + Selecao02 + " :" + Gol02);
                            
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    if (Gol01 > Gol02)
                                    {
                                        Finalista01 = Selecao01;
                                        Console.WriteLine(">> " +  Selecao01 + " passa para Final!");


                                    }
                                    else
                                    {
                                        Finalista01 = Selecao02;
                                        Console.WriteLine(">> " + Selecao02 + " passa para Final!");
                                    }
                                    if (Gol01 == Gol02) Console.WriteLine(">> Empates não são aceitos em partidas eliminatórias!" +
                                        "\r\n Tente novamente mais tarde.");




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\r\n\r\n SEMI FINAL ");

                Console.WriteLine();
                Console.WriteLine("[Segunda Chave] Digite o nome da primeira seleção: \r\n");
                Selecao03 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Digite o nome da segunda seleção: \r\n\r\n");
                Selecao04 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                        Console.WriteLine("Primeiro Jogo:\r\n");
                        Console.WriteLine(Selecao03 + "    vs    " + Selecao04 + "\r\n\r\n");

                            Console.WriteLine("Quantos gols o " + Selecao03 + " fez?\r\n" +
                                " (Digite o total de gols, considerando também penaltis.)");
                            Gol3 = Console.ReadLine();
                            Gol03 = Convert.ToInt32(Gol3);
                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine("Quantos gols o " + Selecao04 + " fez?\r\n" +
                                "(Digite o total de gols, considerando também penaltis.)");
                            Gol4 = Console.ReadLine();
                            Gol04 = Convert.ToInt32(Gol4);
                            Console.WriteLine();
                            Console.WriteLine();


                                Console.WriteLine(">> Placar 1° Chave: \r\n\r\n" + Selecao03 + " :" + Gol03 + " " +
                                    "\r\n vs \r\n" + Selecao04 + " :" + Gol04);
                            
            
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    if (Gol03 > Gol04)
                                    {
                                        Finalista02 = Selecao03;
                                        Console.WriteLine(">> " + Selecao03 + " passa para Final!");
                                    }
                                    else
                                    {
                                        Finalista02 = Selecao04;
                                        Console.WriteLine(">> " + Selecao04 + " passa para Final!");
                                    }


                                    if (Gol03 == Gol04) Console.WriteLine(">> Empates não são aceitos em partidas eliminatórias!" +
                                        "\r\n Tente novamente mais tarde.");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\r\n\r\n FINAL ");
            
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(Finalista01 + " vs " + Finalista02);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Quantos gols " + Finalista01 + " fez?\r\n" +
                        "(Digite apenas o número total de gols, considerando também penaltis.)");
                    GolFinal1 = Console.ReadLine();
                    GolFinal01 = Convert.ToInt32(GolFinal1);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Quantos gols " + Finalista02 + " fez?\r\n" +
                        "(Digite o total de gols, considerando também penaltis.)");
                    GolFinal2 = Console.ReadLine();
                    GolFinal02 = Convert.ToInt32(GolFinal2);
                    Console.WriteLine();
                    Console.WriteLine();
            
                        Console.WriteLine("PLACAR DA FINAL:  \r\n\r\n" + Finalista01 + " :" + GolFinal01 + " " +
                                            "\r\n vs \r\n" + Finalista02 + " :" + GolFinal02);
                        Console.WriteLine();
                        Console.WriteLine();

                            if (GolFinal01 > GolFinal02)
                            {
                                Console.WriteLine(">> " + Finalista01 + " VENCEU A COPA DO MUNDO DO CATAR!");
                            }
                            else
                            {
                                Console.WriteLine(">> " + Finalista02 + " VENCEU A COPA DO MUNDO DO CATAR!");
                            }


                            if (GolFinal01 == GolFinal02) Console.WriteLine(">> Empates não são aceitos em partidas eliminatórias!" +
                                "\r\n Tente novamente mais tarde.");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" **Feito em 28/11/2019 após 2 longos dias estudando C# .NET pela primeira vez na vida.**\r\n" +
                " ***Todos os direitos reservados a Rodrigo Mendes Antonio (AKA.: Rodrigussauro)***");

        }
	}
}
