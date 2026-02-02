📘💄 Design Patterns – Exemplos Práticos em Console
Este repositório apresenta 10 Design Patterns clássicos, implementados em C# com foco em uso prático em sistemas reais.
O objetivo do projeto não é apenas demonstrar a estrutura dos padrões, mas explicar por que e quando eles foram utilizados, baseando-se em cenários comuns de aplicações corporativas, como autenticação, auditoria, cache, controle de acesso, orquestração de serviços e operações de uma loja de maquiagem.
Todos os exemplos rodam em Console, para manter o foco no comportamento dos patterns, sem distrações de frameworks web ou camadas visuais.

🛠️ Estrutura do Projeto
- Cada Design Pattern está isolado em sua própria pasta dentro de `src`
- Cada pasta contém:
  - As classes que implementam o padrão
  - Um arquivo `Demo` responsável por executar o exemplo
- O `Program.cs` centraliza a execução e exibe um menu interativo no console

▶️ Como Executar
1. Abra o projeto no Visual Studio ou Rider
2. Execute a aplicação (`F5` ou `Ctrl + F5`)
3. Um menu será exibido no console com os 10 Design Patterns disponíveis
4. Digite o número do pattern desejado e pressione `Enter`
5. Observe o comportamento sendo demonstrado no console
6. Digite `0` para encerrar a aplicação

🧠 Design Patterns Implementados

1️⃣ Singleton — CacheService
Por que foi utilizado:
Para garantir que todos os componentes do sistema utilizem a mesma instância de cache, evitando inconsistências e duplicidade de dados compartilhados.
Como funciona:
A classe CacheService expõe a propriedade estática Instance, garantindo acesso único ao objeto. O construtor é privado e o uso de Lazy<T> assegura inicialização sob demanda e thread-safe. Os dados são armazenados em um dicionário interno.
Demonstração no console:
Mostra que valores armazenados em um ponto da aplicação são recuperados corretamente em outro, confirmando que a instância é única.

2️⃣ Factory Method — Loja de Maquiagem (PaymentFactory e ProductFactory)
Por que foi utilizado:
Para centralizar e desacoplar a criação de diferentes tipos de pagamento (Pix, Cartão, Boleto) e também de produtos de maquiagem (Batom, Base, Máscara de Cílios), facilitando manutenção e evolução do sistema.
Como funciona:
Cada fábrica de pagamento (PixPaymentFactory, CardPaymentFactory, BoletoPaymentFactory) implementa o método CreatePayment, retornando o tipo de pagamento correspondente.
Além disso, agora há fábricas de produtos de maquiagem (BatomFactory, BaseFactory, MascaraFactory), cada uma responsável por criar um produto específico.
Demonstração no console:
Exibe a criação dinâmica de um produto de maquiagem e a realização do pagamento, sem que o consumidor conheça as implementações concretas.
Exemplo:
Produto: Batom - Cor vibrante e longa duração  
Pago R$ 100,00 via Pix

3️⃣ Abstract Factory — NotificationFactory
Por que foi utilizado:
Para criar famílias de objetos relacionados (notificações por e-mail ou SMS) sem acoplamento direto às classes concretas.
Como funciona:
Cada fábrica (EmailNotificationFactory, SmsNotificationFactory) retorna o tipo de notificação desejado.
Demonstração no console:
Mostra o envio de uma notificação por e-mail ou SMS, conforme a fábrica utilizada.

4️⃣ Adapter — LegacyApiAdapte
Por que foi utilizado:
Para integrar um sistema legado com uma interface incompatível com o padrão atual da aplicação.
Como funciona:
O LegacyApiAdapter traduz a chamada moderna para o método esperado pelo serviço legado, sem alterar o código antigo.
Demonstração no console:
Exibe a obtenção de dados do sistema legado através do adapter.

5️⃣ Decorator — LoggingDecorator
Por que foi utilizado:
Para adicionar funcionalidades extras (logs) ao serviço de pedidos sem modificar sua implementação original.
Como funciona:
O LoggingDecorator implementa a mesma interface do serviço original e adiciona comportamento antes/depois de delegar a chamada.
Demonstração no console:
Mostra logs sendo exibidos antes e depois do processamento do pedido.

6️⃣ Strategy — DiscountStrategy
Por que foi utilizado:
Para alternar regras de desconto conforme o tipo de cliente, sem alterar a lógica principal do checkout.
Como funciona:
O CheckoutService recebe uma estratégia de desconto, que pode ser trocada em tempo de execução.
Demonstração no console:
Mostra diferentes valores finais de compra conforme a estratégia de desconto utilizada.

7️⃣ Facade — PedidoFacade
Por que foi utilizado:
Para simplificar operações complexas envolvendo múltiplos serviços (estoque e pagamento) em uma única interface.
Como funciona:
O PedidoFacade encapsula chamadas ao estoque e ao pagamento, expondo um método de alto nível para realizar pedidos.
Demonstração no console:
Mostra o fluxo completo de realização de pedido com uma única chamada.

8️⃣ Observer — PedidoSubject
Por que foi utilizado:
Para notificar múltiplos componentes (e-mail, log) automaticamente quando um evento de pedido ocorre.
Como funciona:
O PedidoSubject mantém uma lista de observers registrados e notifica todos quando um pedido é criado.
Demonstração no console:
Exibe notificações sendo disparadas para diferentes observers ao criar um pedido.

9️⃣Command — AddProductCommand
Por que foi utilizado:
Para encapsular ações do sistema como objetos, permitindo execução desacoplada e suporte a operações de undo.
Como funciona:
Cada ação implementa a interface ICommand. O CommandInvoker executa e desfaz comandos sem conhecer sua lógica interna.
Demonstração no console:
Mostra a execução do comando de adicionar produto ao carrinho e desfazer a operação.

🔟 State — PedidoContext
Por que foi utilizado:
Para controlar o fluxo de estados de um pedido (Criado, Pago, Enviado, Cancelado) e alterar o comportamento conforme o estado atual.
Como funciona:
O PedidoContext mantém o estado atual e delega as ações para o objeto de estado correspondente.
Demonstração no console:
Mostra a mudança de status do pedido conforme as ações de avançar ou cancelar.

Resumo:
Este sistema é um catálogo de exemplos de Design Patterns, cada um ilustrado com cenários práticos inspirados em aplicações reais, incluindo operações de uma loja de maquiagem. O objetivo é facilitar o aprendizado e a demonstração dos padrões de projeto em situações do dia a dia do desenvolvimento de software.
