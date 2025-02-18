# **🏥 Real-World Healthcare System in C# (Using OOP Concepts)**  

## **📌 Concepts Covered:**
- **Encapsulation** ✅  
- **Abstraction** ✅  
- **Inheritance** ✅  
- **Polymorphism** ✅  
- **Primary Constructor (C# 12.0)** ✅  

---

## **🔹 Step 1: Without Primary Constructor (Traditional Approach)**
📌 **Scenario:**  
A **Healthcare System** that manages patient records, doctor details, and appointment scheduling.

### **📌 Project Structure**
```
HealthcareSystem/
│-- Models/
│   ├── Person.cs (Base Class)
│   ├── Patient.cs (Derived from Person)
│   ├── Doctor.cs (Derived from Person)
│   ├── Appointment.cs (Uses Encapsulation & Abstraction)
│-- Program.cs
```

---

## **🔹 Step 2: Define the Base Class (`Person.cs`)**
```csharp
namespace HealthcareSystem.Models
{
    public class Person
    {
        private string _name;
        private int _age;
        private string _gender;

        public Person(string name, int age, string gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }

        public string Name => _name;
        public int Age => _age;
        public string Gender => _gender;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Gender: {_gender}");
        }
    }
}
```

---

## **🔹 Step 3: Define `Patient.cs` (Encapsulation & Inheritance)**
```csharp
namespace HealthcareSystem.Models
{
    public class Patient : Person
    {
        private string _patientId;
        private string _medicalHistory;

        public Patient(string name, int age, string gender, string patientId, string medicalHistory)
            : base(name, age, gender)
        {
            _patientId = patientId;
            _medicalHistory = medicalHistory;
        }

        public string PatientId => _patientId;
        public string MedicalHistory => _medicalHistory;

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Patient ID: {_patientId}, Medical History: {_medicalHistory}");
        }
    }
}
```

---

## **🔹 Step 4: Define `Doctor.cs` (Encapsulation & Polymorphism)**
```csharp
namespace HealthcareSystem.Models
{
    public class Doctor : Person
    {
        private string _doctorId;
        private string _specialization;

        public Doctor(string name, int age, string gender, string doctorId, string specialization)
            : base(name, age, gender)
        {
            _doctorId = doctorId;
            _specialization = specialization;
        }

        public string DoctorId => _doctorId;
        public string Specialization => _specialization;

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doctor ID: {_doctorId}, Specialization: {_specialization}");
        }
    }
}
```

---

## **🔹 Step 5: Define `Appointment.cs` (Abstraction & Encapsulation)**
```csharp
namespace HealthcareSystem.Models
{
    public class Appointment
    {
        private readonly string _appointmentId;
        private readonly Patient _patient;
        private readonly Doctor _doctor;
        private readonly DateTime _appointmentDate;

        public Appointment(string appointmentId, Patient patient, Doctor doctor, DateTime appointmentDate)
        {
            _appointmentId = appointmentId;
            _patient = patient;
            _doctor = doctor;
            _appointmentDate = appointmentDate;
        }

        public string AppointmentId => _appointmentId;
        public Patient Patient => _patient;
        public Doctor Doctor => _doctor;
        public DateTime AppointmentDate => _appointmentDate;

        public void DisplayAppointment()
        {
            Console.WriteLine($"Appointment ID: {_appointmentId}");
            Console.WriteLine($"Patient: {_patient.Name}, Doctor: {_doctor.Name}");
            Console.WriteLine($"Appointment Date: {_appointmentDate}");
        }
    }
}
```

---

## **🔹 Step 6: `Program.cs` (Main Entry)**
```csharp
using System;
using HealthcareSystem.Models;

class Program
{
    static void Main()
    {
        Patient patient = new Patient("John Doe", 30, "Male", "P1001", "Diabetes");
        Doctor doctor = new Doctor("Dr. Smith", 45, "Male", "D2001", "Cardiology");
        Appointment appointment = new Appointment("A3001", patient, doctor, DateTime.Now.AddDays(2));

        Console.WriteLine("Patient Details:");
        patient.DisplayInfo();
        Console.WriteLine("\nDoctor Details:");
        doctor.DisplayInfo();
        Console.WriteLine("\nAppointment Details:");
        appointment.DisplayAppointment();
    }
}
```

---

## **🔹 Step 7: Using Primary Constructor in C# 12.0**
### **Convert `Person.cs` to Use Primary Constructor**
```csharp
namespace HealthcareSystem.Models
{
    public class Person(string name, int age, string gender)
    {
        public string Name { get; } = name;
        public int Age { get; } = age;
        public string Gender { get; } = gender;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }
    }
}
```

---

## **📌 Benefits of Primary Constructor**
### ✅ **Pros**
✔ **Reduces boilerplate code**.  
✔ **More readable & concise**.  
✔ **Properties get initialized inline**.  
✔ **Improves maintainability**.  

### ❌ **Cons**
❌ **Not suitable for all classes** (e.g., large constructors).  
❌ **Complex business logic in constructor isn't ideal**.  

---

## **📌 Summary**
| Feature | Without Primary Constructor | With Primary Constructor |
|---------|----------------------------|-------------------------|
| **Encapsulation** | ✅ | ✅ |
| **Abstraction** | ✅ | ✅ |
| **Inheritance** | ✅ | ✅ |
| **Polymorphism** | ✅ | ✅ |
| **Boilerplate Code** | More | Less |
| **Readability** | Standard | Improved |

---

## **📌 Next Steps**
Would you like:
- **Extend this as an ASP.NET Web API?**
- **Add database integration using Entity Framework?**  
- **Implement Unit Tests?**  

🚀 **Let me know how you'd like to extend this further!** 🚀
