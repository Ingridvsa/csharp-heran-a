using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5.Rpg.Models
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Mana { get; set; }

        public Personagem(string nome, int mana)
        {
            Nome = nome;
            Mana = mana;
        }
    }
}