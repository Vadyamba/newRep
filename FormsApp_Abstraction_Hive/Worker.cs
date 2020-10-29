using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp_Abstraction_Hive
{
    class Worker : Bee
    {
        const double honeyUnitsPerShift = 0.65;

        private string[] jobsCanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        private string currentJob = "";

        public Worker(string[] jobsCanDo, double weightMg) : base (weightMg)
        {
            this.jobsCanDo = jobsCanDo;
        }

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        override public double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * honeyUnitsPerShift;
            return consumption;
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsCanDo.Length; i++)
            {
                if (jobsCanDo[i] == job)
                {
                    currentJob = job;
                    shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool DoYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else return false;
        }
    }
}