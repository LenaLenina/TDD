using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRecords
{
    public class Prescription
    {
        public int DrugId { get; set; }
        public int Dose { get; set; }
        public string DoseUnit { get; set; }
    }
}
