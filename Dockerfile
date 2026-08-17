# 1. 使用 .NET 10 SDK 進行編譯
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# 複製專案檔並還原套件
COPY ["rpgGame.csproj", "./"]
RUN dotnet restore "rpgGame.csproj"

# 複製所有程式碼並發布
COPY . .
RUN dotnet publish "rpgGame.csproj" -c Release -o /app/publish

# 2. 建立 .NET 10 輕量化執行環境
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# 設定環境變數讓 ASP.NET Core 監聽 8080 Port (Fly.io 預設 Port)
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "rpgGame.dll"]