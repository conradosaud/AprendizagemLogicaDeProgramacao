// ############# Parte 1: Variáveis

// Tipos de variáveis:
string nome = "Conrado";
string endereco = "Rua Episcopal"; // lembrar dos nomes sem acentos
string estado_civil = "solteiro";
string bio = "Sou programador e professor no Senac";

int idade = 15;
int ano_nascimento = 1995;
int matricula = 511;

float altura = 1.75f;
float temperatura = 22.5f;
float preco = 49.99f;

bool esta_chovendo = false;
bool curso_concluido = true;
bool ativo = true;

// ############# ATIVIDADE
// Você está criando um sistema para vender para bancos.
// Você deve criar uma ficha com as informações do usuário.
// Seu cliente ordenou que você criasse uma ficha que contesse:
// Nome completo, idade, CPF, endereço, telefone, data de nascimento, saldo inicial da conta
// Além disso, o cliente lhe informou que todos os usuários começam com o cartão de débito ATIVO
// O cartão de crédito, a princípio, começa INATIVO, mas com o limite inicial de R$ 550.99

string nome_completo = "Conrado dos Santos Alves Saud";
int idade2 = 15;
string cpf = "422.840.338-88";
string endereco2 = "Rua X";
string telefone = "(16) 9 9173-3578";
string data_nascimento = "14/10/1995";
float saldo_inicial = 150.50f;
bool cartao_credito = false;
bool cartao_debito = true;
float limite_inicial = 550.99f;

// ############# Parte 2: Mostras variáveis no print

// Mostrar uma variável sozinha
Console.WriteLine(nome_completo);
Console.WriteLine(saldo_inicial);
Console.WriteLine(cartao_credito);

// Mostrar variável com texto
Console.WriteLine("Meu nome é: " + nome_completo);
Console.WriteLine("Moro em " + endereco);
// Mostrar possibilidades e aguardar até algum aluno chegar nessa conclusão:
Console.Write("Eu tenho ");
Console.Write(idade);
Console.Write(" anos");
// Concatenação
Console.WriteLine("Eu tenho " + idade + " anos");
Console.WriteLine("Eu tenho R$ " + saldo_inicial + " de saldo inicial");
Console.WriteLine("Minha conta tem de R$ "+limite_inicial+" limite no crédito");
// Desafio:
Console.WriteLine("Eu tenho "+idade+" anos e nasci em "+ data_nascimento);
Console.WriteLine("Meu nome é "+nome+" e eu tenho " + idade + " anos e nasci em " + data_nascimento);
// Interpolação
Console.WriteLine($"Eu tenho {idade} anos e nasci em {data_nascimento}");

// ############# Parte 3: operações aritiméticas
// operações básicas
int soma = 5 + 5;
int subtracao = 5 - 10;
int multiplicacao = 5 * 10;
int divisao = 5 / 10;
// somar variáveis
int numero1 = 5;
int numero2 = 10;
int soma2 = numero1 + numero2;
// exemplo prático
float aluguel = 800.00f;
float condominio = 220.50f;
float contas = aluguel + condominio;
float iptu = 150.90f;
float total_contas = contas + iptu;
// ####### ATIVIDADE:
int nota1 = 8;
int nota2 = 9;
int media = (nota1 + nota2) / 2; // deixar os alunos resolverem
// ####### ATIVIDADE:
string produto_nome = "Calça Jeans";
float produto_preco = 99.90f;
float desconto_a_vista = 0.05f; // porcentagem
// Deixar os alunos fazerem sozinhos daqui para baixo
float preco_desconto = produto_preco - produto_preco * desconto_a_vista;
Console.WriteLine($"O produto {produto_nome} custa R$ {produto_preco} a prazo e R$ {preco_desconto} à vista");

// #### ATIVIDADE:
// Uma criança tem 5 anos, 2 meses e 15 dias de vida.
// Considerando um ano de 365 dias e todos os meses do ano com 30 dias
// Quantos dias essa criança já viveu em sua vida?

