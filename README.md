🏦 Bank Management System (Console App)
🛠 Overview
This is a fully self-developed desktop banking application created by me to practice C# syntax and explore advanced algorithms and data structures. The system was designed to simulate real-world banking operations and includes core banking features implemented using .NET Framework (C#).

The application is console-based and leverages in-memory data structures along with persistent storage (optional for advanced use) to manage clients, accounts, certificates, and loans.

✨ Key Features
👤 Customer Management
Create, edit, and delete customer profiles.

Manage multiple accounts per customer.

💳 Account Management
Open accounts with various types (savings, current, etc.).

Deposit and withdraw money.

Check account balances.

🏦 Certificates of Deposit
Issue certificates with different types (e.g., 1 year, 3 years, 5 years).

Automatically calculate and distribute profits based on the certificate type.

Profit distribution is triggered manually via a single button press, utilizing C# cursors to iterate through all certificates and:

Deposit profit into customer accounts.

Deduct total distributed profit from the bank’s main account.

💸 Loans Management
Issue new loans to customers.

Set loan terms, interest rates, and repayment schedules.

Track loan balances and repayments.

📈 Profit & Transactions
Profit Distribution: At the end of each period, profits from certificates are distributed based on certificate type.

Bank Account Tracking: When a certificate is opened, its amount is automatically deposited into the bank’s main account.

Full transaction logging (for deposits, withdrawals, loans, and certificate operations).

🧮 Special Implementation
Profit distribution logic is handled using a cursor-like approach in C# that simulates iterating over large datasets and applying business logic in batch mode.

Emphasis on algorithmic problem-solving and data flow control, giving me deep practice with loops, conditions, and modular C# code design.

✅ Additional Features
Account statement generation.

Detailed reports for:

Active certificates.

Outstanding loans.

Customer balances.

Simple, easy-to-use console navigation.

Fully object-oriented design with separation of concerns (Accounts, Loans, Certificates, Customers as different classes).

🚀 Technologies Used
.NET Framework (C#)

Console Application

⚠️ Important Notice
This application is intended for learning and practice purposes only and is not used in a real-world banking environment. It was developed as part of my journey to master C# programming and understand complex business logic, especially financial algorithms.

Developer: Nasser L Barbary

