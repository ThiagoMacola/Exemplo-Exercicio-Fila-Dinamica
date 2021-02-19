using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamicaSimplesEncadeada
{
	class OrdemServico
	{
		public int Numero { get; set; }
		public string Tipo { get; set; }
		public string Descricao { get; set; }
		public DateTime DataCriacao { get; set; }
		public int Prazo { get; set; }
		public OrdemServico Proximo { get; set; }
		public override string ToString()
		{
			return ">>>>Dados O.S<<<<\nNumero da O.S: " + Numero + 
					"\nTipo: " + Tipo + "\nDescricao: " + Descricao +
					"\nData do pedido: " + DataCriacao + 
					"\nPrazo em dias: " + Prazo;
		}

	}
}
