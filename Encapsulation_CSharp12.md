# **Encapsulation in C# 12.0 (Real-World Example)**

Encapsulation is one of the fundamental principles of **Object-Oriented Programming (OOP)**. It is the practice of **hiding the internal state and requiring all interactions to be performed through methods**.

---

## **🏦 Real-World Scenario: Banking System**
Let's consider a **Bank Account System**, where:
- We **hide** account details from direct access.
- We **expose** only necessary operations like **Deposit, Withdraw, and GetBalance**.

---

## **✅ Do's and ❌ Don'ts of Encapsulation**
### **✅ Do's**
✔️ **Use `private` fields** to store data.  
✔️ **Expose controlled access** using `public` properties.  
✔️ **Validate inputs** in setters to avoid invalid data.  
✔️ **Use `readonly` for unmodifiable fields** after initialization.  
✔️ **Follow naming conventions (`_camelCase` for private fields, PascalCase for properties).**  

### **❌ Don'ts**
❌ **Avoid public fields**, which break encapsulation.  
❌ **Do not expose internal logic** that users don’t need to see.  
❌ **Avoid direct access to fields**—always use properties/methods.  
❌ **Do not mix multiple responsibilities in a class.**  

---

## **🔹 Encapsulation Example: Secure Bank Account in C# 12.0**
```csharp
using System;

namespace BankApp
{
    public class BankAccount
    {
        private readonly string _accountNumber; // Cannot be modified after initialization
        private string _accountHolder;
        private decimal _balance;

        // Constructor
        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _balance = initialBalance > 0 ? initialBalance : throw new ArgumentException("Initial balance must be positive");
        }

        // Encapsulated property with validation
        public string AccountHolder
        {
            get => _accountHolder;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Account holder name cannot be empty.");
                _accountHolder = value;
            }
        }

        // Read-only property
        public string AccountNumber => _accountNumber;

        // Read-only balance property (no public setter)
        public decimal Balance => _balance;

        // Encapsulated method for deposit
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            _balance += amount;
            Console.WriteLine($"Deposited: {amount:C}, New Balance: {_balance:C}");
        }

        // Encapsulated method for withdrawal with validation
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (amount > _balance)
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }

            _balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}, Remaining Balance: {_balance:C}");
            return true;
        }

        // Encapsulated method to display account details
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Holder: {AccountHolder}, Balance: {Balance:C}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an encapsulated BankAccount object
            var account = new BankAccount("1234567890", "John Doe", 5000);
            account.DisplayAccountInfo();

            account.Deposit(1500);
            account.Withdraw(2000);
            
            // Trying to set an invalid name (this will throw an exception)
            try
            {
                account.AccountHolder = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Trying to withdraw an amount greater than balance
            account.Withdraw(10000);

            account.DisplayAccountInfo();
        }
    }
}
```

---

## **📌 Output**
```
----------------------------------------
Account Number: 1234567890, Holder: John Doe, Balance: $5,000.00
Deposited: $1,500.00, New Balance: $6,500.00
Withdrawn: $2,000.00, Remaining Balance: $4,500.00
Error: Account holder name cannot be empty.
Insufficient balance.
Account Number: 1234567890, Holder: John Doe, Balance: $4,500.00
```

---

## **🔍 Key Takeaways**
### ✅ **What this example does right?**
✔ **Encapsulates** `_balance` using `private` access.  
✔ **Restricts modification** of `_accountNumber` by making it `readonly`.  
✔ **Validates** the input in the **setter** of `AccountHolder`.  
✔ **Prevents negative deposits/withdrawals** in methods.  
✔ **Uses read-only properties (`Balance`, `AccountNumber`)** to restrict direct modification.  

### ❌ **What you should avoid?**
❌ **Do not expose private fields directly** (e.g., `_balance`).  
❌ **Do not allow negative balance withdrawals** without validation.  
❌ **Do not create public setters for sensitive fields like `AccountNumber`**.  

---

## **📌 When to Use Encapsulation?**
| Scenario | Use Encapsulation? |
|-----------|------------------|
| **Banking System (Protect account details, transactions)** | ✅ Yes |
| **Healthcare (Patient data privacy)** | ✅ Yes |
| **E-commerce (Restrict direct modification of order details)** | ✅ Yes |
| **Simple DTOs (Data Transfer Objects)** | ❌ No (They are meant to be simple data containers) |

---

### **Conclusion**
Encapsulation is **critical** for building **secure and maintainable** applications. By **hiding internal details** and **exposing only necessary operations**, we ensure **data integrity, security, and better maintainability**.

---

