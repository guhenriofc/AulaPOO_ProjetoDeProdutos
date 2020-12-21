using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes.cs
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Marca> ListaDeMarcas = new List<Marca>();

        public Marca Cadastrar(){

            Marca novaMarca = new Marca();

            Console.Write("Digite o codigo da marca: ");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da marca: ");
            novaMarca.NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.UtcNow;
        
            ListaDeMarcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar(){

            Console.ForegroundColor = ConsoleColor.Magenta;

            foreach (Marca item in ListaDeMarcas)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Nome da Marca: {item.NomeMarca}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                
            }

            Console.ResetColor();

        }

        public void Deletar(int cod){

            Marca marcaDelete = ListaDeMarcas.Find(m => m.Codigo == cod);
            ListaDeMarcas.Remove(marcaDelete);

        }

    }
}