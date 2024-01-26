float lanche = 8.00f;
        
float salsicha = 1.50f;
float hamburger = 2.00f;
float requeijao = 1.50f;
float bacon = 2.00f;

float cachorro_quente_cremoso = lanche + salsicha + salsicha + requeijao;
float xtudo = lanche + hamburger + bacon + salsicha;
float a_moda = lanche + salsicha + hamburger + requeijao + bacon;

float combo = cachorro_quente_cremoso + xtudo + a_moda;

Console.WriteLine ("Cardápio do Conradito Chokito");
Console.WriteLine ("Valores:");
Console.WriteLine("X-Tudo: hamburger, banco e salsicha - R$ "+xtudo);
Console.WriteLine("Cachorro-quente cremoso: 2 salsichas e requeijao - R$ " + cachorro_quente_cremoso);
Console.WriteLine("A moda da casa: salsicha, hamburger, requeijao e bacon - R$ "+ a_moda );

Console.WriteLine("\n");
Console.WriteLine("COMBO: X-Tudo + Cachorro-quente cremoso + A moda da casa - R$ "+combo);