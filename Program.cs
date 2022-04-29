using System;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sorteio = new Random().Next(1, 5);
            
            int tentativas = 0;
            string resp = "s";
            while (resp == "s")
            {

                Console.WriteLine("************************ JOGO DE ADIVINHAÇÃO **********************************");
                Console.WriteLine();
                Console.WriteLine("Tente adivinhar o número que eu pensei entre 1 e 5: ");
                int chute = int.Parse(Console.ReadLine());

                

                if (sorteio == chute)
                {
                    Console.WriteLine("Pensei em: {0}", sorteio);
                    Console.WriteLine("Parabéns você acertou!!! ");
                    {
                        tentativas++;
                        Console.WriteLine("Você tentou {0} vezes! ", tentativas);
                        Console.WriteLine("Fim do jogo!");
                        break;
                    }
                }

                else
                {
                    if (chute == 1)
                    {
                        Console.WriteLine($"Errou, pensei em :  {sorteio}");
                        Console.WriteLine("Continuar?:  (s/n)");
                        resp = Console.ReadLine();
                        tentativas++;
                        Console.WriteLine("Você tentou {0} vezes! ", tentativas);
                        Console.Clear();

                    }
                    else if (chute == 2)
                    {
                        Console.WriteLine($"Não foi desta vez, eu pensei em :  {sorteio}");
                        Console.WriteLine("Continuar?:  (s/n)");
                        resp = Console.ReadLine();
                       
                    }

                    else if (chute == 3)
                    {
                        Console.WriteLine($"Vamos lá sei que você consegue, mas dessa vez eu pensei em :  {sorteio}");
                        Console.WriteLine("Continuar?:  (s/n)");
                        resp = Console.ReadLine();
                       
                    }
                    else if (chute == 4)
                    {
                        Console.WriteLine($"Por pouco.. eu pensei desta vez em :  {sorteio}");
                        Console.WriteLine("Continuar?:  (s/n)");
                        resp = Console.ReadLine();
                        
                    }

                    else
                    {
                        Console.WriteLine($"Quase... tenta mais uma ai, eu pensei em:  {sorteio}");
                        Console.WriteLine("Continuar?:  (s/n)");
                        resp = Console.ReadLine();
                       
                    }

                    tentativas++;
                    Console.WriteLine("Você tentou {0} vezes! ", tentativas);
                    Console.Clear();
                }


                
                    Console.Clear();
                    Console.WriteLine("Fim do Programa");
                



            }
        }
    }
}