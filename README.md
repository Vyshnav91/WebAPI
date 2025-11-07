# Book API (ASP.NET Core)

A simple ASP.NET Core Web API built with C# to explore how RESTful endpoints work.  
This project serves in-memory book data through HTTP GET requests and demonstrates how controllers, routing, and JSON serialization work in ASP.NET Core.

---

## Features
- Fetch all books  
- Fetch a single book by ID  
- Uses `[ApiController]` and `[HttpGet]` attributes for clean routing  
- Returns JSON responses  
- In-memory data (no database required)

---

## Tech Stack
- C#
- .NET 8
- ASP.NET Core Web API
- OpenAPI / Swagger (auto-generated)

---

## Endpoints

| Method | Endpoint | Description |
|--------|-----------|-------------|
| GET | `/api/books` | Returns a list of all books |
| GET | `/api/books/{id}` | Returns a single book by ID |

**Example Request:**
```bash
GET https://localhost:7216/api/books


[
  { "id": 1, "author": "J.R.R. Tolkien", "title": "The Hobbit", "yearPublished": 1937 },
  { "id": 2, "author": "George Orwell", "title": "1984", "yearPublished": 1949 }
]


how to run this:

git clone https://github.com/yourusername/BookAPI.git
cd BookAPI
dotnet run
Open your browser and go to:

https://localhost:7216/api/books
