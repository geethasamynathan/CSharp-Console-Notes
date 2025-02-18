# **Function Overloading in C# – Real-World Example**

## **📌 Introduction**
**Function overloading** is a feature in C# that allows multiple methods to have the **same name** but **different parameters (type, number, or order).** This helps in improving **code readability** and **reusability**.

---

## **🏥 Real-World Example: Hospital Patient Management System**
Let's consider a **Hospital Management System** where:
- We **register patients** using different inputs.
- We **handle different cases** like **emergency patients, VIP patients, and normal patients**.
- **Method overloading** is used to allow **different ways of adding a patient**.

---

## **✅ Step 1: Create the `Patient` Class**
The **Patient class** contains properties like:
- `PatientId`
- `Name`
- `Age`
- `Condition`
- `IsEmergency`
- `DoctorAssigned`

```csharp
namespace HospitalManagement
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Condition { get; set; }
        public bool IsEmergency { get; set; }
        public string DoctorAssigned { get; set; }

        public Patient(int patientId, string name, int age, string condition, bool isEmergency, string doctorAssigned)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            Condition = condition;
            IsEmergency = isEmergency;
            DoctorAssigned = doctorAssigned;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}, Condition: {Condition}, Emergency: {IsEmergency}, Doctor: {DoctorAssigned}");
        }
    }
}
```

---

## **✅ Step 2: Implement Function Overloading in `Hospital` Class**
📌 **We overload the `RegisterPatient` method to handle different scenarios**:
1. **Basic Registration (Name, Age)**
2. **Registration with Medical Condition**
3. **Emergency Registration**
4. **VIP Patient Registration with Doctor Assignment**

```csharp
using System;
using System.Collections.Generic;

namespace HospitalManagement
{
    public class Hospital
    {
        private List<Patient> _patients = new List<Patient>();
        private int _nextPatientId = 1;

        // ✅ Overloaded method - Register patient with basic details
        public void RegisterPatient(string name, int age)
        {
            var patient = new Patient(_nextPatientId++, name, age, "General Checkup", false, "General Physician");
            _patients.Add(patient);
            Console.WriteLine($"Patient Registered: {name}, Assigned to General Physician.");
        }

        // ✅ Overloaded method - Register patient with medical condition
        public void RegisterPatient(string name, int age, string condition)
        {
            var patient = new Patient(_nextPatientId++, name, age, condition, false, "Specialist");
            _patients.Add(patient);
            Console.WriteLine($"Patient Registered: {name}, Condition: {condition}, Assigned to Specialist.");
        }

        // ✅ Overloaded method - Emergency registration
        public void RegisterPatient(string name, int age, string condition, bool isEmergency)
        {
            var doctor = isEmergency ? "Emergency Doctor" : "General Physician";
            var patient = new Patient(_nextPatientId++, name, age, condition, isEmergency, doctor);
            _patients.Add(patient);
            Console.WriteLine($"Emergency Patient Registered: {name}, Assigned to {doctor}.");
        }

        // ✅ Overloaded method - VIP Patient Registration
        public void RegisterPatient(string name, int age, string condition, bool isEmergency, string doctorAssigned)
        {
            var patient = new Patient(_nextPatientId++, name, age, condition, isEmergency, doctorAssigned);
            _patients.Add(patient);
            Console.WriteLine($"VIP Patient Registered: {name}, Assigned to {doctorAssigned}.");
        }

        // Display all registered patients
        public void DisplayPatients()
        {
            Console.WriteLine("\nRegistered Patients:");
            foreach (var patient in _patients)
            {
                patient.DisplayInfo();
            }
        }
    }
}
```

---

## **✅ Step 3: Test the Overloaded Methods**
```csharp
using System;

class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital();

        // ✅ Register normal patient
        hospital.RegisterPatient("Alice Johnson", 30);
        
        // ✅ Register patient with a condition
        hospital.RegisterPatient("Bob Smith", 45, "Diabetes");
        
        // ✅ Register emergency patient
        hospital.RegisterPatient("Charlie Brown", 50, "Heart Attack", true);
        
        // ✅ Register VIP patient
        hospital.RegisterPatient("David Lee", 60, "Cancer", false, "Dr. Anderson");

        // Display all registered patients
        hospital.DisplayPatients();
    }
}
```

---

## **📌 Expected Output**
```
Patient Registered: Alice Johnson, Assigned to General Physician.
Patient Registered: Bob Smith, Condition: Diabetes, Assigned to Specialist.
Emergency Patient Registered: Charlie Brown, Assigned to Emergency Doctor.
VIP Patient Registered: David Lee, Assigned to Dr. Anderson.

Registered Patients:
Patient ID: 1, Name: Alice Johnson, Age: 30, Condition: General Checkup, Emergency: False, Doctor: General Physician
Patient ID: 2, Name: Bob Smith, Age: 45, Condition: Diabetes, Emergency: False, Doctor: Specialist
Patient ID: 3, Name: Charlie Brown, Age: 50, Condition: Heart Attack, Emergency: True, Doctor: Emergency Doctor
Patient ID: 4, Name: David Lee, Age: 60, Condition: Cancer, Emergency: False, Doctor: Dr. Anderson
```

---

## **📌 Key Takeaways**
### ✅ **What Function Overloading Does?**
✔ **Provides flexibility** – We can register patients in **multiple ways**.  
✔ **Improves code readability** – The method name `RegisterPatient` remains the same, but different inputs make it behave differently.  
✔ **Reduces code duplication** – Instead of creating different methods for each patient type, we **overload one method**.  

### ❌ **What to Avoid?**
❌ **Do not create too many overloads** with similar parameters, as it may lead to confusion.  
❌ **Do not use overloading where optional parameters (`default values`) can be used.**  

---

## **📌 Next Steps**
Would you like:
- A **Web API version** where patient registration happens via **REST API calls**?  
- Adding **database integration (Entity Framework Core)**?  
- Implementing **unit tests** to validate the overloaded methods?  

🚀 **Let me know how you want to extend this!** 🚀
