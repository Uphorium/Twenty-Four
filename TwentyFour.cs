using Rocket.API.Collections;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using SDG.Unturned;

namespace CyTic.TwentyFour
{
    public class TwentyFour : RocketPlugin<TwentyFourConfiguration>
    {

		public int old_max;

		protected override void Load()
		{
			if (Configuration.Instance.loggingEnabled)
			{
				old_max = Provider.maxPlayers;
				Provider.maxPlayers = (byte)Configuration.Instance.maxPlayers;
				this.done();
			}
			else
			{
				Provider.maxPlayers = (byte)Configuration.Instance.maxPlayers;
			}
			Logger.Log("Successfully Loaded!");
		}

		public void done()
		{
			string message = Translate("TwentyFour_max_players_set", Configuration.Instance.maxPlayers, old_max);
			Logger.Log(message);
		}

		public override TranslationList DefaultTranslations
		{
			get
			{
				return new TranslationList()
				{
					{"TwentyFour_max_players_set", "max_players set to {0} from {1}"}
				};
			}
		}
	}
}
