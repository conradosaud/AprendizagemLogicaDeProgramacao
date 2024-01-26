// ############# Parte 1: introdução
// Apagar tudo e escrever tudo do zero o primeiro comando:
Console.WriteLine("Olá, mundo!");

// Mais prints para treinar
Console.WriteLine("Meu nome é Conrado");
Console.WriteLine("Estou aprendendo programação");
Console.WriteLine("Essa é a aula número 1 do curso");

// Um print com um código dentro para mostrar que
// o que está dentro das aspas não é interpretado como código
Console.WriteLine("Console.WriteLine é o comando de mostrar mensagens da tela");

// Mostrar também que existe o comando Write
Console.Write("Aprendi o novo comando Write");
// Mais um print para os alunos perceberem o que ele faz:
Console.Write("O que esse comando faz?");
// O próximo comando ainda vai vir na mesma linha
Console.WriteLine("Esse comando ainda vai ficar colado");
Console.WriteLine("Agora esse comando começa na linha de baixo");
// Mostrar que é possível pular um espaço usando o escape \n
Console.WriteLine("Conrado\nSaud");
// Possibilidade de adicionar mais espaços para deixar mais bonito:
Console.WriteLine("\n\nBem-vindo ao Conradito Banks!\n\nEscolha uma opção:\n1 - Saque bancário\n2 - Depósito em conta corrente");

// ############# ATIVIDADE
// # Cupom fiscal (apresentar uma imagem de cupom fiscal)
// Montar o cupom fiscal usando os comandos:
// Write e WriteLine (tem que ter os dois)
// Usar \n se necessário

Console.WriteLine("CONRADITO CHOKITO");
Console.WriteLine("RUA EPISCOPAL N° 770. CENTRO\nSÃO CARLOS - SP");
Console.Write("\n--------------------------------\n");
Console.WriteLine("CUPOM FISCAL");
Console.WriteLine("ITEM   DESC        VALOR");
Console.WriteLine("001    CHOKITO TRADICIONAL    R$ 3,96");
Console.WriteLine("002    CHOKITO ESPECIAL    R$ 5,90");
Console.WriteLine("003    CHOKITO FRITO       R$ 5,63\n");
Console.Write("\n--------------------------------\n");
Console.WriteLine("DINHEIRO R$ 50,00      TOTAL R$ 23,08");
Console.WriteLine("TROCO R$ 16,26");
Console.WriteLine("IMPOSTOS 22,5%   R$ 7,59");
Console.Write("\n--------------------------------\n");
Console.WriteLine("EMISSÃO: 30/02/2099");


// Neste momento, ensinar a adicionar comentários usando apenas //
// Adicionar comentários em cima, em baixo e na frente do código
// Console.WriteLine("Um código comentado não funciona");

// ############# Parte 2: peculiaridades
// Mostrar que não dá para printar algo usando aspas simples (não em C#)
// Console.WriteLine('Opa e ae');
// Mostrar que é possível printar apenas números sem usar as aspas:
Console.WriteLine(5);
// Mostrar que também dá para somar os números
Console.WriteLine(20 + 5);
// Assim como números negativos e números com casas decimais
Console.WriteLine(10.3 - 25.5);
// Não dá para somar dentro das aspas
Console.WriteLine("20+5");