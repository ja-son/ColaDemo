FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 8698
EXPOSE 44304

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Questions/Questions.csproj", "Questions/"]
RUN dotnet restore "Questions/Questions.csproj"
COPY . .
WORKDIR "/src/Questions"
RUN dotnet build "Questions.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Questions.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Questions.dll"]