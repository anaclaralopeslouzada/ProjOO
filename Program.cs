namespace LogSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia o Sujeito (Logger)
            Logger logger = new Logger();

            // Instancia as implementações de Observadores
            var console = new ConsoleObserver();
            var file = new FileObserver();

            // Demonstra o registro (assinatura) dos observadores
            logger.Subscribe(console);
            logger.Subscribe(file);

            // Quando o log é chamado, o Logger notifica automaticamente tanto o console quanto o arquivo através da interface
            logger.Log("Execução do padrão Observer iniciada.");

           // Testando a remoção de um observador
            logger.Unsubscribe(console);
            logger.Log("Agora apenas o FileObserver deve receber este log.");
        }
    }
}
