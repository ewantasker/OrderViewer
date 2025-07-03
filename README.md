# Order Viewer application

In this application, it contains a single page.
In the single it shows the filters and the table that will display the orders.

It is built in the following tech stack
- ASP.NET Core MVC with C#
- T-SQL

The editor used was Visual Studio 2022.

The filters section consist of the following:
- Date Range (Start and End)
- Status
- Min Total
- Max Total

The table will consist of the following columns:
- Order Id
- Customer
- Status
- Total
- Created
- There will be an action column for which the user can mark an order either paid or unpaid 

## Prerequisites:
- .NET 8
- SQL Server or SQL Express installed

## Setups:
Once you had cloned the project, the only setup you need to do is point the correct database to the application.

1.) Make sure you change the connection of the database to point to your database in ```appsettings.json ```.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=NewOrders;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```
Make sure that you replace only the database name.

You can setup the database connection through here on Visual Studio Editor:
This can be done by going through the View, and then Server Explorer and it will have the data connections section. (``` View/Server Explorer```)
To add connection to the database for the application, you need to right click and select add connection.
And you can through the the entry fillings.

I filled out the following details:
- Server name (Done manually)
- keep the authenticationto on windows
- tick the trust server certificate for local purposes
- Enter the name of the database

2.) Once you have the the database connection successfully, you will need to run the migration and the seed (Loading 50 demo orders onto the existing table on your db).
  This can be done by running the command ```Update-Database``` on the Package Manager console.
  You can open up the Package Manager Console through View, Other Windows and then Package Manager Console.
  ```View/Other Windows/Package Manager Console```


3.) Then you should be all set, all you need to do is click the play button (full green color button).
    That will run the application and it will be shown on thr browser.

# Functional requirements

## Completed Tasks

- Order List: Display Order ID, Customer, Status, Total (currency), and
Created Date in a table. (Point 1) 
- Filter Panel: Support any combination of: date range, status (Pending,
Processing, Shipped, Cancelled), and minimum/maximum total. (Point 2)
- Allow marking an order as “Paid” and refresh the list without reloading
the entire page. (Point 5)

## Incomplete Tasks

- Details View: Clicking a row reveals line items, quantities, and prices. (Point 3)
- Live Statistics Widget: Show the count and grand total of the currently filtered orders without a fullpage refresh. (Point 4)


# Other Incomplete tasks/requirements

- Unit Tests (None)
