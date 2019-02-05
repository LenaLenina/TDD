using System;
using NUnit.Framework;
using Microsoft.QualityTools.Testing.Fakes;
using PatientRecords.Fakes;
using PatientRecords;
using PatientConsole;
using System.Collections.Generic;

namespace _003_PatientRecordsTests
{
    [TestFixture]
    class PatientServiceTest
    {
        [Test]
        public void SaveAndDisplayPatient_SavesThePatient()
        {
            Patient patient = new Patient();
            patient.FName = "John";
            patient.LName = "Doe";
            patient.DOB = new DateTime(1990, 01, 02);
            patient.SSN = "123456789";
            patient.Rsx = new List<Prescription>();
            patient.Rsx.Add(new Prescription { DrugId = 123, Dose = 25, DoseUnit = "mg" });
            patient.Rsx.Add(new Prescription { DrugId = 456, Dose = 50, DoseUnit = "mg" });

            Patient savedPatient = null;

            using (ShimsContext.Create())
            {
                ShimPatient.SavePatient = (patientParam) => { savedPatient = patientParam; };
                ShimPatient.LoadString = (ssn) => { return new Patient { Rsx = new List<Prescription> { new Prescription() } }; };
                new PatientService().SaveAndDisplayPatient(patient);
            }

            Assert.AreSame(patient, savedPatient);
        }
    }
}
