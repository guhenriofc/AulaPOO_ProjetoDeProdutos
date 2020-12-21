using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes.cs
{
    public class Produto
    {
    
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){


            Produto novoProduto = new Produto();

            Console.Write($"Digite o codigo do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.Write($"Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.Write($"Digite p preco do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            //Chamamos um metodo do objeto/propriedade "Marca"
            novoProduto.Marca = Marca.Cadastrar();
            
            //Utilizamos o proprio metodo construtor para atribuir um objeto completo de usuario
            novoProduto.CadastradoPor = new Usuario();

            DataCadastro = DateTime.UtcNow;
        
            ListaDeProdutos.Add(novoProduto);

        }

        public void Listar(){

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                
            }

            Console.ResetColor();

        }

        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
    }
}