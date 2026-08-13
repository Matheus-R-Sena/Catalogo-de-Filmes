int quantidadeCadernos = 3;
int quantidadeCanetas = 5;

decimal precoCaderno = 18.50m;
decimal precoCaneta = 3.25m;
decimal percentualDesconto = 10m;
decimal valorPago = 100m;

int totalItens = quantidadeCadernos + quantidadeCanetas;

decimal custoCadernos = quantidadeCadernos * precoCaderno;
decimal custoCanetas = quantidadeCanetas * precoCaneta;
decimal subtotal = custoCadernos + custoCanetas;
decimal desconto = subtotal * percentualDesconto / 100m;
decimal valorFinal = subtotal - desconto;
decimal troco = valorPago - valorFinal;

Console.WriteLine($"Total de itens: {totalItens}");
Console.WriteLine($"Custo dos cadernos: R$ {custoCadernos:F2}");
Console.WriteLine($"Custo das canetas: R$ {custoCanetas:F2}");
Console.WriteLine($"Subtotal: R$ {subtotal:F2}");
Console.WriteLine($"Desconto: R$ {desconto:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
Console.WriteLine($"Troco: R$ {troco:F2}");