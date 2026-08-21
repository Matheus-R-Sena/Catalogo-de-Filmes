using ClinicaVeterinaria.Dominio;
using ClinicaVeterinaria.Servicos;

Animal[] animais =
{
    new Cachorro(
        nome: "Rex",
        idade: 5,
        raca: "Labrador"
    ),

    new Gato(
        nome: "Luna",
        idade: 3,
        cor: "Preta"
    )
};

var atendimentoService = new AtendimentoService();

foreach (Animal animal in animais)
{
    atendimentoService.Atender(animal);
}

Console.WriteLine("=== ALIMENTAÇÃO ===");

animais[0].Alimentar();
animais[1].Alimentar("sachê de frango");

namespace ClinicaVeterinaria.Dominio
{
    public abstract class Animal
    {
        public string Nome { get; }

        public int Idade { get; }

        protected Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public abstract string EmitirSom();

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }

        public void Alimentar()
        {
            Alimentar("ração padrão");
        }

        public void Alimentar(string alimento)
        {
            Console.WriteLine(
                $"{Nome} recebeu {alimento}."
            );
        }
    }

    public sealed class Cachorro : Animal
    {
        public string Raca { get; }

        public Cachorro(
            string nome,
            int idade,
            string raca
        ) : base(nome, idade)
        {
            Raca = raca;
        }

        public override string EmitirSom()
        {
            return "Au au!";
        }

        public override void ExibirDados()
        {
            base.ExibirDados();

            Console.WriteLine($"Raça: {Raca}");
        }
    }

    public sealed class Gato : Animal
    {
        public string Cor { get; }

        public Gato(
            string nome,
            int idade,
            string cor
        ) : base(nome, idade)
        {
            Cor = cor;
        }

        public override string EmitirSom()
        {
            return "Miau!";
        }

        public override void ExibirDados()
        {
            base.ExibirDados();

            Console.WriteLine($"Cor: {Cor}");
        }
    }
}

namespace ClinicaVeterinaria.Servicos
{
    using ClinicaVeterinaria.Dominio;

    public class AtendimentoService
    {
        public void Atender(Animal animal)
        {
            Console.WriteLine("=== ATENDIMENTO ===");

            animal.ExibirDados();

            Console.WriteLine(
                $"Som: {animal.EmitirSom()}"
            );

            Console.WriteLine("Atendimento concluído.");
            Console.WriteLine();
        }
    }
}