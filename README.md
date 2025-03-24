# 🔗 RapidFetch – High-Performance GraphQL + gRPC Microservice API

RapidFetch is a high-performance backend microservice system built using **.NET 8**, **GraphQL (HotChocolate)**, and **gRPC**.  
It demonstrates seamless communication between a GraphQL API and a gRPC microservice, following modern cloud-native practices like strong contracts, modular services, and clean architecture.

---

## 🚀 Tech Stack

- ⚙️ [.NET 8](https://learn.microsoft.com/en-us/dotnet/)
- 🌐 [GraphQL (HotChocolate)](https://chillicream.com/)
- ⚡ [gRPC](https://grpc.io/)
- 🧪 Docker, Redis, RabbitMQ (future-ready integrations)
- 🔒 REST/gRPC contract via `.proto`
- 🧩 Clean architecture principles
- 💻 Built with Visual Studio Code

---

## 📦 Architecture


- GraphQL endpoint: `http://localhost:5240/graphql`
- gRPC server: `https://localhost:5001`

---

## 🎯 Features

- ✅ GraphQL resolver (`user`) calls gRPC method (`GetOrders`)
- ✅ Strong-typed contracts using `.proto`
- ✅ Clean dependency injection
- ✅ Hot reload friendly
- ✅ Full local setup in minutes

---

## 💡 Sample GraphQL Query

```graphql
query {
  user {
    name
    email
    orders {
      orderId
      amount
      status
    }
  }
}
