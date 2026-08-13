var produto = new Produto("mouse", "85.95m", 10);

Console.WriteLine(produto.nome);

produto.vender(3);
produto.repor(2);
produto.vender(20);
Console.WriteLine(produto.QuantidadeEmEstoquePUB);


public class Produto
{

    public String nome {get; set;}
    public decimal preco {get; set;}
    public int QuantidadeEmEstoque {get; private set;}

     public Produto (String nome, decimal preco, int quantidadeEmEstoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void repor (int numero)
    {
        QuantidadeEmEstoque += numero;
    }

    public bool vender (int number)
    {
        if (number <= QuantidadeEmEstoquePUB)
        {
            QuantidadeEmEstoquePUB -= number;
            return true;
        } else
        {
            return false;
        }
    
    }
    public decimal CalcularValorDoEstoque()
    {
        return preco*QuantidadeEmEstoquePUB;
    }

}