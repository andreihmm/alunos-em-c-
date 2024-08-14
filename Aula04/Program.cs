using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula04.Aula04;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item it01 = new Item();
            it01.Tipo = "Borracha";
            it01.Qty = 10;

            Item it02 = new Item()
            {
                Tipo = "Lápis",
                Qty = 2
            };

            Notas NotasAluno = new Notas()
            {
                Nota01 = 10,
                Nota02 = 10
            };

            Aluno aluno01 = new Aluno()
            {
                Nome = "Andrei",
                Mat = 123,
                NotasDigitadas = NotasAluno,
            };

            aluno01.Itens.Add(it01);
            aluno01.Itens.Add(it02);

            Console.WriteLine($"O aluno {aluno01.Nome} tem nota 1 igual a {aluno01.NotasDigitadas.Nota01}");
            aluno01.RecuperarItemPeloTipo("Borracha");
        }
    }
}
