using Biblioteca.Dominio;
using Biblioteca.Servicos;
using Biblioteca.Apresentacao;

var livro01 = new Biblioteca.Dominio.Livro ("Hobbit", "Tolkien");
var livro02 = new Biblioteca.Dominio.Livro ("Senhor dos aneis", "Tolkien");
var livro03 = new Biblioteca.Dominio.Livro ("A guerra dos tronos", "J R R Martin");

var servicoEmprestimo = new Biblioteca.Servicos.EmprestimoService();
var apresenta = new Biblioteca.Apresentacao.Relatorio();

//Apresentando o livro

apresenta.ExibirLivro(livro01);
apresenta.ExibirLivro(Livro02);
apresenta.ExibirLivro(Livro03);

//Emprestimos

bool emprestimo01 = servicoEmprestimo.Emprestar(livro01);
PrintaEmprestimo(emprestimo01, livro01);

emprestimo01 = servicoEmprestimo.Devolver(livro01);
PrintaEmprestimo(emprestimo01, livro01);

bool emprestimo02 = servicoEmprestimo.Emprestar(livro02);
PrintaEmprestimo(emprestimo02, livro02);

emprestimo02 = servicoEmprestimo.Emprestar(livro02);
PrintaEmprestimo(emprestimo02, livro02);







void PrintaEmprestimo (bool emprestimo, Biblioteca.Dominio.Livro livro)
{
    if (emprestimo)
    {
        Console.WriteLine($"O livro: {livro.titulo} do autor {livro.autor} foi emprestado com sucesso!");
    }else
        {
            
        Console.WriteLine($"O livro: {livro.titulo} do autor {livro.autor} encontra-se indiponivel! Nao eh possivel fazer emprestimo");
        }
}

namespace Biblioteca.Dominio
{
    public class Livro
    {
        public string titulo;
        public string autor;
        public bool disponivel;

        public Livro (string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.disponivel = true;
        }

    }
}

namespace Biblioteca.Servicos
{
    public class EmprestimoService 
    {
        public bool Emprestar(Livro livro)
        {
            if(livro.disponivel)
            {
                livro.disponivel = false;
                return true;
            }else
                {
                    return false;
                }
        }

        public bool Devolver (Livro livro)
        {
            if(!livro.disponivel)
            {
                livro.disponivel = true;
                return true;
            }else
                {
                    return false;
                }
        }
    }

}

namespace Biblioteca.Apresentacao
{
    public class Relatorio 
    {
        public void ExibirLivro (Livro livro)
        {
            Console.WriteLine($"Livro: {livro.titulo}");
            Console.WriteLine($"autor: {livro.autor}");
            Console.WriteLine($"Situação de disponibilidade: {livro.disponivel}");
        }   
    }
}