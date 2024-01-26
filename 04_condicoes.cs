// Operadores lógicos simples
Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());
bool maior_10 = numero > 10;
Console.WriteLine("É maior que 10: " + maior_10);
bool menor_10 = numero < 10;
Console.WriteLine("É menor que 10: " + menor_10);
bool igual_10 = numero == 10;
Console.WriteLine("É igual a 10: " + igual_10);

// Testes com string
string senha_sistema = "conradito123";
Console.WriteLine("Digite a senha: ");
string senha_digitada = Console.ReadLine();
bool senha_correta = senha_sistema == senha_digitada;
Console.WriteLine("A senha está correta? " + senha_correta);

// Apresentar problemática de usar os testes lógicos na variável
// Introduzir as estruturas de controle

Console.WriteLine("Digite um número: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("O número é maior do que 10?");
if (n > 10)
{
    Console.WriteLine("Sim, o número é maior do que 10!");
}
if (n < 10)
{
    Console.WriteLine("Não, o número é menor do que 10");
}
if (n == 10)
{
    Console.WriteLine("Nem menor, nem maior. O número é IGUAL a 10");
}

// Mesmo problema da senha:
string s1 = "conradito123";
Console.WriteLine("Digite a senha: ");
string s2 = Console.ReadLine();
if (s1 == s2)
{
    Console.WriteLine("Parabéns, a senha está correta!");
}
else // apresentar a forma de fazer com 2 ifs antes de fazer com o else
{
    Console.WriteLine("Ops, a senha está errada");
}

// ### ATIVIDADE:
// Criar um programa que verifica se um número é negativo ou não
Console.WriteLine("Digite um número: ");
int negativo = int.Parse(Console.ReadLine());
if (negativo < 0)
{
    Console.WriteLine("O número é negativo!");
}
else
{
    Console.WriteLine("Não, o número não é negativo");
}
// Criar um programa que pergunte a idade da pessoa e verifica se ela
// é maior de idade ou não. Se for, emitir a mensagem:
// "Você já pode dirigir"
// Se não for, emitir a mensagem:
// "Você ainda não tem idade para dirigir. Volte daqui X anos".
Console.WriteLine("Digite a sua idade:");
int cnh = int.Parse(Console.ReadLine());
if (cnh >= 18)
{
    Console.WriteLine("Você já pode dirigir.");
    // Proposta de uma segunda parte da atividade:
    int tempo = cnh + 5;
    Console.WriteLine($"Você deve renovar sua carteira quando tiver {tempo} anos");
}
else
{
    int tempo = 18 - cnh;
    Console.WriteLine($"Você ainda não tem idade para dirigir. Volte daqui {tempo} anos.");
}

// ####### ATIVIDADES
/*
    
    1 - Faça um Programa que peça dois números e imprima o maior deles.

    2 - Ler dois valores e escrevê-los em ordem crescente.

    3 - As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se
    forem compradas pelo menos 12. Escreva um programa que leia o número de maçãs
    compradas, calcule e escreva o custo total da compra.

    4 - Faça um programa que leia duas notas de um aluno. Se a média for 7,
    mostre na tela "Aprovado!", se não, mostre "Reprovado!"

*/

// #### PARTE 3: condições aninhadas
Console.WriteLine("Digite um valor entre 1 e 10");
int valor = int.Parse(Console.ReadLine());
if (valor > 10)
{
    Console.WriteLine("Valor inválido, ele é maior que 10");
}
else
{
    if (valor < 1)
    {
        Console.WriteLine("Errado! O valor é menor do que 1");
    }
    else
    {
        Console.WriteLine("Parabéns, valor digitado corretamente!");
    }
}
// Propor atividade para os alunos refazerem esse código, mas de uma forma diferente

// Exemplo do usuário e senha
string u1 = "conradito";
string senha1 = "123456";
Console.WriteLine("Digite o usuário:");
string u2 = Console.ReadLine();
Console.WriteLine("Digite a senha:");
string senha2 = Console.ReadLine();
if (u1 == u2)
{
    if (senha1 == senha2)
    {
        Console.WriteLine("Parabéns, você tem acesso ao sistema!");
    }
    else
    {
        Console.WriteLine("A senha está incorreta");
    }
}
else
{
    Console.WriteLine("Esse usuário não existe");
}

// #### ATIVIDADE:
// Ler 3 valores e escrevê-los em ordem crescente.
// Ler 3 valores e escrever a soma dos 2 maiores.

// #################### PARTE 3: operadores lógicos
Console.WriteLine("Digite um número entre 1 e 10");
int digitado = int.Parse(Console.ReadLine());
if (digitado > 1 && digitado < 10)
{
    Console.WriteLine("O número está correto!");
}
else
{
    Console.WriteLine("Valor incorreto");
}
// Mais exemplos de usuário e senha
if (u1 == u2 && s1 == s2)
{
    Console.WriteLine("Parabéns, você está conectado!");
}
else
{
    Console.WriteLine("Usuário ou senha incorretos!");
}

// #### ATIVIDADE:
/*

    5 Voltar no programa de CNH e sugerir que caso a idade seja
    maior que 65 anos, uma mensagem especial deve ser mostrada

    6 - Faça um programa que pergunte o nome da pessoa e o sexo dela (M ou F).
    Se a pessoa digitar M, escreva "Bem-vindo Sr. X". Se for F, escreva: "Bem-vinda, Sra. X".
    Se a pessoa digitar outra coisa, escreva a mensagem: "Olá, é bom ter você aqui, X!"

    7 - Escreva um programa que recebe um número inteiro e verifica se ele é positivo
    e menor do que 100 ou negativo e maior do que -100. Se for, imprima “O número é válido”,
    caso contrário, imprima “O número não é válido”.

*/