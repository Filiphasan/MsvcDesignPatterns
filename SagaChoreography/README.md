# EN

## What is SAGA Design Pattern?
The SAGA design pattern is a method of managing distributed transactions in microservice architectures.
It is used to ensure data consistency within a microservice architecture by handling data consistency issues that
arise from the asynchronous communication between independent operations.
There are fundamentally two different approaches to implementing the SAGA design pattern.

### SAGA Choreography
The SAGA design pattern is preferred in situations where the number of microservices
involved in a distributed transaction is relatively small (around 2-4). Each microservice manages
its own success or failure status and communicates this information to the preceding and succeeding microservices.
It is considered best practice for these communications to be asynchronous.

# TR

## SAGA Design Pattern Nedir?
SAGA Design pattern mikroservis mimarilerinde kullanılan distributed bir transaction(işlem) yönetim biçimidir.
SAGA pattern mikroservis mimarisinde veri tutarlılığını sağlamak için kullanılır. Birbirinden bağımsız işlemlerin
birbirleri ile asenkron haberleşmesi ile oluşan data turarlılığı sorunlarını çözmek için kullanılır.
SAGA Desing Pattern'in uygulanması için temelde 2 farklı yöntem vardır.

### SAGA Choreography
Distributed transaction yapısına dahil olacak mikroservis sayısının az olduğu (2-4 civarı) durumlarda tercih edilir.
Her mikroservis başarılı/başarısız durumunu kendi içinde yönetir ve önceki ve sonraki mikroservise bu bilgiyi iletir.
İletimler asenkron olması bir best practices'dir. 