using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_check2_project
{
    internal class Bat : Equipment
    {
        public string Style { get; set; }


        public override string ToString()
        {
            return $"{base.ToString()}, Bat Style: {Style}";
        }

    }

}
