# Microservices Education Platform

A microservices-based backend architecture built with ASP.NET, RabbitMQ, PostgreSQL, Docker, and Domain-Driven Design (DDD) principles.

The goal of this project is to explore scalable backend architectures, event-driven communication, CQRS, JWT authentication, and distributed systems concepts using modern technologies.

---

## Architecture

```text
Client
   │
   ▼
API Gateway
   │
   ├───────────────┐
   │               │
   ▼               ▼
Auth Service   Roadmap Service
   │               │
   ▼               ▼
PostgreSQL     PostgreSQL
        │
        ▼
     RabbitMQ
```

Services communicate asynchronously through RabbitMQ events.

---

## Technologies

### Backend

- ASP.NET 9
- Entity Framework Core
- JWT Authentication
- CQRS Pattern
- Domain-Driven Design (DDD)
- RabbitMQ
- MassTransit

### Database

- PostgreSQL

### Infrastructure

- Docker
- Docker Compose

### Future Services

- Spring Boot Services
- FastAPI Services
- Redis
- API Gateway
- Read Models

---

## Project Structure

```text
microservices-edu/
│
├── services/
│   ├── auth-service/
│   ├── roadmap-service/
│   └── gateway-service/
│
├── docker-compose.yml
├── docs/
└── README.md
```

---

## Features

### Auth Service

- User registration
- User authentication
- JWT token generation
- Authorization support

### Roadmap Service

- Roadmap creation
- Roadmap retrieval
- Event publishing
- CQRS implementation

### Messaging

- RabbitMQ integration
- Event-driven communication
- Service decoupling

---

## Getting Started

### Prerequisites

- .NET 9 SDK
- Docker Desktop
- PostgreSQL (optional if using Docker)
- Git

---

### Clone Repository

```bash
git clone https://github.com/your-username/microservices-edu.git

cd microservices-edu
```

---

### Start Infrastructure

```bash
docker compose up -d
```

This will start:

- PostgreSQL
- RabbitMQ

RabbitMQ Management UI:

http://localhost:15672

Default credentials:

```text
Username: guest
Password: guest
```

---

### Run Auth Service

```bash
cd services/auth-service

dotnet restore

dotnet run
```

---

### Run Roadmap Service

```bash
cd services/roadmap-service

dotnet restore

dotnet run
```

---

## Environment Variables

Create a `.env` file based on `.env.example`.

Example:

```env
POSTGRES_USER=postgres
POSTGRES_PASSWORD=postgres
POSTGRES_DB=app_db

JWT_SECRET=your-secret-key

RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
```

---

## Roadmap

- [x] Docker Infrastructure
- [x] PostgreSQL Integration
- [x] RabbitMQ Integration
- [x] JWT Authentication
- [x] DDD Structure
- [x] CQRS Implementation
- [ ] API Gateway
- [ ] Redis Read Model
- [ ] Notification Service
- [ ] Spring Boot Microservice
- [ ] FastAPI Microservice
- [ ] Kubernetes Deployment

---

## License

This project is for educational and portfolio purposes.
