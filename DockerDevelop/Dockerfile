FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app
COPY [".", "DockerDevelop/"]
RUN dotnet restore "DockerDevelop/DockerDevelop.csproj"

#ENTRYPOINT ["dotnet", "DockerDevelop.dll"]
ENTRYPOINT dotnet watch  --project /app/DockerDevelop/DockerDevelop.csproj run
