using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kScripts
{
    class MinEventActionGoHome : MinEventActionBase
    {
		private EntityPlayer entityPlayer;
				
		public override void Execute(MinEventParams _params)
		{

			if (SingletonMonoBehaviour<ConnectionManager>.Instance.IsClient)
			{
				entityPlayer = GameManager.Instance.World.GetPrimaryPlayer();
				kTeleportObject teleportObject = new kTeleportObject();

				
					Vector3i returnV3i = entityPlayer.GetBlockPosition();

					if(teleportObject.TryGetLocation("home", out var targetV3i))
                    {
						teleportObject.Add("return", returnV3i);
						kHelper.Teleport(targetV3i);
					} else
                    {
						kHelper.ChatOutput(entityPlayer, "Cannot go home as there is no home location stored.");
                    }

				
			}
		}
	}
}
