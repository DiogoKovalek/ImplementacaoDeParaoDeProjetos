# Implementação De Padrões De Projetos
Este é um trabalho para a disciplina de Engenharia de Software do curso Bacharelado em Ciência da Computação da UTFPR campus Campo Mourão<br>

**Nome:** Diogo Kovalek de Almeida<br><br>
**Objetivo:** Implementar três padrões de projeto, sendo eles um **comportamental**, um **criacional**, um **estrutural**

# Padrões de Projeto

### Comportamental -> Observer
* **Contexto**<br>
Durante o desenvolvimento de um jogo na Unity, diferentes sistemas precisam reagir quando determinados eventos acontecem. Por exemplo, quando o jogador perde todas as vidas, diversos componentes do jogo devem executar ações automaticamente, como exibir a tela de “Game Over”, tocar um efeito sonoro e salvar a pontuação final.<br>
Inicialmente, essas funcionalidades estavam diretamente conectadas entre si, fazendo com que a classe do jogador tivesse referências diretas para todos os outros sistemas do jogo.<br>
<br>

* **Problema**<br>
A abordagem inicial gerava alto acoplamento entre as classes, pois o objeto do jogador precisava conhecer todos os componentes que deveriam reagir ao evento de morte.<br>
Além disso, sempre que uma nova funcionalidade precisasse responder ao evento, como adicionar partículas visuais ou registrar estatísticas, seria necessário modificar o código do jogador novamente, violando o princípio de aberto/fechado (Open/Closed Principle).<br>
Esse modelo dificultava a manutenção, a escalabilidade e a reutilização do código.<br>
<br>

* **Solução**<br>
Para resolver esse problema, foi utilizado o padrão comportamental Observer.<br>
Nesse padrão, o objeto principal, chamado de `Subject`, torna-se responsável apenas por emitir notificações quando um evento ocorre. Os demais objetos interessados, chamados de `Observers`, podem se inscrever para receber essas notificações automaticamente.<br>
Na implementação em C#, o padrão foi desenvolvido utilizando `event` e `delegate`, permitindo que diferentes sistemas do jogo escutem eventos sem que o objeto principal precise conhecer diretamente cada um deles.<br>
Dessa forma, o sistema ficou menos acoplado, mais modular e mais fácil de expandir, permitindo adicionar novos observadores sem alterar a lógica principal do jogador.<br>
<br>

* **Explicação do código**<br>
Presente dentro do código

### Criacional -> Singleton
* **Contexto**<br>
A Unity, uma game engine utilizada para desenvolvimento de jogos, organiza a aplicação em diferentes cenas (Scenes). Cada cena contém diversos GameObjects, que representam os objetos responsáveis pelos elementos presentes naquele contexto específico do jogo.<br>
Por padrão, ao realizar a troca de cena, quase todos os objetos da cena atual são destruídos automaticamente. Apenas objetos marcados com o método `DontDestroyOnLoad` permanecem ativos durante a transição entre cenas.<br>
<br>

* **Problema**<br>
Durante o desenvolvimento do projeto, surgiu a necessidade de compartilhar informações entre diferentes cenas do jogo, como pontuação do jogador, número da fase atual e configurações gerais, incluindo volume da música, efeitos sonoros e dificuldade.<br>
Entretanto, como os objetos da cena são destruídos ao carregar uma nova cena, os dados armazenados nesses objetos também são perdidos, dificultando a persistência dessas informações ao longo da execução do jogo.<br>
<br>

* **Solução**<br>
Para resolver esse problema, foi criado um objeto denominado `GameManager`, contendo um script em C# derivado de `MonoBehaviour`. Esse objeto utiliza o padrão de projeto Singleton, garantindo que exista apenas uma única instância do `GameManager` durante toda a execução da aplicação.<br>
Além disso, o objeto é marcado com `DontDestroyOnLoad`, permitindo que ele não seja destruído durante as trocas de cena. Dessa forma, as variáveis armazenadas no `GameManager` permanecem acessíveis em qualquer parte do jogo, independentemente da cena carregada.<br>
<br>

* **Explicação do código**<br>
Presente dentro do código

### Estrutural -> Proxy
* **Contexto**<br>
Durante o desenvolvimento de um sistema de gerenciamento de arquivos, algumas operações exigiam acesso a documentos armazenados em um servidor remoto. Esses arquivos poderiam conter informações sensíveis, como relatórios administrativos e dados confidenciais de usuários.<br>
O sistema possuía diferentes tipos de usuários, cada um com permissões específicas de acesso aos arquivos.<br>
<br>

* **Problema**<br>
Na implementação inicial, qualquer parte do sistema podia acessar diretamente o objeto responsável pela leitura dos arquivos remotos. Isso gerava problemas relacionados à segurança e ao controle de acesso, pois não existia uma camada intermediária responsável por validar permissões antes da execução da operação.<br>
Além disso, operações remotas podem possuir alto custo computacional ou de rede, tornando inadequado permitir acessos indiscriminados ao objeto principal.<br>
Essa abordagem também dificultava a adição de funcionalidades extras, como cache, logs de acesso e autenticação, sem modificar diretamente a classe original.<br>
<br>

* **Solução**<br>
Para resolver esse problema, foi utilizado o padrão estrutural Proxy.<br>
Nesse padrão, um objeto intermediário chamado `Proxy` é criado para representar o objeto real do sistema. O Proxy possui a mesma interface do objeto principal, permitindo que o cliente utilize ambos da mesma forma.<br>
Entretanto, antes de encaminhar a requisição para o objeto real, o Proxy pode executar verificações adicionais, como autenticação de usuário, controle de permissões, geração de logs ou otimizações de desempenho.<br>
Dessa forma, o acesso ao objeto principal passou a ser controlado de maneira transparente, aumentando a segurança, reduzindo o acoplamento e facilitando a manutenção do sistema.<br>
<br>

* **Explicação do código**<br>
Presente dentro do código



# Referencias
* [(Marco Tulio Valente. Engenharia de Software Moderna, Capitulo 6)](https://engsoftmoderna.info/cap6.html)<br>
* [REFACTORING GURU](https://refactoring.guru/pt-br/design-patterns)<br>
* Foi Usado [ChatGPT](https://chatgpt.com/) Para fins de revisão de texto, elaborar e revisar código, além de sujestão para o Para o problema do padrão de projeto