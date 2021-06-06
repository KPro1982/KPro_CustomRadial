using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace kScripts
{
   

    public class MyGameClass : MonoBehaviour
    {
        // A Light used in the Scene and needed by MyGameMethod().
        public Light light;

        void MyGameMethod()
        {
            // Message with a GameObject name.
            Debug.Log("Hello: " + gameObject.name);

            // Message with light type. This is an Object example.
            Debug.Log(light.type);

            // Message using rich text.
            Debug.Log("<color=red>Error: </color>AssetBundle not found");
        }
    }
}
