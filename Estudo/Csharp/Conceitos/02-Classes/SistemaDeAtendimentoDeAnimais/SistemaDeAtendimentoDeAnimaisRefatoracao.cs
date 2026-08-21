using ClinicaVeterinaria.Dominio;
using ClinicaVeterinaria.Servicos;

// Criação dos objetos das classes derivadas
var cachorro = new Cachorro(
    "Rex",
    5,
    "Labrador"
);

var gato = new Gato(
    "Luna",
    3,
    "Preta"
);

// Polimorfismo:
// O array é do tipo Animal, mas armazena
// objetos Cachorro e Gato.
Animal[] animais =
{
    cachorro,
    gato
};

var atendimentoService = new AtendimentoService();

// Percorre todos os animais
for (int i = 0; i < animais.Length; i++)
{
    Animal animalAtual = animais[i];

    atendimentoService.Atender(animalAtual);
}

// Demonstração da sobrecarga
Console.WriteLine("=== ALIMENTAÇÃO ===");

cachorro.Alimentar();

gato.Alimentar("sachê de frango");

namespace ClinicaVeterinaria.Dominio
{
    // Classe base
    public class Animal
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        // Construtor da classe base
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método virtual que pode ser sobrescrito
        public virtual string EmitirSom()
        {
            return "Som não identificado";
        }

        // Método virtual que pode ser sobrescrito
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }

        // Primeira versão do método Alimentar
        public void Alimentar()
        {
            Console.WriteLine(
                $"{Nome} recebeu ração padrão."
            );
        }

        // Segunda versão do método Alimentar
        public void Alimentar(string alimento)
        {
            Console.WriteLine(
                $"{Nome} recebeu {alimento}."
            );
        }
    }

    // Cachorro herda de Animal
    public class Cachorro : Animal
    {
        public string Raca { get; set; }

        public Cachorro(
            string nome,
            int idade,
            string raca
        ) : base(nome, idade)
        {
            Raca = raca;
        }

        // Sobrescrita do método da classe base
        public override string EmitirSom()
        {
            return "Au au!";
        }

        // Sobrescrita do método da classe base
        public override void ExibirDados()
        {
            // Executa o método da classe Animal
            base.ExibirDados();

            Console.WriteLine($"Raça: {Raca}");
        }
    }

    // Gato herda de Animal
    public class Gato : Animal
    {
        public string Cor { get; set; }

        public Gato(
            string nome,
            int idade,
            string cor
        ) : base(nome, idade)
        {
            Cor = cor;
        }

        // Sobrescrita do método da classe base
        public override string EmitirSom()
        {
            return "Miau!";
        }

        // Sobrescrita do método da classe base
        public override void ExibirDados()
        {
            // Executa o método da classe Animal
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