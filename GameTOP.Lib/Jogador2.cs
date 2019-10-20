using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Pelé esta Chutando \n";
        }

        public string Corre()
        {
            return "Pelé esta Correndo\n";
        }

        public string Passa()
        {
            return "Pelé esta Passando\n";
        }
    }
}