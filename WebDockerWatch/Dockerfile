#FROM mcr.microsoft.com/dotnet/sdk:5.0-focal     
#ENV DOTNET_USE_POLLING_FILE_WATCHER 1
#ARG BUILD_CONFIGURATION=Debug
#ENV ASPNETCORE_ENVIRONMENT=Development
#ENV DOTNET_USE_POLLING_FILE_WATCHER=true  
#ENV ASPNETCORE_URLS=http://+:80  
#EXPOSE 80
#EXPOSE 5000-5001
#
#WORKDIR /code/app
#COPY [".", "WebDockerWatch/"]
#RUN dotnet restore "WebDockerWatch/WebDockerWatch.csproj"
#
#ENTRYPOINT dotnet watch  --project /code/app/WebDockerWatch/WebDockerWatch.csproj run --no-restore
FROM mcr.microsoft.com/dotnet/sdk:5.0-focal     

RUN apt-get update
RUN apt-get -y --no-install-recommends install unzip
RUN apt-get -y --no-install-recommends install procps
RUN rm -rf /var/lib/apt/lists/*

RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /vsdbg


WORKDIR /code/app
VOLUME /code/app
COPY [".", "WebDockerWatch/"]
RUN dotnet restore "WebDockerWatch/WebDockerWatch.csproj"

ENTRYPOINT dotnet watch  --project /code/app/WebDockerWatch/WebDockerWatch.csproj run --no-restore
