#run dotnet core web apps for rest/grpc demo
#will assume user has .net core 3 and VS 2019 latest preview
#script will live in GrpcTests root folder and should be executed from there

dotnet restore ./TestGrpcService/
dotnet build ./TestGrpcService/TestGrpcService.csproj

# Invoke-Expression 'dotnet run --project ./PersonWebAPITest/PersonWebAPITest.csproj'
start powershell {dotnet run --project ./PersonWebAPITest/PersonWebAPITest.csproj; Read-Host}
dotnet run --project ./TestGrpcService/TestGrpcService.csproj

