using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador {
        public readonly string _Nome;
        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        
        //Chuta
        public string Chuta () {
            return $"{_Nome} esta Chutando \n";
        }
        //Corre 
        public string Corre () {
            return $"{_Nome} esta Correndo \n";
        }
        //Passa
        public string Passa () {
            return $"{_Nome} esta Passando \n";
        }
    }
}