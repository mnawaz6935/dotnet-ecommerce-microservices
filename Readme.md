
# E-Commerce Microservices Architecture

## Overview

This repository contains the microservices architecture for an e-commerce platform. The architecture is designed using .NET Core and Ocelot API Gateway, providing a flexible and scalable solution for handling customer orders, product management, and customer information.

## Microservices

The project consists of the following microservices:

- **Customer.Microservice**: Manages customer data and operations.
- **Order.Microservice**: Handles order processing and management.
- **Product.Microservice**: Manages product listings and details.
- **Gateway.WebApi**: Acts as an API gateway for routing requests to the appropriate microservices.

## Features

- **CRUD Operations**: Full create, read, update, delete functionality for customers, orders, and products.
- **Ocelot API Gateway**: Simplifies request routing and load balancing across microservices.
- **Docker Support**: Containerized microservices for easy deployment and scalability.
- **Swagger Documentation**: Integrated Swagger UI for API documentation and testing.

## Prerequisites

- [.NET SDK 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

## Getting Started

1. **Clone the repository**:
   ```bash
   git clone https://github.com/mnawaz6935/dotnet-ecommerce-microservices.git
   cd dotnet-ecommerce-microservices
   ```

2. **Build and run the microservices using Docker Compose**:
   ```bash
   docker-compose up --build
   ```

3. **Access the API**:
   - Open your browser and navigate to `http://localhost:8070` (or your configured port) to access the API Gateway.

## API Documentation

You can find API documentation generated by Swagger at:
```
http://localhost:<gateway-port>/swagger
```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

### Steps to Contribute

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes and commit them (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Open a pull request.

## Contact

For any questions or inquiries, feel free to reach out:

- **Nawaz**: [muhammadnawaz6935@gmail.com](mailto:muhammadnawaz6935@gmail.com)
- **GitHub**: [https://github.com/mnawaz6935](https://github.com/mnawaz6935)