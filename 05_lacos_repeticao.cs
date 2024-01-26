// ########### LAÇOS DE REPETIÇÃO: parte 1

// Mostrar a problemática
Console.WriteLine("Vamos contar: 1");
Console.WriteLine("Vamos contar: 2");
Console.WriteLine("Vamos contar: 3");
Console.WriteLine("Vamos contar: 4");
Console.WriteLine("Vamos contar: 5");
// Falar sobre mudar algo e o custo disso 5x, como trocar "Vamos" por "Bora"

// Outro problema:
Console.WriteLine("Digite o número 1:");
int numero = int.Parse(Console.ReadLine());
if (numero == 1)
{
    Console.WriteLine("Parabéns, você digitou o número 1!");
}
else
{
    Console.WriteLine("Digite o número 1:");
    int numero = int.Parse(Console.ReadLine());
    if (numero == 1)
    {
        Console.WriteLine("Parabéns, você digitou o número 1!");
    }
    else
    {
        Console.WriteLine("Digite o número 1:");
        int numero = int.Parse(Console.ReadLine());
        if (numero == 1)
        {
            Console.WriteLine("Parabéns, você digitou o número 1!");
        }
        else
        {
            Console.WriteLine("Digite o número 1:");
            int numero = int.Parse(Console.ReadLine());
        }
    }
}

// Laços de repetição com WHILE
int contador = 0;
while (contador < 5)
{
    Console.WriteLine("Olá");
    contador++;
}
// Loops infinitos
/*
while( 10 > 2)
{
    Console.WriteLine("Infinitoooo");
}
*/
// Resolvendo o primeiro problema
int contador2 = 0;
while (contador2 < 5)
{
    Console.WriteLine("Vamos contar: " + contador2);
    contador2++;
}
// ### ATIVIDADE:
// 1 - Fazer um loop até 25
// 2 - Fazer um loop infinito, mostrando quantas vezes o loop se repetiu
// 3 - Fazer um loop que mostre de 1 até 5 (invés de 0 até 4)
// 4 - Fazer um loop que mostre os números de 8 até 14
// 5 - Fazer um loop de 0 até 5, mas que nunca mostre o número 3 na tela
// 6 - Fazer um loop de 0 até 10, mas que mostre somente os número 5,6 e 7

// 7 - Loop de 0 a 10, que mostre "Início do loop" no começo, e "Fim do loop" quando ele
// terminar. O loop deve mostrar apenas os número 2,3, 8, 9 e 10.
// Nível 1 - de boa = usar 4 ou mais IFs
// Nível 2 - hardcore = usar 2 ou 3 IFs
// Nível 3 - mestre supremo das galáxias = usar 1 IF
// Sem usar IFs só é possível com listas
int c3 = 0;
// Console.WriteLine("Início do loop");
while (c3 <= 10)
{
    if (c3 == 2 || c3 == 3 || c3 > 8)
        Console.WriteLine("Encontrei o " + c3);
}
// Console.WriteLine("Fim do loop");

// Resolvendo outra problemática
bool resolvido = false;
while (resolvido == false)
{
    Console.WriteLine("Digite o número 1:");
    int nubero = int.Parse(Console.ReadLine());
    if (nubero == 1)
    {
        Console.WriteLine("Parabéns, você digitou o número 1!");
        resolvido = true;
        // Mostrar que o return também pode funcionar aqui
    }
}

// Desenvolver um jogo que a pessoa deve adivinhar de 1 até 1000
// se o jogador escolher um número mais alto, o programa deve dizer "menor"
// se o jogador escolher um número mais baixo, o programa deve dizer "maior"
// o jogo se repete até o jogadora certar o número

// ########## ATIVIDADES:
// 1 - O usuário informa o número e o programa dá a tabuada completa.
// 2 - Escreva um programa que calcule a soma dos números de 1 a 100 usando
// 3 - Escreva um programa que conte e mostre na mensagem os número de 100 até 0
// 4 - Escreva um programa que mostre a média dos números entre 1 e 7 

// ############## PARTE 2: laço FOR
for (int cont = 0; cont < 10; cont++)
{
    Console.WriteLine("Usando o laço FOR " + cont);
}

// ########## ATIVIDADES:
// 1 - Faça um programa que leia 5 números e mostre a soma deles
// 2 - Faça um programa que leia 6 números e informe o maior número
// 3 - Faça um programa que leia 6 números e informe o primeiro maior e o segundo maior número
// 4 - Faça um programa que leia dois números, em seguida,
//      imprima todos os números que estão no intervalo entre eles
