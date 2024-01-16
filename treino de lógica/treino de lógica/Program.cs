using System.Collections.Generic;
using System;
using System.ComponentModel;








Menu();






void Atividade1()
{
    Console.Clear();
    Console.WriteLine("Você digitará 3 numeros, os 2 primeiros serão somados e o terceiro será comparado o resultado");
    Console.WriteLine("Digite o primeiro valor");
    int A = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor");
    int B = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o terceiro valor");
    int C = Convert.ToInt32(Console.ReadLine());


    int ResultadoSoma = A + B;
    Console.WriteLine("O resultado da soma entre o primeiro e segundo valor é --> "+ResultadoSoma);


    if (ResultadoSoma < C)
    {
        Console.WriteLine(" o resultado da soma é menor que o terceiro valor digitado ("+C+")");
    }
    else if(ResultadoSoma == C)
    {
        Console.WriteLine("A soma e o terceiro valor são iguais");
    }
    else 
    {
        Console.WriteLine("o resultado da soma é maior que o terceiro valor digitado ("+C+")");
    }
    Console.WriteLine("Aperte enter para voltar ao Menu Principal");
    Console.ReadKey();
    Menu();

}

void Atividade2()
{
    Console.Clear();
    List<int> Numeros = new List<int>();

    Console.WriteLine("Digite alguns valores e será dito o maior e o menor (digite -1 executar e para sair):");

    while (true)
    {
        string input = Console.ReadLine();
        int valor = Convert.ToInt32(input);

        if (valor == -1)
            break;

        Numeros.Add(valor);
    }

    Console.WriteLine("Valores na lista:");

    foreach (int item in Numeros)
    {
        Console.WriteLine(item+ " ");
    }
    int MaiorValorLista = Numeros.Max();
    Console.WriteLine("O maior valor da lista é ("+MaiorValorLista+")");
     MaiorValorLista = Numeros.Min();
    Console.WriteLine("O menor valor da lista é (" + MaiorValorLista + ")");
    Console.WriteLine("Aperte enter para retornar ao Menu Principal");
    Console.ReadKey();
    Menu();

}

void Atividade3()
{
    Console.Clear();
    List<int> Numeros = new List<int>();

    Console.WriteLine("Digite os valores em  (digite -1 para sair):");

    while (true)
    {
        string input = Console.ReadLine();
        int valor = Convert.ToInt32(input);

        if (valor == -1)
            break;

        Numeros.Add(valor);
    }

    Console.WriteLine("Valores da lista ordenados:");
     Numeros.Sort();
    foreach (int item in Numeros)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine("Aperte enter para retornar ao Menu Principal");
    Console.ReadKey();
    Menu();
}

void Atividade4()
{
    Console.Clear();

        Random random = new Random();
        int NumeroAleatorio = random.Next(1, 6);
        int NumeroDigitado;
        int Tentativas = 3;
        Console.WriteLine("Digite um número situado entre 1 e 6, se adivinhar, você ganha");
    for (int Contador = 0; Contador < Tentativas; Contador++)
    {
        NumeroDigitado = Convert.ToInt32(Console.ReadLine());
        if (NumeroAleatorio == NumeroDigitado)
        {
            Console.WriteLine("Você ganhou");
            break;
        }
        else
        {
            Console.WriteLine("Você errou, ");
            if (Contador < Tentativas - 1)
            {
                Console.WriteLine($"Tentativas restantes: {Tentativas - Contador - 1}. Tente novamente.");
            }
        }
    }
    Console.WriteLine("Aperte enter para retornar ao Menu Principal");
    Console.ReadKey();
    Menu();
}
void Atividade5()
{
    Console.Clear();
    Console.WriteLine("Digite uma sequência de números separados por espaço:");
    string input = Console.ReadLine();

    // Dividir a entrada do usuário em números individuais
    int[] numerosDigitados = input.Split(' ').Select(int.Parse).ToArray();

    // Encontrar o número que está faltando
    int numeroFaltando = EncontrarNumeroFaltando(numerosDigitados);

    Console.WriteLine($"O número ausente na sequência é: {numeroFaltando}");


static int EncontrarNumeroFaltando(int[] numeros)
{
    int n = numeros.Length + 1; // Tamanho original da lista + 1 para incluir o número faltando
    int somaEsperada = (n * (n + 1)) / 2;
    int somaReal = numeros.Sum(); // Calcula a soma dos números digitados

    int numeroFaltando = somaEsperada - somaReal;
    return numeroFaltando;
}
    Console.WriteLine("Aperte enter para retornar ao Menu Principal");
    Console.ReadKey();
    Menu();
}

void Atividade6()
{
    Console.Clear();
    Console.WriteLine("digite uma palavra e será dito quantas letras ela tem");
    string Caracteres = Convert.ToString(Console.ReadLine());
    int quantidadeCaracteres = Caracteres.Length;
    Console.WriteLine($"a quantidade de caracteres digitados é {quantidadeCaracteres}");
    Console.WriteLine("Aperte enter para retornar ao Menu Principal");
    Console.ReadKey();
    Menu();
}

void Menu()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    string arte1 = @"                                                                                    
                  ,---------------------------,                                ############ 
                  |  /---------------------\  |                              ########++########
                  | |                       | |                            ####            ###### 
                  | |     Projetos          | |                          ####                  ####  
                  | |      Pessoais         | |                        ####                    #### 
                  | |       -Arthur         | |                        ####   Pesquisando        ##               
                  | |                       | |                        ####         e            #### 
                  |  \_____________________/  |                        ##++   aprendendo         ####  
                  |___________________________|                        ####                      ##  
                ,---\_____     []     _______/------,                  ####                    ####
              /         /______________\           /|                    ####                  #### 
            /___________________________________ /  | ___                ####                #### 
            |                                   |   |    )                 ######        ############ 
            |  _ _ _                 [-------]  |   |   (                    ################  ########  
            |  o o o                 [-------]  |  /    _)_                        ####        ########## 
            |__________________________________ |/     /  /                                      ########## 
        /-------------------------------------/|      ( )/                                         ########## 
      /-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/ /                                                      ##########   
    /-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/ /                                                          ##########   
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~                                                              ########
                                                                                                          ###### 
  ";

    Console.WriteLine(arte1);
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Digite o número correspondente para acessar o algoritmo que deseja");
    Console.ResetColor();
    Console.WriteLine(@" 
(1) Soma valor A e B e verifica se é maior ou menor que o C      (5) Exibe qual número falta em uma sequência crescente
(2) Uma lista recebe valores e diz qual é o maior e o menor      (6) Conta quantos caracteres tem na string       
(3) Uma lista recebe valores que serão ordenados crescentemente
(4) Você tentará 3 vezes adivinhar um número situado entre 1 e 6
");
   
    int Escolha = Convert.ToInt32(Console.ReadLine());




    switch (Escolha)
    {
        case 1:
            Atividade1();
            break;
        case 2:
            Atividade2();
            break;
        case 3:
            Atividade3();
            break;
        case 4:
            Atividade4();
            break;
            case 5:
            Atividade5();
            break;
            case 6:
            Atividade6();
            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Você não digitou nenhum dos números solicitados");
            Console.WriteLine("Retornando ao Menu Principal...");
            Thread.Sleep(3000);
            Menu();
            break;

    }
}