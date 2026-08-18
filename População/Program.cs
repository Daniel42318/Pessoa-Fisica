using População;

Console.WriteLine("Você é aluno ou professor?");
String escolaridade = Console.ReadLine();

PessoaFisica pessoa = new PessoaFisica();
Console.WriteLine("Insira o nome: ");
pessoa.nome = Console.ReadLine();
Console.WriteLine("Insira a idade: ");
pessoa.idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira o CPF: ");
pessoa.cpf = Console.ReadLine();

if (escolaridade == "Professor" || escolaridade == "Professor")
{
    Professor prof = new Professor();
    Console.WriteLine("Insira o nome");
    prof.nome = Console.ReadLine();
    Console.WriteLine("Insira a idade");
    prof.idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira o CPF");
    prof.cpf = Console.ReadLine();
    prof.listarDados(prof.nome, prof.idade, prof.cpf);
}

else if (escolaridade == "Aluno" || escolaridade == "Aluno")
{
    Aluno AL = new Aluno();
    Console.WriteLine("Insira o RM");
    AL.RM = Console.ReadLine();
    Console.WriteLine("Insira o curso do aluno");
    AL.Curso = Console.ReadLine();

    AL.listarAluno(AL.RM, AL.Curso);
}