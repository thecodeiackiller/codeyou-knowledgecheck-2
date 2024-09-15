using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_check2_project
{
    internal class Equipment
    {
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }


        public override string ToString()
        {
            return $"Equpment Id: {EquipmentID}, Equipment Name: {EquipmentName}"; 
        }
    }
}
