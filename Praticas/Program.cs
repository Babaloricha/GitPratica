using System;
using System.Collections.Generic;

namespace Praticas
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaJogos = new List<Jogo>();


            listaJogos.Add(new Jogo(1, "WarZone", Classificao.perfeito));
            listaJogos.Add(new Jogo(2, "MineCraft", Classificao.bom));
            listaJogos.Add(new Jogo(3, "League of Legends", Classificao.bom));

        }
    }
}
