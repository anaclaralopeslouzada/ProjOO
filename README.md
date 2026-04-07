# Exercício de ProjOO - Padrão Observer (Logger)

Esse repositório tem a minha resolução para o exercício sobre o padrão de projeto Observer, que o Prof. Fábio Fagundes Silveira passou na aula do dia 07/04/2026

## O que eu fiz no projeto:
A ideia foi criar um sistema de Log onde a gente consegue cadastrar diferentes destinos para as mensagens (como o console ou um arquivo). 
Usei a estrutura do Observer para que o Logger não precise saber detalhes de como cada log é exibido, ele só avisa quem estiver "inscrito" na lista dele.

## Estrutura dos arquivos:

- **ILogObserver.cs**: É a interface que define a regra para todos os observadores.
- **Logger.cs**: É a classe principal (o sujeito). Ela gerencia a lista de observadores e dispara as notificações.
- **ConsoleObserver.cs**: Classe que recebe o aviso e imprime o log na tela.
- **FileObserver.cs**: Classe que simula a gravação do log em um arquivo de texto.
- **Program.cs**: Arquivo onde eu criei os objetos e testei se o Subscribe e o Unsubscribe estavam funcionando como esperado.

## Como rodar o código:
O repositório já contém o arquivo de projeto (`.csproj`). Para executar, basta abrir a pasta no terminal e digitar:

```bash
dotnet run
