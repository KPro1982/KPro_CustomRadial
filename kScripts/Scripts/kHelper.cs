using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace kScripts
{
    public static class kHelper
    {
        public static void ChatOutput(EntityPlayer _entityPlayer, string msg)
        {
            GameManager.Instance.ChatMessageServer(_cInfo: null, _chatType: EChatType.Global, _senderEntityId: _entityPlayer.entityId, _msg: msg, _mainName: _entityPlayer.EntityName, _localizeMain: false, _recipientEntityIds: null);
        }

        private static string BuildConsoleCommand(Vector3i _location, bool _onground)
        {
            string outputStr = "";

            if (_onground)
            {
                outputStr = string.Format("teleport {0} {1} ", _location.x, _location.z);
            }
            else
            {
                outputStr = string.Format("teleport {0} {1} {2}", _location.x, _location.y, _location.z);
            }

            return outputStr;
        }
        public static void Teleport(Vector3i targetLocation, bool onGround = true)
        {
            SingletonMonoBehaviour<SdtdConsole>.Instance.ExecuteSync(BuildConsoleCommand(targetLocation, onGround), null);
        }
        public static string GetSavedGameDirectory() 
        {
            string saveDirectoryStr = GameUtils.GetSaveGameDir(null, null);
            LogAnywhere.Log(string.Format("Saved game directory: {0}", saveDirectoryStr),true);
            return saveDirectoryStr;
        }
    }
}
