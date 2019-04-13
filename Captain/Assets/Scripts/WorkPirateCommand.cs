using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Captain.Command
{

    public class WorkPirateCommand : ScriptableObject, IPirateCommand
    {
        protected float totalWorkDuration; //Duration to work
        protected float totalWorkDone; //Total amount of work done
        protected float workSinceProduction; //Work done since last time an item was produced
        protected float productionTime; //Interval in which items are produced
        protected float minWorkDuration; //Minimum work duration
        protected float maxWorkDuration; //Maximum work duration
        protected bool exhausted = false;

        protected WorkPirateCommand()
        {
            //Initialize variables
            totalWorkDone = 0;
            workSinceProduction = 0;

            exhausted = false;
        }

        protected void OnEnable()
        {
            //Randomly set total work duration according to min and max
            totalWorkDuration = Random.Range(minWorkDuration, maxWorkDuration);
        }

        //Check if work is done
        protected bool workDone()
        {
            if (totalWorkDone >= totalWorkDuration)
            {
                exhausted = true;
                return true;
            }
            return false;
        }

        //Produce item if interval is up
        protected void produceItem(GameObject pirate, Object itemPrefab)
        {
            //If interval is up
            if (workSinceProduction >= productionTime)
            {
                workSinceProduction = 0;

                //Create item
                ItemCreator.produceItem(pirate, itemPrefab);
            }
        }

        //Work for duration and create item according to production interval
        public bool Execute(GameObject pirate, Object productPrefab)
        {
            //If not exhausted
            if (!exhausted)
            {
                produceItem(pirate, productPrefab);

                //Add time since last frame to work done
                totalWorkDone += Time.deltaTime;
                workSinceProduction += Time.deltaTime;

                workDone();

                return true;
            }

            else
            {
                return false;
            }

        }
    }
}