using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.Aula04
{
    internal class Aluno
    {
        public string Nome { get; set; }

        public int Mat { get; set; }

        public Notas NotasDigitadas { get; set; }

        public List<Item> Itens { get; set; } = new List<Item>();

        // public Aluno()
        // {
        //     Itens = new List<Item>();
        // }

        public void AdicionarItem(Item i)
        {
            if(i != null)
                Itens.Add(i);
        }

        public void ListarItens()
        {
            
            foreach (Item it in Itens)
            {
                Console.WriteLine($"Tipo: {it.Tipo} / Qty: {it.Qty}");
            }
        }

        private bool VerificarSeExistePeloTipo (string tipo)
        {
            bool b = false;
            foreach (Item it in Itens)
            {
                if (it.Tipo == tipo)
                    b = true;
                    break;
            }
            return b;
        }

        public Item RecuperarItemPeloTipo(string tipo)
        {
            Item item = null;
            foreach (Item it in Itens)
            {
                if (it.Tipo == tipo)
                    item = it;
                break;
            }
            Console.WriteLine($"{item.Tipo} e {item.Qty}");
            return item;
        }
    }
}
