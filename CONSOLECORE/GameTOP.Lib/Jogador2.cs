using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Kob esta chutando";
        }

        public string Corre()
        {
            return "Kob esta correndo";
        }

        public string Passe()
        {
            return "Kob esta passando";
        }
    }
}