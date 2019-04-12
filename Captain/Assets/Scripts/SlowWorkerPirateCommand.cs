using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

namespace Captain.Command
{
    public class SlowWorkerPirateCommand : ScriptableObject, IPirateCommand
    {
        private float totalWorkDuration; //Duration to work
        private float totalWorkDone; //Total amount of work done
        private float workSinceProduction; //Work done since last time an item was produced
        private const float PRODUCTION_TIME = 8.0f; //Interval in which items are produced
        private const float MIN_WORK_DURATION = 20.0f; //Minimum work duration
        private const float MAX_WORK_DURATION = 40.0f; //Maximum work duration
        private bool exhausted = false;

        public SlowWorkerPirateCommand()
        {
            //Initialize variables
            totalWorkDone = 0;
            workSinceProduction = 0;

            //Total duration: 20-40s (picked randomly)
            totalWorkDuration = MIN_WORK_DURATION;

        }

        //Check if work is done
        private bool workDone()
        {
            if(totalWorkDone >= totalWorkDuration)
            {
                exhausted = true;
                return true;
            }
            return false;
        }

        //Produce item if interval is up
        public void produceItem(GameObject pirate, Object itemPrefab)
        {
            //If interval is up
            if (workSinceProduction >= PRODUCTION_TIME)
            {
                workSinceProduction = 0;

                //Create item
                var item = (GameObject)Instantiate(itemPrefab, pirate.transform);
            }
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