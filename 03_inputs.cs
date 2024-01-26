// ############# Parte 1: Input de dados

Console.WriteLine("Digite seu nome: ");
Console.ReadLine();
// Salientar que sozinho, o ReadLine não funciona, precisamos armazenar
// o valor inserido pelo usuário em algum lugar... em uma variável

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá, seja bem-vindo, {nome}");

Console.WriteLine("Bem-vindo ao sistema de estoque do Conradito's Modas");
Console.WriteLine("-- CADASTRO DE PRODUTOS --");
Console.WriteLine("Insira o nome do produto:");
string nome_produto =  Console.ReadLine();
Console.WriteLine("Tamanho do produto (P, M ou G):");
string tamanho_produto = Console.ReadLine();
Console.WriteLine("Insira a cor do produto:");
string cor_produto = Console.ReadLine();
Console.WriteLine("Produto cadastrado com sucesso!");
Console.WriteLine("-- LISTAGEM DE PRODUTO --");
Console.WriteLine($"Produto: {nome_produto}, no tamanho {tamanho_produto} e cor {cor_produto}");

// Falar sobre números no ReadLine
Console.WriteLine("Digite sua idade: ");
string idade = Console.ReadLine();
// Pedir para os alunos acrescentarem na atividade anterior, a quantidade em estoque do produto

// ############# Parte 2: Conversão de tipos
// apresentar a problemática
Console.WriteLine("Digite um número: ");
string numero1 =  Console.ReadLine();
Console.WriteLine("Digite outro número: ");
string numero2 = Console.ReadLine();
string soma = numero1 + numero2;
// fazer a correção e apresentar a solução
Console.WriteLine("Digite um número: ");
int n1 = int.Parse( Console.ReadLine() );
Console.WriteLine("Digite outro número: ");
int n2 = int.Parse( Console.ReadLine() );
int soma1 = n1 + n2;
Console.WriteLine($"O resultado da SOMA é: {soma1}");
// ##### ATIVIDADE
// Mostrar uma mensagem informando:
// - o resultado da subtração
// - o resultado da divisão
// - o resultado da multiplicação
// - quanto é a média desses números
// - qual é o quadrado da soma desses números
// - quanto que é 10% da soma dos números
// - faça o resultado da conta ser zero

// Faça um algoritmo que receba um valor A e B,
// e troque o valor de A por B e o valor de B por A e imprima na tela os valores.