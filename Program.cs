Console.WriteLine("--- Decomposição Decimal ---\n");

Console.Write("Digite um número inteiro...: ");
int numero = Convert.ToInt32(Console.ReadLine());

int restante = numero;

int unidades = restante % 10;
restante /= 10;

int dezenas = restante % 10;
restante /= 10;

int centenas = restante;

Console.WriteLine($"\nO número {numero} possui:");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"{unidades,10} unidade(s)");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{dezenas,10} dezenas(s)");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{centenas,10} centena(s).");
Console.ResetColor();