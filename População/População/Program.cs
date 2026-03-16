using População;

Professor prof = new Professor();
Console.WriteLine("Insira o nome");
prof.nome = Console.ReadLine();
Console.WriteLine("Insira a idade");
prof.idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira o CPF");
prof.cpf = Console.ReadLine();

prof.listarDados(prof.nome, prof.idade, prof.cpf);

//parte do Aluno
Console.WriteLine("");
Aluno AL = new Aluno();
Console.WriteLine("Insira o RM");
AL.RM = Console.ReadLine();
Console.WriteLine("Insira o curso do aluno");
AL.Curso = Console.ReadLine();

AL.listarAluno(AL.RM, AL.Curso);