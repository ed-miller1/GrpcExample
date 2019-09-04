"Begin settings up grpc test environment..."
$script = New-Object Net.WebClient
#$script | Get-Member
#$script.DownloadString("https://chocolatey.org/install.ps1")
iwr https://chocolatey.org/install.ps1 -UseBasicParsing | iex
choco upgrade chocolatey
choco install -y python3
py -V
py -m pip install --upgrade pip --user
py -m pip install requests --user
py -m pip install grpcio-tools --user
py -m pip install grpcio --user
"Finished settings up grpc test environment."

$confirm = Read-Host "Would you like to run PersonClient.py?"
if($confirm -eq 'y'){
    py PersonClient.py
}

"Process Complete"