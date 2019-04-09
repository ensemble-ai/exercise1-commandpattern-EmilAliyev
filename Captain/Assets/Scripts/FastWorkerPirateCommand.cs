using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

namespace Captain.Command
{
    public class FastWorkerPirateCommand : ScriptableObject, IPirateCommand
    {
        //Work for 5-10s and produce 1 item every 2s.

        public bool Execute(GameObject pirate, Object productPrefab)
        {
            throw new System.NotImplementedException();
        }
    }

}