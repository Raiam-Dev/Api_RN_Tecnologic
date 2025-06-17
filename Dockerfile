# Etapa de build com .NET 9.0 SDK
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copia os arquivos do projeto
COPY . ./

# Restaura dependências
RUN dotnet restore

# Publica o projeto em modo Release
RUN dotnet publish -c Release -o /out

# Etapa de runtime com imagem menor
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copia os arquivos compilados da etapa anterior
COPY --from=build /out ./

# Expõe a porta padrão
EXPOSE 80

# Define o ponto de entrada do app
ENTRYPOINT ["dotnet", "ApiLaboratorial.dll"]
