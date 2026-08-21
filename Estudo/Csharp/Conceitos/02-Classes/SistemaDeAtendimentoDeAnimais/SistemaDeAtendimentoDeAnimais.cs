using ClinicaVeterinaria.Dominio;
using ClinicaVeterinaria.AtendimentoService;

var cachorro01 = new Cachorro("Rex", 5, "Labrador");
var gato01 = new Gato("Luna", 3, "preta");

Animal[] animais;
animais = new Animal[5];

animais[0] = cachorro01;
animais[1] = gato01;












namespace ClinicaVeterinaria.Dominio
{
    public class Animal
    {
        public string nome;
        public int idade;

        //Construtor
        public Animal (string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        //Métodos para sobrescrita
        public virtual string EmitirSom ()
        {
            return "som não identificado";
        }

        public virtual void ExibirDados ()
        {
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Idade: {this.idade} anos");
        }

        //Overload/Sobrecarga

        public void Alimentar ()
        {
            Console.WriteLine($"O {this.nome} foi alimentado com racao padrao");
        }

        public void Alimentar (String alimento)
        {
            Console.WriteLine($"O {this.nome} foi alimentado com {alimento}");
        }

    }

    public class Cachorro : Animal
    {
        public string Raca {get; set;}

        //usando construtor da classe base
        public Cachorro (string nome, int idade, string raca)
        : base(nome, idade)
        {
            this.Raca = raca;
        }

        //sobrescrita de métodos
        public override string EmitirSom()
        {
            return "Latiu";
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Raca: {this.Raca}");
        }
    }

    public class Gato : Animal
    {
        public string Cor {get; set;}

        public Gato (string nome, int idade, string cor)
        : base(nome, idade)
        {
            this.Cor = cor;
        }

        public override string EmitirSom()
        {
            return "miau";
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Cor: {this.Cor}");
        }
    }
    
}
namespace ClinicaVeterinaria.Servicos
{
    public class AtendimentoService 
    {
        public void Atender (Animal animal)
        {
            animal.ExibirDados();
            Console.WriteLine(animal.EmitirSom());
            Console.WriteLine($"Atendimento a {animal.nome} foi concluido");
        }
    }
}
namespace ClinicaVeterinaria.Apresentacao
{

}