FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/TodosAppABP.Web.Host/TodosAppABP.Web.Host.csproj", "src/TodosAppABP.Web.Host/"]
COPY ["src/TodosAppABP.Web.Core/TodosAppABP.Web.Core.csproj", "src/TodosAppABP.Web.Core/"]
COPY ["src/TodosAppABP.Application/TodosAppABP.Application.csproj", "src/TodosAppABP.Application/"]
COPY ["src/TodosAppABP.Core/TodosAppABP.Core.csproj", "src/TodosAppABP.Core/"]
COPY ["src/TodosAppABP.EntityFrameworkCore/TodosAppABP.EntityFrameworkCore.csproj", "src/TodosAppABP.EntityFrameworkCore/"]
WORKDIR "/src/src/TodosAppABP.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TodosAppABP.Web.Host", "src/TodosAppABP.Web.Host"]
COPY ["src/TodosAppABP.Web.Core", "src/TodosAppABP.Web.Core"]
COPY ["src/TodosAppABP.Application", "src/TodosAppABP.Application"]
COPY ["src/TodosAppABP.Core", "src/TodosAppABP.Core"]
COPY ["src/TodosAppABP.EntityFrameworkCore", "src/TodosAppABP.EntityFrameworkCore"]
WORKDIR "/src/src/TodosAppABP.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TodosAppABP.Web.Host.dll"]
