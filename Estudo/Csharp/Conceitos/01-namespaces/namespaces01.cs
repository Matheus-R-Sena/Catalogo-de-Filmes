var livro = new Livro ("Hobbit", "Tolkien");

Console.WriteLine($"Situacao do livro {livro.titulo} eh: {livro.disponivel}");

bool emprestimo = Biblioteca.Servicos.EmprestimoService.Emprestar(livro);

Console.WriteLine($"O emprestimo de {livro.titulo} foi {emprestimo}");
Console.WriteLine($"O livro de {livro.titulo} se encontra com status de disponibilidade {livro.disponivel}");
bool emprestimo02 = Biblioteca.Servicos.EmprestimoService.Emprestar(livro);
Console.WriteLine($"O segundo emprestimo tem status {emprestimo02}");

bool devolucao01 = Biblioteca.Servicos.EmprestimoService.Devolver(livro);

Console.WriteLine($"O status de disponibilidade do livro {livro.titulo} eh {livro.disponivel}");


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
                return = true;
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
                return = true;
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