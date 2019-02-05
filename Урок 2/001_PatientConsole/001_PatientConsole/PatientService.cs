using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientConsole;
using PatientRecords;

namespace PatientConsole
{
    public class PatientService
    {
        public void SaveAndDisplayPatient(Patient patient)
        {
            Patient.Save(patient);

            Patient loadedPatient = Patient.Load(patient.SSN);

            OutputPatient(loadedPatient);
        }

        private void OutputPatient(Patient loadedPatient)
        {
            Console.WriteLine(loadedPatient.FName);
            Console.WriteLine(loadedPatient.LName);
            Console.WriteLine(loadedPatient.DOB.ToShortDateString());
            Console.WriteLine(loadedPatient.SSN);
            Console.WriteLine("{0}, {1} {2}", loadedPatient.Rsx[0].DrugId, loadedPatient.Rsx[0].Dose, loadedPatient.Rsx[0].DoseUnit);
        }
    }
}
