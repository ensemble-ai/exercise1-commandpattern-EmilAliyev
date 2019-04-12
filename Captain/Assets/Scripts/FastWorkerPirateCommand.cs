using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

namespace Captain.Command
{
    public class FastWorkerPirateCommand : ScriptableObject, IPirateCommand
    {
        private float totalWorkDuration; //Duration to work
        private float totalWorkDone; //Total amount of work done
        private float workSinceProduction; //Work done since last time an item was produced
        private const float PRODUCTION_TIME = 2.0f; //Interval in which items are produced
        private const float MIN_WORK_DURATION = 5.0f; //Minimum work duration
        private const float MAX_WORK_DURATION = 10.0f; //Maximum work duration
        private bool exhausted = false;

        public FastWorkerPirateCommand()
        {
            //Initialize variables
            totalWorkDone = 0;
            workSinceProduction = 0;

            //Total duration: 10-20s (picked randomly)
            totalWorkDuration = MIN_WORK_DURATION;

        }

        //Check if work is done
        private bool workDone()
        {
            if (totalWorkDone >= totalWorkDuration)
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