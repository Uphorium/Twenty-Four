using Rocket.API;

namespace CyTic.TwentyFour
{
    public class TwentyFourConfiguration : IRocketPluginConfiguration
    {

        public int max_players = 24;
        public bool enabled = true;

        public void LoadDefaults()
        {
			int max_players = 24;
			bool enabled = true;
        }
    }
}
