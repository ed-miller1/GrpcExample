#run dotnet core web apps for rest/grpc demo
#will assume user has .net core 3 and VS 2019 latest preview
#script will live in GrpcTests root folder and should be executed from there

#Build and run Service
dotnet restore ./GrpcExampleService/
dotnet build ./GrpcExampleService/GrpcExampleService.csproj
start powershell {dotnet run --project ./GrpcExampleService/GrpcExampleService.csproj; Read-Host }

#Run client
py ./PythonClient/PersonClient.py localhost:5001 5000 True