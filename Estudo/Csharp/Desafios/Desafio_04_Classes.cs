var produto = new Produto("mouse", 85.95m, 10);

Console.WriteLine(produto.nome);

Console.WriteLine($"Produto: {produto.nome}");
Console.WriteLine($"A quanntidade do estoque inicial é: {produto.QuantidadeEmEstoque}");

bool primeiravenda = produto.vender(3);
Console.WriteLine($"A primeira venda de 3 unidades foi classificada como {primeiravenda}");

produto.repor(2);
Console.WriteLine($"A reposição após a venda atualizou o estoque para: {produto.QuantidadeEmEstoque}");

bool segundaVenda = produto.vender(20);
Console.WriteLine($"A segunda venda obteve seguinte status: {segundaVenda} deixando a quantidade em: {produto.QuantidadeEmEstoque}");

Console.WriteLine($"Estoque final: {produto.QuantidadeEmEstoque}");
Console.WriteLine(
    $"Valor total do estoque: {produto.CalculaValorEstoque:F2}"
    );


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
        if (number <= this.QuantidadeEmEstoque && number > 0)
        {
            this.QuantidadeEmEstoque -= number;
            return true;
        } 
        
        return false;
    
    }

    public decimal CalculaValorEstoque ()
    {
        return this.QuantidadeEmEstoque * this.preco;
        
    }
    public decimal CalcularValorDoEstoque()
    {
        return preco*QuantidadeEmEstoque;
    }

}