# dotnetcore-001-yt-console-app

## Dependências:

- CommandLineParser: Executar a aplicação passando parâmetros de forma mais profissional.
- Serilog: Logar informações na tela.
    - Serilog.Extensions.Hosting: Necessário para substituir o serlog padrão.
    - Serilog.Settings.Configuration: Para configurar a partir do arquivo appsettings.
    - Serilog.Sinks.Console: Para exibir os logs em tela.
- Microsoft.Extensions.Configuration
- Microsoft.Extensions.Hosting
- Microsoft.Extensions.DependencyInjection

## Rodar aplicação:
- Abrir o CMD do Windows
```
cd EF.Console\EF.Console\bin\Debug\net5.0\
EF.Console.exe -r 10 --host teste
```

## Docker:
- Criar imagem e rodar aplicação
```
cd EF.Console
docker build -f EF.Console\Dockerfile -t app-ef-console .
docker run -d --name AppEfConsole app-ef-console
```