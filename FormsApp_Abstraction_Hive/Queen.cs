using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp_Abstraction_Hive
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftnumber = 0;

        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }

        public string WorkTheNextShift()
        {
            double honeyConsumed = HoneyConsumptionRate();

            shiftnumber++;
            string report = "Звіт для зміни#" + shiftnumber + "\r\n";

            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumed += workers[i].HoneyConsumptionRate();

                if (workers[i].DoYouFinish())
                    report += "Робочий №" + (i + 1) + " закінчив свою роботу\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Робочий №" + (i + 1) + " не працює\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                    report += "Робочий №" + (i + 1) + " виконує " + workers[i].CurrentJob + " ще " + workers[i].ShiftsLeft + " змін\r\n";
                else
                    report += "Робочий №" + (i + 1) + " закінчить " + workers[i].CurrentJob + " через " + workers[i].ShiftsLeft + " змін\r\n";
            }
            report += "Total honey consumed for the shift: " + honeyConsumed + " units \r\n";

            return report;
        }
    }
}
