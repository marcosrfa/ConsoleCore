using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFoda{
        public iJogador _jogadorA;
        public iJogador _jogadorB;
        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }

        public void IniciarJogo(){
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passa());

System.Console.Write("\n Próximo Jogador \n\n");
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passa());
        }
    }
}