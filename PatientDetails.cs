using System;
using SampleConApp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworksApp
{
    class PatientDetails
    {
        public string PatientName { get; set; }
        public string Cause { get; set; }
        public int PatientId { get; set; }
        public string DiseaseName { get; set; }
        public string Severity { get; set; }

        public string SymptomName { get; set; }
        public string Description { get; set; }

        public void ShallowCopy(PatientDetails copy)
        {
            this.PatientId = copy.PatientId;
            this.PatientName = copy.PatientName;
            this.DiseaseName = copy.DiseaseName;
            this.Severity = copy.Severity;
            this.SymptomName = copy.SymptomName;
            this.Description = copy.Description;
            this.Cause = copy.Cause;
            
        }

        public PatientDetails DeepCopy(PatientDetails copy)
        {
            PatientDetails Patient = new PatientDetails();
            Patient.ShallowCopy(copy);
            return Patient;
        }
    }

    class PatientRepository
    {
        private PatientDetails[] Patient = null;
        private readonly int _size = 0;
        public PatientRepository(int size)
        {
            _size = size;
            Patient = new PatientDetails[_size];
        }

        public int AddDisease(PatientDetails patient)
        {
            for (int i = 0; i < _size; i++)
            {
                if (Patient[i] == null)
                {
                 
                    Patient[i] = patient.DeepCopy(patient);

                    return 1;//To exit
                }
            }
            return _size;
        }

        public void AddSymptom(PatientDetails patient)
        {
            for (int i = 0; i < _size; i++)
            {
                if (Patient[i] != null && Patient[i].PatientId ==patient.PatientId )
                {
                    Patient[i].ShallowCopy(patient);
                    return;//To exit
                }
            }
            throw new Exception("No PatientDetails Found to AddSymptoms");
        }

      

        public void CheckPatient(string symptom)
        {
           
            foreach (PatientDetails patient in Patient)
            {
                if (patient != null && patient.SymptomName.Contains(symptom))
                {
                   Console.WriteLine($" The Disease of the Patient is "+patient.DiseaseName);
                }
                throw new Exception("Invalid Symptoms are Entered");
            }
           
            return ;
        }

 
    }

    class UIComponent
    {
        public const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Medical Research Application Software~~~~~~~~~~~~~~~~~~~\nTO Add Disease Details------------------------>PRESS 1\nAdd Symptom to Disease---------------->PRESS 2\nCheck Patient Details----------------->PRESS 3";

        private static PatientRepository repo;

        public static void Run()
        {
            int size = SampleConApp.Utilities.GetNumber("Enter the no of Disease U need to Store");
            repo = new PatientRepository(size);
            bool processing = true;
            do
            {
                string choice = Utilities.Prompt(menu);
                processing = processMenu(choice);
            } while (processing);
            Console.WriteLine("Thanks for Using our Application!!!");
        }

        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    addingDiseaseHelper();
                    break;
                case "2":
                    addingSymptomHelper();
                    break;
                case "3":
                    findPatientHelper();
                    break;
                default:
                    return false;
            }
            return true;
        }
        private static void addingDiseaseHelper()
        {
           
           
            string diseaseName = Utilities.Prompt("Enter the Name of the Disease ");
            string severity = Utilities.Prompt("Enter the Severity of the Patient");
            string cause = Utilities.Prompt("Enter the Causes");
            string description = Utilities.Prompt("enter the description");
            PatientDetails pati = new PatientDetails {  DiseaseName =diseaseName , Severity = severity,Cause=cause ,Description= description };
            repo.AddDisease(pati);
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }

        private static void addingSymptomHelper()
        {
            string diseaseName = Utilities.Prompt("Enter the Name of the Disease ");
           
            string symptomName = Utilities.Prompt("Enter the SymptomName");

            string description = Utilities.Prompt("enter the description");
            PatientDetails pati = new PatientDetails {  DiseaseName = diseaseName,  SymptomName = symptomName,Description=description };
            repo.AddSymptom(pati);
           
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }
           

        private static void findPatientHelper()
        {
            //string name = Utilities.Prompt("Enter the Name of the Patient to find Detials");
            string symptom =Utilities.Prompt("Enter the Name of the Patient to find Detials");
            try
            {
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();

        }


    }
}
namespace Check
{
    class CheckDetails
    {
        static void Main(string[] args)
        {
            SampleFrameworksApp.UIComponent.Run();
        }
    }
}



