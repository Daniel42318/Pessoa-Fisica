using System;
using System.Collections.Generic;
using System.Text;

namespace População
{
    internal class Professor : PessoaFisica
    {
        public String formacao;
        public String cargo;
        public double salario;

        public void listarProfessor(String formacao, String cargo, double salario)
        {
            Console.WriteLine("Formulação Acadêmica: " + formacao);
            Console.WriteLine("Cargo na instituição: " + cargo);
            Console.WriteLine("Sálario: " + salario);
        }
        public void cadastrasDisciplina()
        {
            Console.WriteLine("Em qual disciplina deseja cadastrar o professor?");
            String disciplina = Console.ReadLine();
            Console.WriteLine("O professor foi cadastrado na disciplina" + disciplina);
        }
    }
}
