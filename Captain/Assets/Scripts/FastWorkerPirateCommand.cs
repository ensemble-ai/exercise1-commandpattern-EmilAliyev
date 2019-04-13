using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

namespace Captain.Command
{
    public class FastWorkerPirateCommand : WorkPirateCommand, IPirateCommand
    {
        private const float PRODUCTION_TIME = 2.0f; //Interval in which items are produced
        private const float MIN_WORK_DURATION = 5.0f; //Minimum work duration
        private const float MAX_WORK_DURATION = 10.0f; //Maximum work duration

        public FastWorkerPirateCommand()
        {

            productionTime = PRODUCTION_TIME;
            minWorkDuration = MIN_WORK_DURATION;
            maxWorkDuration = MAX_WORK_DURATION;

            //Total duration: 20-40s (picked randomly)
            totalWorkDuration = MIN_WORK_DURATION;

        }

        //Produce item if interval is up
        public void produceItem(GameObject pirate, Object itemPrefab)
        {
            //If interval is up
            if (workSinceProduction >= PRODUCTION_TIME)
            {
                workSinceProduction = 0;

                ItemCreator.produceItem(pirate, itemPrefab);
            }
        }

        //Work for 5-10s and produce 1 item every 2s. 
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