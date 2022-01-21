using System;

namespace ComidasDeliciosas
{
    public class Comida : BaseEntity
    {
        //Definições e Atributos

        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public Sabor Sabor { get; set; }
        public int Validade { get; set; }   // média de dias até estragar

        private bool Excluido {get; set;}


        //Metodos
        public Comida(int id, string nome, Tipo tipo, Sabor sabor, int validade)
        {
            this.ID =id;
            this.Nome =nome;
            this.Tipo =tipo;
            this.Sabor =sabor;
            this.Validade =validade;

            this.Excluido = false;
        }


        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Tipo: " + this.Tipo + Environment.NewLine;
            retorno += "Sabor: " + this.Sabor + Environment.NewLine;
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Validade média: " + this.Validade + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaNome()
		{
			return this.Nome;
		}

		public int retornaId()
		{
			return this.ID;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}