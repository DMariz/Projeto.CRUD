using System;
using System.Collections.Generic;
using ComidasCRUD.Interfaces;

namespace ComidasDeliciosas
{
	public class Geladeira : Repositorio<Comida>
	{
        private List<Comida> listaComida = new List<Comida>();
		public void Atualiza(int id, Comida objeto)
		{
			listaComida[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaComida[id].Excluir();
		}

		public void Insere(Comida objeto)
		{
			listaComida.Add(objeto);
		}

		public List<Comida> Lista()
		{
			return listaComida;
		}

		public int ProximoId()
		{
			return listaComida.Count;
		}

		public Comida RetornaPorId(int id)
		{
			return listaComida[id];
		}
	}
}