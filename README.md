# Implementação De Padrões De Projetos
Este é um trabalho para a disciplina de Engenharia de Software do curso Bacharelado em Ciência da Computação da UTFPR campus Campo Mourão<br>

**Nome:** Diogo Kovalek de Almeida<br><br>
**Objetivo:** Implementar três padrões de projeto, sendo eles um **comportamental**, um **criacional**, um **estrutural**

# Padrões de Projeto

### Comportamental -> Observer
* **Contexto**<br>
* **Problema**<br>
* **Solução**<br>
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
* **Problema**<br>
* **Solução**<br>
* **Explicação do código**<br>
Presente dentro do código



# Referencias
* [(Marco Tulio Valente. Engenharia de Software Moderna, Capitulo 6)](https://engsoftmoderna.info/cap6.html)<br>
* [REFACTORING GURU](https://refactoring.guru/pt-br/design-patterns)<br>
* Foi Usado [ChatGPT](https://chatgpt.com/) Para fins de revisão de código e texto, além de sujestão para o Para o problema do padrão de projeto