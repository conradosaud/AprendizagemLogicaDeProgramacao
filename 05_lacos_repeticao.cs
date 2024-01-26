// ########### LA�OS DE REPETI��O: parte 1

// Mostrar a problem�tica
Console.WriteLine("Vamos contar: 1");
Console.WriteLine("Vamos contar: 2");
Console.WriteLine("Vamos contar: 3");
Console.WriteLine("Vamos contar: 4");
Console.WriteLine("Vamos contar: 5");
// Falar sobre mudar algo e o custo disso 5x, como trocar "Vamos" por "Bora"

// Outro problema:
Console.WriteLine("Digite o n�mero 1:");
int numero = int.Parse(Console.ReadLine());
if (numero == 1)
{
    Console.WriteLine("Parab�ns, voc� digitou o n�mero 1!");
}
else
{
    Console.WriteLine("Digite o n�mero 1:");
    int numero = int.Parse(Console.ReadLine());
    if (numero == 1)
    {
        Console.WriteLine("Parab�ns, voc� digitou o n�mero 1!");
    }
    else
    {
        Console.WriteLine("Digite o n�mero 1:");
        int numero = int.Parse(Console.ReadLine());
        if (numero == 1)
        {
            Console.WriteLine("Parab�ns, voc� digitou o n�mero 1!");
        }
        else
        {
            Console.WriteLine("Digite o n�mero 1:");
            int numero = int.Parse(Console.ReadLine());
        }
    }
}

// La�os de repeti��o com WHILE
int contador = 0;
while (contador < 5)
{
    Console.WriteLine("Ol�");
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
// 1 - Fazer um loop at� 25
// 2 - Fazer um loop infinito, mostrando quantas vezes o loop se repetiu
// 3 - Fazer um loop que mostre de 1 at� 5 (inv�s de 0 at� 4)
// 4 - Fazer um loop que mostre os n�meros de 8 at� 14
// 5 - Fazer um loop de 0 at� 5, mas que nunca mostre o n�mero 3 na tela
// 6 - Fazer um loop de 0 at� 10, mas que mostre somente os n�mero 5,6 e 7

// 7 - Loop de 0 a 10, que mostre "In�cio do loop" no come�o, e "Fim do loop" quando ele
// terminar. O loop deve mostrar apenas os n�mero 2,3, 8, 9 e 10.
// N�vel 1 - de boa = usar 4 ou mais IFs
// N�vel 2 - hardcore = usar 2 ou 3 IFs
// N�vel 3 - mestre supremo das gal�xias = usar 1 IF
// Sem usar IFs s� � poss�vel com listas
int c3 = 0;
// Console.WriteLine("In�cio do loop");
while (c3 <= 10)
{
    if (c3 == 2 || c3 == 3 || c3 > 8)
        Console.WriteLine("Encontrei o " + c3);
}
// Console.WriteLine("Fim do loop");

// Resolvendo outra problem�tica
bool resolvido = false;
while (resolvido == false)
{
    Console.WriteLine("Digite o n�mero 1:");
    int nubero = int.Parse(Console.ReadLine());
    if (nubero == 1)
    {
        Console.WriteLine("Parab�ns, voc� digitou o n�mero 1!");
        resolvido = true;
        // Mostrar que o return tamb�m pode funcionar aqui
    }
}

// Desenvolver um jogo que a pessoa deve adivinhar de 1 at� 1000
// se o jogador escolher um n�mero mais alto, o programa deve dizer "menor"
// se o jogador escolher um n�mero mais baixo, o programa deve dizer "maior"
// o jogo se repete at� o jogadora certar o n�mero

// ########## ATIVIDADES:
// 1 - O usu�rio informa o n�mero e o programa d� a tabuada completa.
// 2 - Escreva um programa que calcule a soma dos n�meros de 1 a 100 usando
// 3 - Escreva um programa que conte e mostre na mensagem os n�mero de 100 at� 0
// 4 - Escreva um programa que mostre a m�dia dos n�meros entre 1 e 7 

// ############## PARTE 2: la�o FOR
for (int cont = 0; cont < 10; cont++)
{
    Console.WriteLine("Usando o la�o FOR " + cont);
}

// ########## ATIVIDADES:
// 1 - Fa�a um programa que leia 5 n�meros e mostre a soma deles
// 2 - Fa�a um programa que leia 6 n�meros e informe o maior n�mero
// 3 - Fa�a um programa que leia 6 n�meros e informe o primeiro maior e o segundo maior n�mero
// 4 - Fa�a um programa que leia dois n�meros, em seguida,
//      imprima todos os n�meros que est�o no intervalo entre eles
