﻿using System;
using GameTOP.Lib;

namespace GameTOP {
    class Program {
        static void Main (string[] args) {
            var jogo = new JogoFoda (new Jogador1("Marcos"), new Jogador3());
            jogo.IniciarJogo ();
        }
    }
}