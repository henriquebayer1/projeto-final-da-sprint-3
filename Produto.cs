using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_aula_16052023
{
    public class Produto
    {
        public int Codigo;

        public string NomeProduto;

        public float Preco;

        public DateTime DataCadastro;

//Lista da classe Produto
List<Produto> Produtos = new List<Produto>();

//Instanciando objeto da classe Marca
Marca mP = new Marca();
public Produto()
{
    
}


        public string Cadastrar()
        {Produto novop = new Produto();

        Console.WriteLine($"Digite o codigo do novo produto:");
        novop.Codigo = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Digite o nome do novo produto:");
        novop.NomeProduto = Console.ReadLine();
        
        Console.WriteLine($"Digite o codigo da marca que refere-se a este produto:");
        mP.Codigo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o preco do novo produto:");
        novop.Preco = float.Parse(Console.ReadLine());

        novop.DataCadastro = DateTime.Now;
        
        Produtos.Add(novop);
            
            
            
            return "s";}

        public string Listar()
        {
            if (Produtos.Count > 0 || Produtos.Count != null)
            {
                foreach (Produto p in Produtos)
                {
                    Console.WriteLine($"Codigo: {p.Codigo} - Nome: {p.NomeProduto} - Preco: {p.Preco:C} - Data de cadastro: {p.DataCadastro}");

                    
}



            }
            else{Console.WriteLine($"Nenhum produto cadastrado no momento");
            }
            
            
            
            return "s";}

        public string Deletar()
        {
            Console.WriteLine($"Digite o codigo do produto que deseja deletar:");
            int pCodDel = int.Parse(Console.ReadLine());

            Produto codigoAchado = Produtos.Find(x => x.Codigo == pCodDel);
            
           int index = Produtos.IndexOf(codigoAchado);
            Produtos.RemoveAt(index);

            return "s";}





















}



    }
