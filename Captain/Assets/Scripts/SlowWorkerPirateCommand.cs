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

        }

    }

}