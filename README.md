# Prejeto Pessoal para o Desafio projeto com TDD e testes unitários - DIO

## Desafio de projeto
Projeto que estou colocando em práticar meus estudos de TDD e testes unitários.

## Contexto
Projeto básico de um gerenciamento de funcionários

## Premissas
O sistema possui dois projetos: um do tipo console, e um do tipo testes com **xUnit**. O projeto do tipo console possui duas classes em que uma é definido um Funcionário e outra as lógicas para o gerencimanto: **Worker** e **Management**, respectivamente.

A classes "Management" contém métodos que são usados para realizar o registro, remoção e listagem dos funcionários.

O projeto de testes possui a classes de teste **TestWorkerManagement**, assim como seus métodos para validar o projeto do tipo console. 

## Projeto Console, suas classes e métodos

Essas são as classes do projeto console, onde fica a principal lógica do sistema.

**Classe Worker**

Classe responsável definir um funcionário.

| Classe       | Propriedades    | Objetivo                                                         |
|--------------------------------|------------------------------|-----------------------------------|
| Worker       | Name            | Definir o nome do funcionário.                                   |
| Worker       | DateBirth       | Definir a data de aniversário do funcionário.                    |
| Worker       | CPF             | Definir o CPF do funcionário.                                    |
| Worker       | ListWorker      | Criar uma lista do tipo Worker para mostrar esses funcionários.  |

**Classe Management**

Classe responsável por realizar o registro, remoção de listagem dos funcionários.

| Classe           | Método        | Objetivo                                                                                                                
|------------------|---------------|-----------------------------------------------------------------------------------------------------|
| Management       | Register      | Recebe um Worker e adiciona ele na ListWorker.                                                      |
| Management       | Remove        | Recebe um Worker, remove ele da ListWorker e retorna a ListWorker.                                  |
| Management       | Workers       | Não recebe argumentos, exibe as propriedades definidas do Worker registrado e retorna a ListWorker. |

## Projeto do tipo teste, suas classes e métodos

**Classe TestWorkerManagement**

Classe responsável por realizar os testes da classe Management.

| Classe               | Método de teste       | Resultado esperado do teste
|----------------------|-----------------------|----------------------------------------------------------------------------------------------------------------|
| TestWorkerManagement | RegisterWorker        | Ao passar um instância de um Worker, regitra essa instância e deve retornar que a ListWorker não esta vazia.   |
| TestWorkerManagement | RemoveWorker          | Ao realizar um registro, remove o mesmo e verifica se o registro existe na ListWorker.                         |
| TestWorkerManagement | ListWorker            | Ao realizar um registro, adiciona ele numa lista e verifica se a lista não está vazia.                         |

## Estrutura do projeto
O projeto está estruturado da seguinte maneira:

![Métodos Swagger](![image](https://github.com/JhonnyFspDev/projeto-tdd-desafio/assets/150201090/3e01e779-7f17-473e-817c-bffc33798b35)
)


