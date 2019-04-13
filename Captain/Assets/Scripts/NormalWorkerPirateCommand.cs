using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

namespace Captain.Command
{
    public class NormalWorkerPirateCommand : WorkPirateCommand, IPirateCommand
    {
        private const float PRODUCTION_TIME = 4.0f; //Interval in which items are produced
        private const float MIN_WORK_DURATION = 10.0f; //Minimum work duration
        private const float MAX_WORK_DURATION = 20.0f; //Maximum work duration

        public NormalWorkerPirateCommand()
        {

            productionTime = PRODUCTION_TIME;
            minWorkDuration = MIN_WORK_DURATION;
            maxWorkDuration = MAX_WORK_DURATION;

            //Total duration: 20-40s (picked randomly)
            totalWorkDuration = MIN_WORK_DURATION;

        }

        //Work for 10-20s and produce 1 item every 4s. 
        public bool Execute(GameObject pirate, Object productPrefab)
        {
            //Add time since last frame to work done
            totalWorkDone += Time.deltaTime;
            workSinceProduction += Time.deltaTime;

            produceItem(pirate, productPrefab);
            
            return !workDone();

        }
    }

}