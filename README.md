# dotnetcore-001-yt-console-app

## Dependências:
- CommandLineParser: Executar a aplicação passando parâmetros de forma mais profissional.
- Serilog: Logar informações na tela.
    - Serilog.Extensions.Hosting: Necessário para subistituir o serlog padrão.
    - Serilog.Settings.Configuration: Para configurar a partir do arquivo appsettings.
    - Serilog.Sinks.Console: Para exibir os logs em tela.
- Microsoft.Extensions.Configuration
- Microsoft.Extensions.Hosting
- Microsoft.Extensions.DependencyInjection