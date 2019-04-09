using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

namespace Captain.Command
{
    public class NormalWorkerPirateCommand : ScriptableObject, IPirateCommand
    {
        //Work for 10-20s and produce 1 item every 4s.

        public bool Execute(GameObject pirate, Object productPrefab)
        {
            throw new System.NotImplementedException();
        }
    }

}