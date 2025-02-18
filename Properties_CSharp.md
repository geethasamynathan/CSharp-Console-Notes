# **Properties in C# 12.0**

## **📌 What are Properties in C# 12.0?**
In **C# 12.0**, properties are **specialized class members** that provide **controlled access** to private fields. They allow you to encapsulate **data retrieval and modification** while enforcing **validation** and **encapsulation principles**.

---

## **🔹 Key Features of Properties**
- **Encapsulate fields** and expose only necessary data.
- **Validation logic** can be added within getters and setters.
- **Automatic properties** (`get; set;`) reduce boilerplate code.
- **Readonly properties** (`get; init;`) make objects immutable after initialization.
- **Computed properties** allow on-the-fly calculations.

---

## **📌 When to Use Properties?**
| **Scenario** | **Use Properties?** |
|-------------|------------------|
| **Encapsulating data with validation** | ✅ Yes |
| **Providing computed values** | ✅ Yes |
| **Exposing a field directly** | ❌ No |
| **Making an object immutable after creation** | ✅ Yes (`get; init;`) |
| **Creating a DTO (Data Transfer Object)** | ❌ No (use fields or public properties without logic) |

---

## **🔍 Does C# Create Private Fields Internally for Properties?**
### ✅ **Auto-Implemented Properties (`get; set;`)**
If you **don’t manually define a private field**, C# **creates a hidden private backing field** internally.

#### **Example:**
```csharp
public class Person
{
    public string Name { get; set; }  // C# internally creates a private field
}
```
✅ Equivalent to:
```csharp
private string _name;
public string Name 
{
    get => _name;
    set => _name = value;
}
```
✔ **No need to define `_name` manually**—C# handles it internally!

---

## **📌 Real-World Scenarios of Properties in C# 12.0**

### **🔹 1️⃣ Bank Account System (Encapsulation & Validation)**
```csharp
public class BankAccount
{
    private decimal _balance; // Manually defined private field

    public string AccountNumber { get; }  // Read-only property (set once)

    public decimal Balance
    {
        get => _balance;  // Encapsulated access
        private set  // Restricted modification
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be negative!");
            _balance = value;
        }
    }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount) => Balance += amount;
    public bool Withdraw(decimal amount)
    {
        if (amount > Balance) return false;
        Balance -= amount;
        return true;
    }
}
```
✔ **Encapsulated Balance**  
✔ **Validation on negative balances**  
✔ **Read-only AccountNumber**  

---

### **🔹 2️⃣ Employee Management System (Computed Property)**
```csharp
public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Computed property
    public string FullName => $"{FirstName} {LastName}";

    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
```
✔ **FullName is computed dynamically**  
✔ **No need for a backing field**  

---

### **🔹 3️⃣ Immutable User Profile (`get; init;` in C# 12.0)**
```csharp
public class User
{
    public string Username { get; init; }
    public string Email { get; init; }
}
```
✔ **Once set in the constructor, properties cannot be changed**  
✔ **Great for immutable data models (DTOs, Configurations, etc.)**  

**Example Usage:**
```csharp
var user = new User { Username = "JohnDoe", Email = "john@example.com" };
// user.Username = "NewName"; ❌ ERROR: Cannot modify 'init' property
```

---

### **🔹 4️⃣ Real Estate Property (Auto-Implemented Properties)**
```csharp
public class House
{
    public string Address { get; set; }
    public decimal Price { get; set; }
    public int Bedrooms { get; set; }
}
```
✔ **C# internally creates private fields for `Address`, `Price`, `Bedrooms`**  
✔ **Easy data encapsulation**  

---

## **📌 Summary**
| **Feature** | **Example** |
|------------|------------|
| **Encapsulating data with validation** | `Balance` in `BankAccount` |
| **Computed property** | `FullName` in `Employee` |
| **Immutable objects** | `User` with `get; init;` |
| **Auto-implemented properties** | `House` class |

---

## **🔍 Key Takeaways**
- **Auto-implemented properties** create **hidden private fields**.
- **Computed properties** don’t need backing fields.
- **`get; init;`** makes objects **immutable after initialization**.
- **Use properties** for encapsulation, validation, and computed values.

---

## **✨ Next Steps**
Would you like:
- A **.NET Web API version** of these examples?
- Adding **unit tests** for better coverage?
- More **real-world scenarios** like **E-commerce, Healthcare, etc.?** 🚀
