
# My Address Book

My Address Book is a simple Blazor App that allows to their users to save their phone contacts.

## Prerequisites:

- Visual Studio 2022 Community Edition
- .NET 8
- Blazor

## How to Run

Just clone the code and Run the Migrations on the MyAddressBook.Data.SQLite project to create the database and seed the data

```bash
  Update-Database
```

Once DB is successfuly created, Start to Debug the MyAddressBook and MyAddressBook.BFF projects.

## Author Comments

Due Time constrain, I has focused on create a MVP of the solution. Ensuring a working Happy Path. Exception Handling in general require some work to ensure that all exceptions are handled.

Since there's no any Transformation or bussiness logic to thread, I decided to create a simple RESTFul API as Backend for FronEnd and calling repositories directly from there. The API doesn't includes OpenAPI implementation.