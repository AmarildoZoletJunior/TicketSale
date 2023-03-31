#Baixa a imagem base do aspnet
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
#Cria uma pasta chamada APP
WORKDIR /app
#Abre a porta 80 e a 443
EXPOSE 80
EXPOSE 443
#Seta variável de ambiente com url para o swagger
ENV ASPNETCORE_URLS=http://+:8000;http://+:80;
#seleciona o ambiente de desenvolvimento
ENV ASPNETCORE_ENVIRONMENT=Development
#Baixa o sdk do .net
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#Cria uma pasta src
WORKDIR /src
#Copia todos os arquivos de build .csproj
COPY ["TicketSale.API/TicketSale.API.csproj","TicketSale.API/"]
COPY ["TicketSale.Application/TicketSale.Application.csproj","TicketSale.Application/"]
COPY ["TicketSale.CrossCutting/TicketSale.CrossCutting.csproj","TicketSale.CrossCutting/"]
COPY ["TicketSale.Data/TicketSale.Data.csproj","TicketSale.Data/"]
COPY ["TicketSale.Domain/TicketSale.Domain.csproj","TicketSale.Domain/"]

#Roda a restauração da api
RUN dotnet restore "TicketSale.API/TicketSale.API.csproj"
#copia o resto dos arquivos para dentro da pasta 
COPY . .
# cria uma pasta chamada ticketsale.api
WORKDIR "/src/TicketSale.API"
#roda o projeto de build da ticketsale.API.csproj
RUN dotnet build "TicketSale.API.csproj" -c Release -o /app/build
#Usa novamente o sdk do .net
FROM build As publish
#publica o ticketsale.API, gerando arquivos dll
RUN dotnet publish "TicketSale.API.csproj" -c Release -o /app/publish /p:UseAppHost=false
#Aqui ele usa a base do aspnet novamente
FROM base AS final
#cria outra pasta chamada app
WORKDIR /app
#Faz a chamada da publicação
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet","TicketSale.API.dll"]