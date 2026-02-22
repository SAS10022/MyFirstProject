# MyFirstProject - Web API

ASP.NET Core Web API with Product and Customer management.

## Features

- Product Management API (GetAll, GetById, Create)
- Customer Management API (GetAll, GetById, Create)
- Dependency Injection with Service Interfaces
- RESTful API endpoints

## Technologies

- .NET 9.0
- ASP.NET Core Web API
- C#

## API Endpoints

### Products
- `GET /products` - Get all products
- `GET /products/{id}` - Get product by ID
- `POST /products` - Create new product

### Customers
- `GET /customers` - Get all customers
- `GET /customers/{id}` - Get customer by ID
- `POST /customers` - Create new customer

## Running the Application

```bash
dotnet build
dotnet run
```

Then test the API at https://localhost:5001 or http://localhost:5000

## Example Request

```bash
curl -X GET http://localhost:5000/products
```
