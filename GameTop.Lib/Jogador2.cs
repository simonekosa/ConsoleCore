using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona Estás pateando \n";
        }

        public string Corre()
        {
            return "Maradona Estás corriendo \n";
        }

        public string Passe()
        {
            return "Maradona Estás pasando \n";
        }
    }
}