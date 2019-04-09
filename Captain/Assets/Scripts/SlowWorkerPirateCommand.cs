using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

namespace Captain.Command
{
    public class SlowWorkerPirateCommand : ScriptableObject, IPirateCommand
    {
        //Work for 20-40s and produce 1 item every 8s. Default command for pirates.

        public bool Execute(GameObject pirate, Object productPrefab)
        {
            throw new System.NotImplementedException();
        }
    }

}