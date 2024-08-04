# MsvcDesignPatterns
Design Patterns for Microservice, SAGA, API Gateway, Circuit Breaker, ServiceDiscovery, Event Sourcing, API Composition.

## List of Microservice Design Patterns
- [API Gateway Design Pattern](ApiGateway) ✔️
- SAGA Design Pattern 🕒
  - [Choreography](SagaChoreography) 🕒
  - [Orchestration](SagaOrchestration) 🕒
- Event Sourcing Design Pattern 🕒
- Retry Design Pattern 🕒
- Circuit Breaker Design Pattern 🕒
- Service Registry Design Pattern 🕒
- API Composition Design Pattern 🕒
- Bulkhead Design Pattern 🕒
- Sidecar Design Pattern 🕒
- Configuration Externalization Design Pattern 🕒
- Leader Election Design Pattern 🕒
- Strangler Fig Design Pattern 🕒


# EN
### SAGA Orchestration
In cases where the number of microservices involved in a distributed transaction is large, a centralized approach is preferred.
This involves monitoring the success or failure status of microservices from a central point, 
where necessary actions are taken based on this status.


# TR
### SAGA Orchestration
Distributed transaction yapısına dahil olacak mikroservis sayısının fazla olması durumunda tercih edilir.
Merkezi bir noktadan mikroservislerin başarılı/başarısız durumları takip edilir ve gerekli aksiyonlar alınır.