using System;

Console.WriteLine("=== Calculadora em C# ===");


Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a operação (+, -, *, /): ");
char operacao = char.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine()!);

double resultado = 0;
bool operacaoValida = true;


switch (operacao)
{
    case '+':
        resultado = num1 + num2;
        break;

    case '-':
        resultado = num1 - num2;
        break;

    case '*':
        resultado = num1 * num2;
        break;

    case '/':
        if (num2 != 0)
        {
            resultado = num1 / num2;
        }
        else
        {
            Console.WriteLine("Erro: Não é possível dividir por zero!");
            operacaoValida = false;
        }
        break;

    default:
        Console.WriteLine("Operação inválida!");
        operacaoValida = false;
        break;
}


if (operacaoValida)
{
    Console.WriteLine($"Resultado: {num1} {operacao} {num2} = {resultado}");
}

Console.WriteLine("\nPressione ENTER para fechar...");
Console.ReadLine();