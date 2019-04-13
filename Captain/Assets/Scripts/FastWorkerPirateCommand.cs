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


        }

    }

}