using Rocket.API;

namespace CyTic.TwentyFour
{
    public class TwentyFourConfiguration : IRocketPluginConfiguration
    {

		public int maxPlayers;
		public bool loggingEnabled;

        public void LoadDefaults()
        {
			maxPlayers = 24;
			loggingEnabled = true;
        }
    }
}
