using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Meu amor, POR FAVOR, escreva seu peso.");
		double peso = double.Parse(Console.ReadLine());
		Console.WriteLine("Meu amor, POR FAVOR, escreva sua altura.");
		double altura = double.Parse(Console.ReadLine());
		double IMC = peso / (altura * altura);
		if (IMC <= 18.5)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", magrela demais.");
		}

		if (IMC > 18.5 && IMC <= 24.9)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", peso normal.");
		}

		if (IMC > 24.9)
		{
			Console.WriteLine("Seu IMC é " + IMC + ", OBESO.");
		}
	}
}