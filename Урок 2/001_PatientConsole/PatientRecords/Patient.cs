using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace PatientRecords
{
    public class Patient
    {
        public string SSN { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DOB { get; set; }
        public List<Prescription> Rsx { get; set; }

        public static Patient Load(string ssn)
        {
            string serPat = File.ReadAllText("./" + ssn + ".txt");
            return new JavaScriptSerializer().Deserialize<Patient>(serPat);
        }

        public static void Save(Patient patient)
        {
            string serPat = new JavaScriptSerializer().Serialize(patient);
            TextWriter tw = new StreamWriter("./" + patient.SSN + ".txt", false);
            tw.Write(serPat);
            tw.Close();
        }
    }
}
