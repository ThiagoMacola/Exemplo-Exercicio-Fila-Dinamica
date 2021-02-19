using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamicaSimplesEncadeada
{
	class FilaOS
	{
		public OrdemServico Head { get; set; }
		public OrdemServico Tail { get; set; }

		public bool Void()
		{
			if ((Head == null) && (Tail == null))
				return true;
			return false;
		}
		public void Push(OrdemServico aux)
		{
			if (Void())
			{
				Head = aux;
				Tail = aux;
			}
			else
			{
				Tail.Proximo = aux; // Encadeamento da Nova Ordem de Serviço
				Tail = aux; // Atualizo o Tail
			}
			Console.WriteLine("Elemento Inserido com Sucesso");
		}
		public void Print()
		{
			if (Void())
			{
				Console.WriteLine("Impossivel Imprimir. Fila Vazia\n");
				Console.ReadKey();
			}
			else
			{
				OrdemServico aux = Head;
				Console.WriteLine("\nAs ordens de serviço são:\n");
				do
				{
					Console.WriteLine(aux.ToString());
					aux = aux.Proximo;
				} while (aux != null);
				Console.WriteLine("\n>>>>>FIM<<<<<<\n");
			}
		}
		public void Pop()
		{
			if (Void())
			{
				Console.WriteLine("Impossivel remover! Fila vazia\n");
				Console.ReadKey();
			}
			else
			{
				Head = Head.Proximo;
				Console.WriteLine("Elemento Removido com Sucesso!\n");
				if (Head == null)
				{
					Tail = null;
					Console.WriteLine("Fila está Vazia!!!\n");
					Console.ReadKey();
				}
			}
		}
		public int Amount()
		{
			int cont = 0;
			if (Void())
			{
				Console.WriteLine("Fila Vazia!");
				return 0;
			}
			if (Head != Head.Proximo)
			{
				OrdemServico aux = Head;
				do
				{
					cont++;
					aux = aux.Proximo;
					
				} while (aux != null);

				return cont;
			}
			else cont--;
			return cont;
		}
		public void Find(int numeroOrdem)
		{
			if (Void())
			{
				Console.WriteLine("Fila Vazia!\n");
				Console.ReadKey();
			}
			else
			{

				OrdemServico aux = Head;
				do
				{
					if (aux.Numero == numeroOrdem)
					{
						Console.WriteLine("Ordem de Serviço Encontrada!!!: \n" + aux.ToString());
					}
					else Console.WriteLine("Ordem de Serviço não Encontrada");
					aux = aux.Proximo;
					Console.WriteLine();
				} while (aux != null);
				Console.WriteLine(">>>FIM<<<\n");
			}

		}

	}
}