# Injeção de Dependência e Inversão de Controle

## Injeção de Dependência
Injeção de dependência é a técnica de se injetar uma interface no construtor da classe em que se deseja injetar a dependência. Essa técnica é a parte principal para que seja possivel obter a inverão de controle

## Inversão de Controle
Robert C. Martin diz: Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações.

O que isso quer dizer? Robert está nos dizendo que quando desejamos depender de algo que não está ligado intricicamente ao módulo altual da depêndencia, a depêndencia a ser criada deve derivar de uma classe abstrata ou de uma interface.

Quando não dependemos direto de uma classe concreta e sim de uma classe abstrata ou uma interface, estamos tirando o alto acoplamento entre módulos de alto nivel para os módulos de baixo nível e vice-versa o que no implica dizer que a frase dita por Robert é show!

## Como depender das abstrações?
    Após ter efetuados a injeção  de Dependência, podemos ter  um container que container de serviços que faz todo o trabalho de criar instâncias as classes abstratas e/ou interfaces criadas, esse container fornece métodos que indicam quais são os ciculos de vida de cada instância criada.

### O que faz os Containers?
Os conteiners forncece métodos que mapeiam as classes abstratas/interfaces  com a classe concretas

##### Ciclo de vida disonibilizados pelos Containers
Transient: New Instance => Criada uma nova instância do serviço toda vez que é solicitado

Scoped: cria uma nova instância para cada escopo. (Cada solicitação é um Escopo). Dentro do escopo, ele reutiliza o serviço existente.

Singleton : Cria um novo serviço apenas uma vez durante a vida útil do aplicativo e o usa em todos os lugares

## Quais os Atores da Injeção de Depêndencia?
Para se obter a injeção é 