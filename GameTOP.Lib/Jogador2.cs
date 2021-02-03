using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
           return "Maradona estas pateando \n";
        }

        public string Corre()
        {
            return "maradona estas corriendo \n";
        }

        public string Passe()
        {
            return "maradona esta pasando \n";
        }
    }
}