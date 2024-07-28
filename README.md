# MsvcDesignPatterns
Design Patterns for Microservice, SAGA, API Gateway, Circuit Breaker, ServiceDiscovery, Event Sourcing, API Composition.

## List of Microservice Design Patterns
- [API Gateway Design Pattern](ApiGateway)
- [SAGA Design Pattern - Choreography](SagaChoreography)


# EN
## What is API Gateway Design Pattern?
API Gateway is used to provide access to services offered by distributed architectures. 
It acts as a central point for accessing microservices. With the gateway, 
our microservices communicate with the outside world, providing us with benefits such as security and centralized management. 
The API Gateway primarily includes the following functions:

- Routing: With the API Gateway, we can route requests that come in a specific format to specific endpoints.
- Authorization: We can centrally manage authentication and authorization processes, typically communicating with a microservice that handles identity operations.
- Load Balancing: It ensures the distribution of incoming requests among microservices in a configured manner, useful for services running on multiple nodes.
- Rate Limiting: It limits incoming requests and protects the system from attacks.
- API Composition: We can gather data from multiple microservices in response to a request and present it to the client side.

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

### SAGA Orchestration
In cases where the number of microservices involved in a distributed transaction is large, a centralized approach is preferred.
This involves monitoring the success or failure status of microservices from a central point, 
where necessary actions are taken based on this status.


# TR
## API Gateway Nedir ve Nasıl Kullanılır?
API Gateway distributed mimarilerin sunduğu servislere erişim sağlamak için kullanılır. 
Mikroservislere erişimde merkezi bir nokta görevi görür. Gateway sayesinde mikroservislerimiz dışarıyla haberleşmesini gateway 
ile sağlar ve bu özellik bize güvenlik, merkezi yönetim gibi faydalar sağlar.
API Gateway merkezi olmak üzere temelde alttaki işlevleri barındırır.
- Yönlendirme: API Gateway ile belirli formatta gelen istekleri belirli formatta olan noktalara-endpointlere yönlendirebiliriz.
- Yetkilendirme: Kimlik doğrulama ve yetkilendirme işlemlerini merkezi olarak yönetebiliriz, burada genelde bir identity işlemi yapan mikroservis ile iletişim halinde oluruz.
- Load Balancing: Gelen istekleri mikroservisler arasında ayarlanan formatta dağıtılmasını sağlar. Birden fazla node ile çalışan servislerde işe yarar.
- Rate Limiting: Gelen isteklerin sınırlandırılması ve sistemin saldırılardan korunmasını sağlar.
- API Composition: Gelen istekler sonucu birden fazla mikroservisten veri toplanması ve client tarafına sunulmasını sağlayabiliriz.

## SAGA Design Pattern Nedir ve Nasıl Kullanılır?
SAGA Design pattern mikroservis mimarilerinde kullanılan distributed bir transaction(işlem) yönetim biçimidir.
SAGA pattern mikroservis mimarisinde veri tutarlılığını sağlamak için kullanılır. Birbirinden bağımsız işlemlerin 
birbirleri ile asenkron haberleşmesi ile oluşan data turarlılığı sorunlarını çözmek için kullanılır.
SAGA Desing Pattern'in uygulanması için temelde 2 farklı yöntem vardır.

### SAGA Choreography
Distributed transaction yapısına dahil olacak mikroservis sayısının az olduğu (2-4 civarı) durumlarda tercih edilir. 
Her mikroservis başarılı/başarısız durumunu kendi içinde yönetir ve önceki ve sonraki mikroservise bu bilgiyi iletir.
İletimler asenkron olması bir best practices'dir. 

### SAGA Orchestration
Distributed transaction yapısına dahil olacak mikroservis sayısının fazla olması durumunda tercih edilir.
Merkezi bir noktadan mikroservislerin başarılı/başarısız durumları takip edilir ve gerekli aksiyonlar alınır.