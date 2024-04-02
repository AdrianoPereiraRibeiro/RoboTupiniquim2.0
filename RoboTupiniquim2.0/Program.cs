using System;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            char atual;
            string resposta;       
            for (int j = 0; j < 2; j++)
            {
              
                
                Console.Write("Digite  X do robô:(inicial) ");
               int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite  Y  do robô:(inicial) ");
               int y = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a direção do robô(atual): ");
                atual = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.WriteLine("Digite as instruções para o robô (Ex:MDEMM): ");
                resposta = Console.ReadLine().ToUpper();

                char[] respostachar = resposta.ToCharArray();
                for (int i = 0; i < respostachar.Length; i++)
                {
                    char charrespostas = respostachar[i];
                    switch (charrespostas)
                    {
                        case 'D':
                            switch (atual)
                            {
                                case 'N':
                                    atual = 'L';
                                    break;
                                case 'S':
                                    atual = 'O';
                                    break;
                                case 'L':
                                    atual = 'S';
                                    break;
                                case 'O':
                                    atual = 'N';
                                    break;
                            }
                            break;
                        case 'E':
                            switch (atual)
                            {
                                case 'N':
                                    atual = 'O';
                                    break;
                                case 'S':
                                    atual = 'L';
                                    break;
                                case 'L':
                                    atual = 'N';
                                    break;
                                case 'O':
                                    atual = 'S';
                                    break;
                            }
                            break;
                        case 'M':
                            switch (atual)
                            {
                                case 'N':
                                    y = y + 1;
                                    break;
                                case 'S':
                                    y = y - 1;
                                    break;
                                case 'L':
                                    x = x + 1;
                                    break;
                                case 'O':
                                    x = x - 1;
                                    break;
                            }
                            break;
                    }
                }
                Console.WriteLine("X= "+x + " Y=  " + y + " Posição=  " + atual);
                
                
                
                
                
                
                
                
                Console.ReadLine();
            }
        }
    }
}


