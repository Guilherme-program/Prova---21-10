// See https://aka.ms/new-console-template for more information
int nota1;
int nota2;
int nota3;
int peso1 = 1;
int peso2 = 2;
int peso3 = 3;
double mediaponderada;
double mediaponderada2;
int media = 7;
Console.WriteLine("Olá, bom dia!\nDigite o valor da nota da sua primeira prova!");
nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da nota da sua segunda prova!");
nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da nota da sua terceira prova!");
nota3 = int.Parse(Console.ReadLine());
mediaponderada = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3));
mediaponderada2 = mediaponderada / (peso1 + peso2 + peso3);
Console.WriteLine($"Sua Média Ponderada foi {mediaponderada2}");
if (mediaponderada2 >= 7)
    Console.WriteLine("Aprovado");
else if (mediaponderada2 >= 5 != < 7)
    Console.WriteLine("Recuperação");
else
    Console.WriteLine("Reprovado");


