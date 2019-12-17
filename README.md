# gRPC Test Programs

# Introduction 
The purpose of these programs is to test the capabilities and perform simple performance benchmarks for gRPC. The benchmarks are against a rest api of similar operations.

gRPC, per wikipedia, is "an open source remote procedure call (RPC) system initially developed at Google. It uses HTTP/2 for transport, Protocol Buffers as the interface description language, and provides features such as authentication, bidirectional streaming and flow control, blocking or nonblocking bindings, and cancellation and timeouts. It generates cross-platform client and server bindings for many languages. Most common usage scenarios include connecting services in microservices style architecture and connect mobile devices, browser clients to backend services."

This project consists of the following programs:
1.  TestGrpcService - the grpc service implemented in .net core 3
2.  PersonWebAPITest - the rest api that has identical operations to TestGrpcService. Implemented in .net core 3.
3.  pyclient - a gRPC client implemented in python 3. This client also tallies benchmark data.

# Prerequisites
1.  The latest version of Visual Studio (2019 or greater).
2.  An azure sql instance, this is required for some functionality in the API and gRPC service to work properly.

Visual Studio:
https://visualstudio.microsoft.com/vs/

# Azure setup
As mentioned prior, an Azure SQL instance is required as well as updating appsettings with the instance db connection.

For database instance creation:
1.  In portal.azure.com, navigate to SQL databases and select +Add
2.  Select the desired Subscription, Resource Group, Database name.
3.  For Server, select create new
4.  Select a name, admin login name, admin password, and location (US East is typically standard) and select OK.
5.  Under Compute + Storage, select Configure database
6.  For Compute tier, select Serverless. All other defaults can remain the same. Select Apply.
7.  Select Review + create

Once the database has been created, you can use the below pattern to enter the connection string in the appsettings of both PersonWebAPITest and TestGrpcService. The location will be found here within the json: ConnectionStrings:GrpcDb.

Connection String pattern:
Server=EXAMPLE_DATABASE_SERVER_NAME.database.windows.net;Database=EXAMPLE_DATABASE_NAME;User Id=EXAMPLE_USERNAME;Password=EXAMPLE_PASSWORD;

# Run locally
Once the Azure SQL Instance is created and the connection strings within the .net programs are updated, the following steps can be taken to run the applications:
1.	Execute the following command in a new powershell window: "./BuildRunWebServices.ps1" - NOTE: be sure to navigate to project root folder
2.	Get the port numbers for the instances.
3.	Open '/pyclient/PersonClient.py' and edit the appropriate port numbers for grpc_host and rest_host on lines 13/14.
4.	Open a new powershell window and navigate to the pyclient folder. Execute './ClientSetup.ps1'. This script will download python3 and all required libraries. it will give you an option to run the client.
5.  Once python and the client libraries are installed, the following command can be executed to run the client: 'py PersonClient.py'

# Python Libraries
* requests - for http functionality
* grpcio-tools - tooling for gRPC
* grpcio - the main gRPC library

# Feedback
Any questions or feedback can be directed to emiller@rightpoint.com or miller.edwardg@gmail.com with the Subject 'gRPC Example: YOUR TOPIC'