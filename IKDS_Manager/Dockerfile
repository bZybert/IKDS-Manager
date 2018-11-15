#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 50085
EXPOSE 44328

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["IKDS_Manager/IKDS_Manager.csproj", "IKDS_Manager/"]
RUN dotnet restore "IKDS_Manager/IKDS_Manager.csproj"
COPY . .
WORKDIR "/src/IKDS_Manager"
RUN dotnet build "IKDS_Manager.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "IKDS_Manager.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "IKDS_Manager.dll"]