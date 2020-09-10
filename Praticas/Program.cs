using System;
using System.Collections.Generic;

namespace Praticas
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaJogos = new List<Jogo>();

            monitora("inicio");
            listaJogos.Add(new Jogo(1, "WarZone", Classificao.perfeito));
            listaJogos.Add(new Jogo(2, "MineCraft", Classificao.bom));
            listaJogos.Add(new Jogo(3, "League of Legends", Classificao.bom));
            listaJogos.Add(new Jogo(4, "WarZone", Classificao.perfeito));
            listaJogos.Add(new Jogo(5, "MineCraft", Classificao.bom));
            listaJogos.Add(new Jogo(6, "League of Legends", Classificao.bom));
            listaJogos.Add(new Jogo(4, "CS", Classificao.ruim));
            listaJogos.Add(new Jogo(7, "The Sims", Classificao.bom));
            monitora("fim");

        }


        public static void monitora(string msg)
        {
            var tempo = DateTime.Now.ToString();
            Console.WriteLine($"{tempo} - {msg} - {(int)Classificao.bom}");
            Console.WriteLine("1");
        }
    }
}
