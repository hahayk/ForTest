using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceElectronics
{
    class VacumCleaner : ElectronicEquipment
    {
        public string Nasadka { get; set; }
        public bool VacumBlow { get; set; } //քաշել, փչել
        public string BodyColor { get; set; }
    }
}
