# Saga Orchestration Design Pattern

# EN
## What is SAGA Design Pattern?
The SAGA design pattern is a method of managing distributed transactions in microservice architectures.
It is used to ensure data consistency within a microservice architecture by handling data consistency issues that
arise from the asynchronous communication between independent operations.
There are fundamentally two different approaches to implementing the SAGA design pattern.

### SAGA Orchestration
In cases where the number of microservices involved in a distributed transaction is large, a centralized approach is preferred.
This involves monitoring the success or failure status of microservices from a central point,
where necessary actions are taken based on this status.


# TR
## SAGA Design Pattern Nedir?
SAGA Design pattern mikroservis mimarilerinde kullanılan distributed bir transaction(işlem) yönetim biçimidir.
SAGA pattern mikroservis mimarisinde veri tutarlılığını sağlamak için kullanılır. Birbirinden bağımsız işlemlerin
birbirleri ile asenkron haberleşmesi ile oluşan data turarlılığı sorunlarını çözmek için kullanılır.
SAGA Desing Pattern'in uygulanması için temelde 2 farklı yöntem vardır.

### SAGA Orchestration
Distributed transaction yapısına dahil olacak mikroservis sayısının fazla olması durumunda tercih edilir.
Merkezi bir noktadan mikroservislerin başarılı/başarısız durumları takip edilir ve gerekli aksiyonlar/eventler tetiklenir.