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

# TR
## API Gateway Nedir?
API Gateway distributed mimarilerin sunduğu servislere erişim sağlamak için kullanılır.
Mikroservislere erişimde merkezi bir nokta görevi görür. Gateway sayesinde mikroservislerimiz dışarıyla haberleşmesini gateway
ile sağlar ve bu özellik bize güvenlik, merkezi yönetim gibi faydalar sağlar.
API Gateway merkezi olmak üzere temelde alttaki işlevleri barındırır.
- Yönlendirme: API Gateway ile belirli formatta gelen istekleri belirli formatta olan noktalara-endpointlere yönlendirebiliriz.
- Yetkilendirme: Kimlik doğrulama ve yetkilendirme işlemlerini merkezi olarak yönetebiliriz, burada genelde bir identity işlemi yapan mikroservis ile iletişim halinde oluruz.
- Load Balancing: Gelen istekleri mikroservisler arasında ayarlanan formatta dağıtılmasını sağlar. Birden fazla node ile çalışan servislerde işe yarar.
- Rate Limiting: Gelen isteklerin sınırlandırılması ve sistemin saldırılardan korunmasını sağlar.
- API Composition: Gelen istekler sonucu birden fazla mikroservisten veri toplanması ve client tarafına sunulmasını sağlayabiliriz.
