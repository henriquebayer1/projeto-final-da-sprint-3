using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_aula_16052023
{
    public class Marca
    {
        

        
//Lista da classe Marca
List<Marca> Marcas = new List<Marca>();



public int Codigo;

public string NomeMarca;

public DateTime DataCadastro;



public string Cadastrar()
{Marca novamarca = new Marca();
    
    Console.WriteLine($"Insira o novo codigo da marca");
novamarca.Codigo = int.Parse(Console.ReadLine());

{Console.WriteLine($"Insira o nome da nova da marca");
novamarca.NomeMarca = Console.ReadLine();

Marcas.Add(novamarca);


    
    
    return "a";}

 }

 public string Deletar()
{
    Console.WriteLine($"Digite o codigo da marca que deseja excluir");
    Marca MarcaExcluida = Marcas.Find(x => x.Codigo == MarcaExcluida);
    
    int index = Marcas.IndexOf(MarcaExcluida);
    
    return "a";}

public string Listar()
{
     if (Marcas.Count > 0 || Marcas != null)
            { foreach (Marca p in Marcas)
            {
                Console.WriteLine($"Codigo: {p.Codigo} - Nome: {p.NomeMarca}");
                
                
            }   
            }
            else{Console.WriteLine($"Nenhuma marca registrada");
            }
    
    
    
    
    return "a";}

}}