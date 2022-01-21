// See https://aka.ms/new-console-template for more information
using System;

namespace ComidasDeliciosas //Progamado enquanto estava com fome
{
    class Program
    { 
        static Geladeira repositorio = new Geladeira();
        static void Main(string[] args)
        {
            string EscolhaDoUsuario = ObterEscolhaDoUsuario();

			while (EscolhaDoUsuario.ToUpper() != "X")
			{
				switch (EscolhaDoUsuario)
				{
					case "1":
						ListarComidas();
						break;
					case "2":
						InserirComida();
						break;
					case "3":
						AtualizarComida();
						break;
					case "4":
						ExcluirComida();
						break;
					case "5":
						VisualizarComida();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				EscolhaDoUsuario = ObterEscolhaDoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static string ObterEscolhaDoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Lista de Comidas Deliciosas para qualquer utilidade!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar Comidas Inseridas");
			Console.WriteLine("2- Inserir nova Comida");
			Console.WriteLine("3- Atualizar Comida");
			Console.WriteLine("4- Excluir Comida");
			Console.WriteLine("5- Consultar ID de Comida");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string escolhaUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return escolhaUsuario;
		}
        
        // Funcoes das escolhas
        private static void ListarComidas()
		{
			Console.WriteLine("Listar Comidas");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nada na Geladeira.");
				return;
			}

			foreach (var comida in lista)
			{
                var excluido = comida.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", comida.retornaId(), comida.retornaNome(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirComida()
		{
			Console.WriteLine("Inserindo nova comida...");

            Console.Write("Digite o Nome da Comida: ");
			string entradaNome = Console.ReadLine();

			foreach (int i in Enum.GetValues(typeof(Tipo)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Tipo), i));
			}
			Console.Write("Digite o tipo de comida entre as opções acima: ");
			int entradaTipo = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Sabor)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Sabor), i));
			}
			Console.Write("Digite Sabor da Comida entre as opções acima: ");
			int entradaSabor = int.Parse(Console.ReadLine());
			

			Console.Write("Digite a Validade média dessa Comida: ");
			int entradaValidade = int.Parse(Console.ReadLine());

			


			Comida novaComida = new Comida(id: repositorio.ProximoId(),
                                        nome: entradaNome,
										tipo: (Tipo)entradaTipo,
                                        sabor: (Sabor)entradaSabor,										
										validade: entradaValidade);

			repositorio.Insere(novaComida);
		}

        private static void AtualizarComida()
		{
			Console.Write("Digite o ID da Comida: ");
			int indice = int.Parse(Console.ReadLine());

			Console.WriteLine("Atualizando comida...");

            Console.Write("Digite o Nome da Comida: ");
			string entradaNome = Console.ReadLine();

			foreach (int i in Enum.GetValues(typeof(Tipo)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Tipo), i));
			}
			Console.Write("Digite o tipo de comida entre as opções acima: ");
			int entradaTipo = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Sabor)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Sabor), i));
			}
			Console.Write("Digite Sabor da Comida entre as opções acima: ");
			int entradaSabor = int.Parse(Console.ReadLine());
			

			Console.Write("Digite a Validade média dessa Comida: ");
			int entradaValidade = int.Parse(Console.ReadLine());


			
			Comida atualizaComida = new Comida(id: indice,
                                        nome: entradaNome,
										tipo: (Tipo)entradaTipo,
                                        sabor: (Sabor)entradaSabor,										
										validade: entradaValidade);

			repositorio.Atualiza(indice, atualizaComida);
		}

         private static void ExcluirComida()
		{
			Console.Write("Digite o ID da comida: ");
			int indice = int.Parse(Console.ReadLine());

			repositorio.Exclui(indice);
		}

        private static void VisualizarComida()
		{
			Console.Write("Digite o id da série: ");
			int indice = int.Parse(Console.ReadLine());

			var Comida = repositorio.RetornaPorId(indice);

			Console.WriteLine(Comida);
		}
    }
    

} 
 