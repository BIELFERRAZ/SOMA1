int Número1 , Número2 , soma ;

Console.Write("SOMA:\n");

Console.Write("Digite o Primeiro Número:\n");
Número1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o Segundo Número:\n");
Número2 = Convert.ToInt32(Console.ReadLine());

soma = Número1 + Número2;


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"{soma}"!);
Console.ResetColor();
