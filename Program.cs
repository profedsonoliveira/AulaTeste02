void operadoresLogicos()
{
    int a = 10, b = 20;
    Console.WriteLine($"a = {a} | b = {b}");
    Console.WriteLine("> {0}", a > b);
    Console.WriteLine("< {0}", a < b);
    Console.WriteLine("== {0}", a == b);
    Console.WriteLine("!= {0}", a != b);
    Console.WriteLine("<= {0}", a <= b);
    Console.WriteLine(">= {0}", a >= b);
}

void desvioCondicionalSimples()
{ 
    // desvio condicional simples: 
    int numero;
    Console.Write("Numero: ");
    numero = Convert.ToInt16(Console.ReadLine());
    if (numero < 0 )
    {
        numero = numero * -1;
    }
    Console.WriteLine($"Número: {numero}");
}

// ****** Fazer o exerício do slide 10

// Desvio condicional composto
// EXEMPLO: Uma loja de roupa decide dar um desconto de 10 reais para as compras até 100
// reais e 20 reais para as compras acima de 100 reais. Faça um programa que peça ao
// usuário o valor da compra e exiba o valor da compra original e a com desconto

