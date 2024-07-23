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

// Fazer o exerício do slide 10


