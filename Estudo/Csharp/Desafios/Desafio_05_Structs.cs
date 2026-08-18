var p1 = new Point {X = 3, Y = 4};
var p2 = p1; //os dados são copiados para p2

p2.X = 10;

Console.WriteLine(p1);
Console.WriteLine(p2);

struct Point {
    public double X {get ; set;}
    public double Y {get ; set;}

    public readonly double DistanceTo(Point other)
    {
        var dx = X - other.X;
        var dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
    
    public override string ToString() => $"{X}, {Y}";
}

/*
Estado do Struct?
membros somente leitura?

*/
var instanciaObjetoEmMemoria = new Point();
instanciaObjetoEmMemoria.X = 2;
instanciaObjetoEmMemoria.Y = 3;
var instanciaObjetoEmMemoria = new Point {X = 2; Y = 3}


