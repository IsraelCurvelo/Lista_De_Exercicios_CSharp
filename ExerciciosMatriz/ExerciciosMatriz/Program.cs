using System;

namespace ExerciciosMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler uma matriz, linhas e colunas iguais, mostrar diagonal e quantidade de numeros negativos
            Console.WriteLine("Digite um numero (Linhas e colunas serão iguais)");
            
            int qtde = int.Parse(Console.ReadLine());
            int[,] mat = new int[qtde,qtde];

            Console.WriteLine("Digite os valores para a matriz");

            for(int i=0; i< qtde; i++)
            {
                for (int j =0; j < qtde; j++)
                {
                    Console.WriteLine("Linha "+i +", Coluna "+j);
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Numeros na Diagonal");
            int cont = 0;

            for (int i = 0; i < qtde; i++)
            {
                for (int j = 0; j < qtde; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " | ");
                    }

                    if (mat[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("\nNumeros Negativos: " + cont);


            Console.WriteLine("_______________________________________________________");
            //Ler uma matriz, linhas e colunas diferentes, pedir um numero para busca e mostrar os valores acima, abaixo, direita e esquerda.

            Console.WriteLine("Digite o numero de Linhas");
            int nLin = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Numero de Colunas");
            int nCol = int.Parse(Console.ReadLine());
            int[,] matriz = new int[nLin, nCol];

            for (int i =0; i< nLin; i++)
            {
                for (int j =0; j< nCol; j++)
                {
                    Console.WriteLine("Linha " + i + ", Coluna " + j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite um numero para busca");
            int busca = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLin; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    if (matriz[i, j] == busca)
                    {
                        Console.WriteLine("Posição: \nLinha: " + i + ", Coluna: " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Não há valor á esquerda");
                        }

                        if (j < nCol - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Não há valor á direita");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }
                        else
                        {
                            Console.WriteLine("Não há valor acima");
                        }
                        if (i < nLin - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                        else
                        {
                            Console.WriteLine("Não há valor abaixo");
                        }

                    }
                    
                }
            }
        }
    }
}
