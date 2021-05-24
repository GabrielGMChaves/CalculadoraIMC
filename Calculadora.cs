using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Querido(a), POR FAVOR, escreva seu peso.");
		double peso = double.Parse(Console.ReadLine());
		Console.WriteLine("Querido(a), POR FAVOR, escreva sua altura.");
		double altura = double.Parse(Console.ReadLine());
		double IMC = peso / (altura * altura);
		if (IMC <= 16.99)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", muito abaixo do peso.");
		}
		if (IMC > 16.99 && IMC <= 18.5)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", abaixo do peso.");
		}

		if (IMC > 18.5 && IMC <= 24.99)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", peso normal.");
		}

		if (IMC > 24.99 && IMC <= 29.99)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", sobrepeso.");
		}
		if (IMC > 29.99 && IMC <= 34.99)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", obesidade nível 1.");
		}
		if (IMC > 34.99 && IMC <= 39.99)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", obesidade nível 2.");
		}
		if (IMC > 39.99)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", obesidade mórbida.");
		}
	}
}