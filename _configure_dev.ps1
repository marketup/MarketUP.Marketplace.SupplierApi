$ErrorActionPreference = "Stop"
Import-Module WebAdministration 


"--> Configure WebApi"

$name = "api-supplier-marketplace.dev.marketup.com"
$path = "$PSScriptRoot\MarketUP.Marketplace.SupplierApi.WebApi"
$hosturl = "api-supplier-marketplace.dev.marketup.com"

if (-not(Test-Path "IIS:\AppPools\$name"))
{
	">> Create WebAppPool"
	New-WebAppPool -name $name -force
}

if (-not(Test-Path "IIS:\Sites\$name"))
{
	">> Create WebSite"
	new-WebSite -name $name -PhysicalPath $path -HostHeader $hosturl -ApplicationPool $name -force
	
	">> Add https bind"
	New-WebBinding -Name $name -Protocol "https" -Port 443 -HostHeader $hosturl
}
else
{
	">> Set WebSite path: $path"
	Set-ItemProperty "IIS:\Sites\$name" -name physicalPath -value $path
}

