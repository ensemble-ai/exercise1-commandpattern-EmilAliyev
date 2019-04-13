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

        }

    }

}