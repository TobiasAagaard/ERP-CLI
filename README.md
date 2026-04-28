# ERP-CLI — LNE Security
 
A command-line ERP (Enterprise Resource Planning) system built in C# / .NET 10 for the fictional company **LNE Security A/S**, a Danish IT-services company headquartered in Aalborg.
 
The application is designed as a foundation that can be extended to other industries, so the architecture is kept clean and modular to support multiple developers working in parallel and several future versions of the product.

## About LNE Security
 
LNE Security is a B2B IT-services company with 350 employees and departments in Aalborg, Odense, Nordborg, and Esbjerg. Besides hosting IT services, they sell software licenses and IT hardware from a central warehouse in Odense. The ERP system supports their core business processes.

## Getting Started
 
### Prerequisites
 
- [.NET 10 SDK (preview)](https://dotnet.microsoft.com/download/dotnet/10.0)

### Build and run 
Clone the repository, navigate to the project folder, and run the following commands in your terminal:

```bash
dotnet restore
dotnet build
dotnet run
```

The app starts in the main menu. Use the arrow keys to navigate, Enter to select, Escape to go back, and the F-keys shown on each screen for actions (F1 / F2 / F3 / F5 for create / edit / new / delete depending on the screen).

## Development Workflow
 
We work in small increments using GitHub issues, feature branches, and pull requests.

### Issue tracking
 
| Prefix | Area | Examples |
|---|---|---|
| `D` | Domain models | D1 Currency enum, D2 Company entity, D3 Product entity, D4 Address entity, D5 Person entity, D6 Customer entity, D7 Sales order header, D8 Sales order line, D9 Domain model unit tests |
| `V` | Company (Virksomhed) | V1 Company list screen, V2 Company details view, V3 Edit company screen, V4 F1 create new company, V5 F2 edit company setup, V6 F5 delete company, V7 Main menu screen with TECHCOOL UI.Menu |
| `P` | Product (Produkt) | P1 Product database methods, P2 Product list screen, P3 Product details screen, P4 Edit product screen, P5 F2 edit product, P6 F3 create product, P7 F5 delete product |
| `K` | Customer (Kunde) | K1 Customer database methods, K2 Customer list screen, K3 Customer details screen, K4 Edit customer screen, K5 F2 edit customer, K6 F2 create customer, K7 F5 delete customer |
| `S` | Sales orders (Salg) | S1 Sales order database methods, S2 Sales order list screen, S3 Sales order details screen, S4 Create/edit sales order screen, S5 F2 edit sales order, S6 F2 create new sales order, S7 F5 delete sales order |
| `B` | Database | B1 Partial Database class with Company methods, B2 Product table SQL script, B3 Address table SQL script, B4 Person table SQL script, B5 Customer table SQL script, B6 Sales order header table SQL script, B7 Sales order table SQL script, B8 SQL Server connection handling |
| `X` | Extra / cross-cutting | X1 Invoice export HTML/CSS, X2 Unit tests for basic classes, X3 Purchase and sales orders, X4 Inventory management (effectuate orders) |



## Contributors
 
- [Nicklas](https://github.com/NickRaics)
- [Tobias](https://github.com/TobiasAagaard)
- [Malthe](https://github.com/Malthebk3)

## License
 
School project. Not licensed for production use.