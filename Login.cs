using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_aula_16052023
{
    public class Login
    {

//instaciando objeto da classe Usuario
Usuario usernovo = new Usuario();

Marca m = new Marca();

//instanciando objeto da classe Produto
Produto p = new Produto();


//
        
public bool Logado;


public Login()
{
    
}

public string Logar(Usuario user)
{

    do
    {Console.WriteLine($"Digite seu E-mail:");
string email = Console.ReadLine();


Console.WriteLine($"Digite sua senha:");
string senha = Console.ReadLine();

if (email == user.Email && senha == user.Senha)
{
    this.Logado = true;
}
else
{
    this.Logado = false;
}
    
    if (this.Logado == true)
    {
        Console.WriteLine($"Voce esta logado no sistema, agora tem acesso ao menu");
        
    }
    else
    {
        Console.WriteLine($"Erro no E-mail ou Senha tente novamente");
        
    }
        
    } while (this.Logado == false);

    
    
    return "a";}

public string Deslogar(Usuario user)
{
    Logado = false;
    
    
    return "a";}


public void Menu()
{Console.WriteLine($"Bem vindo ao sistema de cadastro de produtos!!!");
Console.WriteLine($"");


//CADASTRO NO SISTEMA DO NOVO USUARIO
Console.WriteLine($"Digite as seguintes informacoes para cadastro no sistema:");

Console.WriteLine($"Digite o seu nome");
usernovo.Nome = Console.ReadLine();

Console.WriteLine($"Digite o seu E-mail");
usernovo.Email = Console.ReadLine();

Console.WriteLine($"Digite sua senha");
usernovo.Senha = Console.ReadLine();

usernovo.DataCadastro = DateTime.UtcNow;

usernovo.Cadastrar(usernovo);


//LOGIN NO SISTEMA COM O USUARIO CADASTRADO
Console.WriteLine($"Logue no sistema com seu usuario:");

this.Logar(usernovo);


//variavel para opcao do menu
char opcao;

do
{
    Console.WriteLine(@$"
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Remover Produto
            ----------------------
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca
            [0] - Sair
            ");
opcao = char.Parse(Console.ReadLine());

            switch (opcao)
            {
                case '1':
                p.Cadastrar();
                    break;

                case '2':
                p.Listar();
                    break;

                case '3':
                p.Deletar();
                    break;

                case '4':
                m.Cadastrar();
                    break;

                case '5':
                m.Listar();
                    break;

                case '6':
                m.Deletar();
                    break;

                case '0':
                Console.WriteLine($"Voce saiu do sistema.");
                    break;

                default:
                Console.WriteLine($"Opcao Invalida");
                    break;
            }
} while (opcao != 0);

            


}

    }
}