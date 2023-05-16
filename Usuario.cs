using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_aula_16052023
{
    public class Usuario
    {
        

public int Codigo;

public string Nome;

public string Email;

public string Senha;

public DateTime DataCadastro;


public string Cadastrar(Usuario user)
{
Console.WriteLine($"Informacoes de Usuario cadastradas: Nome: {user.Nome} E-mail: {user.Email} Senha: {user.Senha}");
Console.WriteLine($"");

Console.WriteLine($"Data de cadastro do usuario: {user.DataCadastro}");
Console.WriteLine($"");

Console.WriteLine(@$"Cadastro feito com sucesso!");




return "Cadastro feito com sucesso";
 

}


public string Deletar(Usuario user)
{return "a";}


    }
}