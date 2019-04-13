using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

namespace Captain.Command
{
    public class SlowWorkerPirateCommand : WorkPirateCommand, IPirateCommand
    {
        private const float PRODUCTION_TIME = 8.0f; //Interval in which items are produced
        private const float MIN_WORK_DURATION = 20.0f; //Minimum work duration
        private const float MAX_WORK_DURATION = 40.0f; //Maximum work duration

        public SlowWorkerPirateCommand()
        {

            productionTime = PRODUCTION_TIME;
            minWorkDuration = MIN_WORK_DURATION;
            maxWorkDuration = MAX_WORK_DURATION;

            //Total duration: 20-40s (picked randomly)
            totalWorkDuration = MIN_WORK_DURATION;

        }

        //Work for 20-40s and produce 1 item every 8s. Default command for pirates.
        public bool Execute(GameObject pirate, Object productPrefab)
        {
            produceItem(pirate, productPrefab);

            //Add time since last frame to work done
            totalWorkDone += Time.deltaTime;
            workSinceProduction += Time.deltaTime;

            return !workDone();
            
        }
    }

}