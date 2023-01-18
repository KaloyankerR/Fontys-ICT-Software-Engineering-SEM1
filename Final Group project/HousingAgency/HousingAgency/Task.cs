using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAgency
{
    internal class Task
    {
        private string assignedTenant;
        private string taskDescription;

        public Task(string assignedTenant, string taskDescription)
        {
            this.assignedTenant = assignedTenant;
            this.taskDescription = taskDescription;
        }

        public string GetInfo()
        {
            return $"{this.assignedTenant} - {this.taskDescription}";
        }
    }
}
