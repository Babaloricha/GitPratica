using System;
using System.Collections.Generic;
using System.Text;

namespace Praticas
{
    class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Classificao Nota {get;set;}

        public Jogo(int id, string nome, Classificao nota)
        {
            Id = id;
            Nome = nome;
            Nota = nota;
        }
    }

    public enum Classificao
    {
        orrivel = 0,
        ruim = 1,
        meh =2,
        bom = 3,
        perfeito = 4
    }
}
