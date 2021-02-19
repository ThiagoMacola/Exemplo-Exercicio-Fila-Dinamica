using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamicaSimplesEncadeada
{
	class Program
	{
		static void Main(string[] args)
		{

			int escolha = 6;
			FilaOS minha_fila = new FilaOS
			{
				Head = null,
				Tail = null
			};

			do
			{
				Menu();
				try
				{
					escolha = int.Parse(Console.ReadLine());
					if (escolha == 6)
						Console.WriteLine("DIGITE UM NUMERO DE 0 A 5 INFELIZ!");
				}
				catch (Exception)
				{

					Console.WriteLine("DIGITE UM NUMERO DE 0 A 5 INFELIZ!");
				}
				Console.Clear();
				switch (escolha)
				{
					case 1:
						OrdemServico m = DadosOs();
						minha_fila.Push(m);
						Console.Clear();
						break;
					case 2:
						minha_fila.Pop();
						break;
					case 3:
						Console.WriteLine();
						minha_fila.Print();
						break;
					case 4:
						int cont = 0;
						cont = minha_fila.Amount();
						Console.Write("A quantidade Serviços na fila é igual há: " + cont);
						Console.WriteLine("\n");
						break;
					case 5:
						Console.Write("Digite Numero da Ordem de Serviço: ");
						int numeroOrdem = int.Parse(Console.ReadLine());
						Console.WriteLine();
						minha_fila.Find(numeroOrdem);
						break;
				}
			} while (escolha != 0);
			//Console.WriteLine(os.ToString());
			Console.ReadKey();
		}
		public static OrdemServico DadosOs()
		{

			Console.Write("Digite Numero da Ordem de Serviço: ");
			int numero = int.Parse(Console.ReadLine());
			Console.Write("Tipo da Ordem de Serviço: ");
			string tipo = Console.ReadLine();
			Console.Write("Descrição da Ordem de Serviço: ");
			string descricao = Console.ReadLine();
			Console.Write("Digite Prazo para finalizar a Ordem de serviço: ");
			int prazo = int.Parse(Console.ReadLine());
			OrdemServico os = new OrdemServico
			{
				Numero = numero,
				Tipo = tipo,
				Descricao = descricao,
				//Data_Criacao = DateTime.Parse("20/02/2021"),
				DataCriacao = DateTime.Now,
				Prazo = prazo,
				Proximo = null
			};


			return os;

		}
		public static void Menu()
		{
			Console.WriteLine("=========Menu Fila - Ordem de Serviço ==========");
			Console.WriteLine();
			Console.WriteLine(" 1 - Inserir Ordem de Serviço");
			Console.WriteLine(" 2 - Remover Ordem de Serviço");
			Console.WriteLine(" 3 - Imprimir Ordens de Serviço");
			Console.WriteLine(" 4 - Quantidade de Ordens de Serviço solicitadas");
			Console.WriteLine(" 5 - Buscar Ordem de Serviço");
			Console.WriteLine(" 0 - Sair");
			Console.Write("Escolha uma das opções acima: ");
		}
	}
}
/* public static OrdemServico DadosOs()    Como retornar essa função dados?
		{

			Console.Write("Digite Numero da Ordem de Serviço: ");
			int numero = int.Parse(Console.ReadLine());
			Console.Write("Tipo da Ordem de Serviço: ");
			string tipo = Console.ReadLine();
			Console.Write("Descrição da Ordem de Serviço: ");
			string descricao = Console.ReadLine();
			Console.Write("Digite Prazo para finalizar a Ordem de serviço: ");
			int prazo = int.Parse(Console.ReadLine());
			OrdemServico os = new OrdemServico
			{
				Numero = numero,
				Tipo = tipo,
				Descricao = descricao,
				//Data_Criacao = DateTime.Parse("20/02/2021"),
				Data_Criacao = DateTime.Now,
				Prazo = prazo,
				Proximo = null
			};


			return os;

		}*/