//Solucion 1.1

Console.WriteLine("Ingrese un número:");
int limite = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1;

var c = 0;


for (int i = 2; i <= limite; i++)
{
    c = a + b;
    a = b;
    b = c;
}
Console.WriteLine($"F{limite} = {c}");


//Solucion 1.2

List<int> numeros = new List<int>();

Console.WriteLine("Ingrese un número:");
int limite2 = Convert.ToInt32(Console.ReadLine());

int a2 = 0, b2 = 1;

var c2 = 0;

for (int i = 2; i < limite2; i++)
{
    c2 = a2 + b2;
    numeros.Add(c2);
    a2 = b2;
    b2 = c2;
}

if (numeros.Contains(limite2))
{
    Console.WriteLine($"El numero {limite2} es Fibonacci.");
}
else{
    Console.WriteLine($"El numero {limite2} no es Fibonacci.");
}


//Solucion 1.3

Console.WriteLine("Ingrese un número:");
int limite3 = Convert.ToInt32(Console.ReadLine());

int a1 = 0, b1 = 1;

var c1 = 0;
Console.WriteLine($"Los {limite3} primeros numeros de Fibonnaci son: ");
Console.Write($"{a1} {b1} ");

for (int i = 2; i < limite3; i++)
{
    c1 = a1 + b1;
    Console.Write($"{c1} ");
    a1 = b1;
    b1 = c1;
}
