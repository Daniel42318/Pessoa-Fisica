using System;
using System.Collections.Generic;
using System.Text;

namespace População
{ 
    internal class Aluno : PessoaFisica
    {
        public String RM;
        public String Curso;

        public void listarAluno(String RM, String curso)
        {
            Console.WriteLine("O portador do RM " + RM
            + " está matrículado no curso " + Curso);
        }
    }
}
