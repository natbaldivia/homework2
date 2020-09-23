using System;

namespace licaodecasa2
{
	class Program
	{
		static void Main(string[] args)
		{
			licaodecasa5();

		}

		private static void licaodecasa5()
		{
			Console.WriteLine("Digite o saldo da conta");
			int saldo = int.Parse(Console.ReadLine());
			Console.WriteLine("Quanto você deseja sacar");
			int vlrSaque = int.Parse(Console.ReadLine());
			if (vlrSaque > saldo)
			{
				Console.WriteLine("Não há saldo suficiente");
			}
			else
			{
				if (vlrSaque <= saldo)
				{
					Console.WriteLine("Saque autorizado");
					Console.WriteLine("Saldo atualizado = " + (saldo - vlrSaque));
				}
			}
		}

		private static void licaodecasa4()
		{
			Console.WriteLine("Digite um numero");
			float numeroa = float.Parse(Console.ReadLine());
			float resultado = numeroa % 2;
			if (resultado != 0)
			{
				Console.WriteLine("O resultado é impar = " + resultado);
			}
			else
			{
				Console.WriteLine("O resultado é par = " + resultado);
			}
		}

		private static void licaodecasa1()
		{
			Console.WriteLine("Digite um numero");
			int numeroa = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite mais um numero");
			int numerob = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite só mais um número");
			int numeroc = int.Parse(Console.ReadLine());
			if (numeroa > numerob)
			{
				Console.WriteLine("O maior é " + numeroa);
			}
			else
			{
				if (numerob > numeroc)
				{
					Console.WriteLine("O maior é " + numerob);
				}
				else
				{
					Console.WriteLine("O maior é " + numeroc);
				}
				if (numeroa > numeroc)
				{
					Console.WriteLine("O maior é " + numeroa);
				}
				else
				{
					Console.WriteLine("O maior é " + numeroc);
				}
			}
			Console.ReadLine();
		}

		private static void licaodecasa2()
		{
			Console.WriteLine("Digite seu nome");
			String nome1 = Console.ReadLine();
			Console.WriteLine("Digite o nome do colega");
			String nome2 = Console.ReadLine();
			if (nome1 == nome2)
			{
				Console.WriteLine("Os nomes são iguais");
			}
			Console.ReadLine();
		}

		private static void licaodecasa3()
		{
			Console.WriteLine("Digite um número");
			int numeroa = int.Parse(Console.ReadLine());
			if (numeroa < 0)
			{
				Console.WriteLine("O numero é negativo");
			}
			else
			{
				Console.WriteLine("O número é positivo");
			}
		}
	}
}