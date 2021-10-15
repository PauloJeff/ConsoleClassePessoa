using System;

namespace ConsoleClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome: ");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu RG: ");
            pessoa.rg = Console.ReadLine();

            Console.WriteLine("Digite seu CPF: ");
            pessoa.cpf = Console.ReadLine();

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("Rg: {0}", pessoa.rg);
            Console.WriteLine("CPF: {0}", pessoa.cpf);

            Pessoa pessoaSilvia = new Pessoa();
            pessoaSilvia.nome = "Silvia Mendes";
            pessoaSilvia.idade = 32;
            pessoaSilvia.rg = "11.000.000-0";
            pessoaSilvia.cpf = "111.000.000-00";

            Console.WriteLine("Nome: {0}", pessoaSilvia.nome);
            Console.WriteLine("Idade: {0}", pessoaSilvia.idade);
            Console.WriteLine("Rg: {0}", pessoaSilvia.rg);
            Console.WriteLine("CPF: {0}", pessoaSilvia.cpf);

            pessoa.Acenar(pessoaSilvia);
            pessoa.PerguntaIdade(pessoaSilvia);
        }
    }
}
