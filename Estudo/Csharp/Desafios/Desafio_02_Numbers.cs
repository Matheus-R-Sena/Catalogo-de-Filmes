int cadernos = 3;
int canetas = 5;
decimal ValorCaneta = 3.25m;
decimal valorCaderno = 18.50m;
int itens = cadernos + canetas;//total itens comprados
decimal custoCaneta = ValorCaneta * canetas;//Custos Sepsarados
decimal custoCaderno = valorCaderno * cadernos;
decimal subtotal = custoCaderno + custoCaneta;//subtotal
decimal desconto = (subtotal*10)/100; //Desconto 
decimal valorFinal = subtotal - desconto; //Valor final
decimal troco = 100 - valorFinal; //troco




Console.WriteLine($"Total de itens: {itens}");
console.WriteLine($"Custo dos cadernos: R${custoCaderno}");
console.WriteLine($"Custo das canetas: R${custoCaneta}");
console.WriteLine($"Subtotal: R${subtotal}");
console.WriteLine($"Desconto: R${desconto}");
console.WriteLine($"Valor final: R${valorFinal}");
console.WriteLine($"Troco: R$ {troco}");









/*
| Tipo      | Tamanho | Precisão aproximada    | Sufixo                   |
| --------- | ------- | ---------------------- | ------------------------ |
| `float`   | 32 bits | 6–9 dígitos            | `f` ou `F`               |
| `double`  | 64 bits | 15–17 dígitos          | opcional: `d` ou `D`     |
| `decimal` | 128 bits| 28–29 dígitos          | `m` ou `M`               |
*/


/*
Saida esperada
Total de itens: 8
Custo dos cadernos: R$ 55,50
Custo das canetas: R$ 16,25
Subtotal: R$ 71,75
Desconto: R$ 7,18
Valor final: R$ 64,58
Troco: R$ 35,43

*/

