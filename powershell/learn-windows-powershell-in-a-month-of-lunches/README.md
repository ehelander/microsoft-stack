# learn-windows-powershell-in-a-month-of-lunches

- [learn-windows-powershell-in-a-month-of-lunches](#learn-windows-powershell-in-a-month-of-lunches)
  - [3.6 Lab](#36-lab)
  - [4.10 Lab](#410-lab)

## 3.6 Lab

In Administrator PowerShell window:

```ps1
Update-Help
```

Error:

```log
Update-Help : Failed to update Help for the module(s) 'ConfigDefender, HostNetworkingService,
PSReadline, WindowsUpdateProvider' with UI culture(s) {en-US} : Unable to retrieve the
HelpInfo XML file for UI culture en-US. Make sure the HelpInfoUri property in the module
manifest is valid or check your network connection and then try the command again.
At line:1 char:1
+ Update-Help
+ ~~~~~~~~~~~
    + CategoryInfo          : ResourceUnavailable: (:) [Update-Help], Exception
    + FullyQualifiedErrorId : UnableToRetrieveHelpInfoXml,Microsoft.PowerShell.Commands.Update
   HelpCommand

Update-Help : Failed to update Help for the module(s) 'HgsClient, HgsDiagnostics' with UI
culture(s) {en-US} : Unable to connect to Help content. The server on which Help content is
stored might not be available. Verify that the server is available, or wait until the server
is back online, and then try the command again.
At line:1 char:1
+ Update-Help
+ ~~~~~~~~~~~
    + CategoryInfo          : InvalidOperation: (:) [Update-Help], Exception
    + FullyQualifiedErrorId : UnableToConnect,Microsoft.PowerShell.Commands.UpdateHelpCommand
```

- https://github.com/MicrosoftDocs/windows-powershell-docs/issues/139

```ps1
Help *html*
Help ConvertTo-Html
Help ConvertTo-Html -Online
Help ConvertTo-Html -Example
```

```ps1
Help *file*
Help Out-File
Help Out*printer*
Help Out-Printer
```

```txt
C:\Users\eric.helander> $processCmdlets = Help *process*
C:\Users\eric.helander> $processCmdlets.Length
24
```

```txt
C:\Users\eric.helander> Help *write*log*

NAME
    Write-EventLog
```

```txt
C:\Users\eric.helander> Help *alias*

Name                              Category  Module                    Synopsis
----                              --------  ------                    --------
Export-Alias                      Cmdlet    Microsoft.PowerShell.U... Exports information ab...
Get-Alias                         Cmdlet    Microsoft.PowerShell.U... Gets the aliases for t...
Import-Alias                      Cmdlet    Microsoft.PowerShell.U... Imports an alias list ...
New-Alias                         Cmdlet    Microsoft.PowerShell.U... Creates a new alias.
Set-Alias                         Cmdlet    Microsoft.PowerShell.U... Creates or changes an ...
New-AzureRmSqlServerDnsAlias      Cmdlet    AzureRM.Sql               New-AzureRmSqlServerDn...
Remove-AzureRmSqlServerDnsAlias   Cmdlet    AzureRM.Sql               Remove-AzureRmSqlServe...
Get-AzureRmSqlServerDnsAlias      Cmdlet    AzureRM.Sql               Get-AzureRmSqlServerDn...
Set-AzureRmSqlServerDnsAlias      Cmdlet    AzureRM.Sql               Set-AzureRmSqlServerDn...
about_Aliases                     HelpFile
about_Alias_Provider              HelpFile
```

```txt
C:\Users\eric.helander> help transcript

Name                              Category  Module                    Synopsis
----                              --------  ------                    --------
Start-Transcript                  Cmdlet    Microsoft.PowerShell.Host Creates a record of al...
Stop-Transcript                   Cmdlet    Microsoft.PowerShell.Host Stops a transcript.
```

```txt
C:\Users\eric.helander> help *event*log*

Name                              Category  Module                    Synopsis
----                              --------  ------                    --------
Clear-EventLog                    Cmdlet    Microsoft.PowerShell.M... Clears all entries fro...
Get-EventLog                      Cmdlet    Microsoft.PowerShell.M... Gets the events in an ...
Limit-EventLog                    Cmdlet    Microsoft.PowerShell.M... Sets the event log pro...
New-EventLog                      Cmdlet    Microsoft.PowerShell.M... Creates a new event lo...
Remove-EventLog                   Cmdlet    Microsoft.PowerShell.M... Deletes an event log o...
Show-EventLog                     Cmdlet    Microsoft.PowerShell.M... Displays the event log...
Write-EventLog                    Cmdlet    Microsoft.PowerShell.M... Writes an event to an ...
about_Eventlogs                   HelpFile
```

```txt
C:\Users\eric.helander> Help Get-EventLog

NAME
    Get-EventLog

SYNOPSIS
    Gets the events in an event log, or a list of the event logs, on the local computer or
    remote computers.


SYNTAX
    Get-EventLog [-LogName] <System.String> [[-InstanceId] <System.Int64[]>] [-After
    <System.DateTime>] [-AsBaseObject] [-Before <System.DateTime>] [-ComputerName
    <System.String[]>] [-EntryType {Error | Information | FailureAudit | SuccessAudit |
    Warning}] [-Index <System.Int32[]>] [-Message <System.String>] [-Newest <System.Int32>]
    [-Source <System.String[]>] [-UserName <System.String[]>] [<CommonParameters>]

    Get-EventLog [-AsString] [-ComputerName <System.String[]>] [-List] [<CommonParameters>]
```

```txt
C:\Users\eric.helander> Get-EventLog -Newest 100

cmdlet Get-EventLog at command pipeline position 1
Supply values for the following parameters:
LogName: security
```

```txt
C:\Users\eric.helander> help service

Name                              Category  Module                    Synopsis
----                              --------  ------                    --------
Get-Service                       Cmdlet    Microsoft.PowerShell.M... Gets the services on a local or remote computer.
```

```txt
C:\Users\eric.helander> help process

Name                              Category  Module                    Synopsis
----                              --------  ------                    --------
Enter-PSHostProcess               Cmdlet    Microsoft.PowerShell.Core Connects to and enters into an interactive session with a local process.
Exit-PSHostProcess                Cmdlet    Microsoft.PowerShell.Core Closes an interactive session with a local process.
Get-PSHostProcessInfo             Cmdlet    Microsoft.PowerShell.Core Gets process information about the PowerShell host.
Debug-Process                     Cmdlet    Microsoft.PowerShell.M... Debugs one or more processes running on the local computer.
Get-Process                       Cmdlet    Microsoft.PowerShell.M... Gets the processes that are running on the local computer or a remote .
```

```txt
C:\Users\eric.helander> help out-file

NAME
    Out-File

SYNOPSIS
    Sends output to a file.


SYNTAX
    Out-File [-FilePath] <System.String> [[-Encoding] {ASCII | BigEndianUnicode | Default | OEM | String | Unicode | Unknown | UTF7 | UTF8 |
    UTF32}] [-Append] [-Force] [-InputObject <System.Management.Automation.PSObject>] [-NoClobber] [-NoNewline] [-Width <System.Int32>]
    [-Confirm] [-WhatIf] [<CommonParameters>]

    Out-File [[-Encoding] {ASCII | BigEndianUnicode | Default | OEM | String | Unicode | Unknown | UTF7 | UTF8 | UTF32}] [-Append] [-Force]
    [-InputObject <System.Management.Automation.PSObject>] -LiteralPath <System.String> [-NoClobber] [-NoNewline] [-Width <System.Int32>]
    [-Confirm] [-WhatIf] [<CommonParameters>]
```

```ps1
help out-file -detailed
```

```txt
-NoClobber <System.Management.Automation.SwitchParameter>
        NoClobber prevents an existing file from being overwritten and displays a message that the file already exists. By default, if a file
        exists in the specified path, `Out-File` overwrites the file without warning.
```

```txt
C:\Users\eric.helander>  help alias

Name                              Category  Module                    Synopsis
----                              --------  ------                    --------
Export-Alias                      Cmdlet    Microsoft.PowerShell.U... Exports information about currently defined aliases to a file.
Get-Alias                         Cmdlet    Microsoft.PowerShell.U... Gets the aliases for the current session.
Import-Alias                      Cmdlet    Microsoft.PowerShell.U... Imports an alias list from a file.
New-Alias                         Cmdlet    Microsoft.PowerShell.U... Creates a new alias.
Set-Alias                         Cmdlet    Microsoft.PowerShell.U... Creates or changes an alias for a cmdlet or other command in the curre...
New-AzureRmSqlServerDnsAlias      Cmdlet    AzureRM.Sql               New-AzureRmSqlServerDnsAlias...
Remove-AzureRmSqlServerDnsAlias   Cmdlet    AzureRM.Sql               Remove-AzureRmSqlServerDnsAlias...
Get-AzureRmSqlServerDnsAlias      Cmdlet    AzureRM.Sql               Get-AzureRmSqlServerDnsAlias...
Set-AzureRmSqlServerDnsAlias      Cmdlet    AzureRM.Sql               Set-AzureRmSqlServerDnsAlias...
about_Aliases                     HelpFile
about_Alias_Provider              HelpFile



C:\Users\eric.helander> Export-Alias

cmdlet Export-Alias at command pipeline position 1
Supply values for the following parameters:
Path: aliases.txt
C:\Users\eric.helander> Get-Content .\aliases.txt
# Alias File
# Exported by : eric.helander
# Date/Time : Friday, August 27, 2021 9:59:40 PM
# Computer : EHELANDERSP20
"foreach","ForEach-Object","","ReadOnly, AllScope"
"%","ForEach-Object","","ReadOnly, AllScope"
"where","Where-Object","","ReadOnly, AllScope"
"?","Where-Object","","ReadOnly, AllScope"
"ac","Add-Content","","ReadOnly, AllScope"
"clc","Clear-Content","","ReadOnly, AllScope"
"cli","Clear-Item","","ReadOnly, AllScope"
"clp","Clear-ItemProperty","","ReadOnly, AllScope"
"clv","Clear-Variable","","ReadOnly, AllScope"
"compare","Compare-Object","","ReadOnly, AllScope"
"cpi","Copy-Item","","ReadOnly, AllScope"
"cpp","Copy-ItemProperty","","ReadOnly, AllScope"
"cvpa","Convert-Path","","ReadOnly, AllScope"
"dbp","Disable-PSBreakpoint","","ReadOnly, AllScope"
"diff","Compare-Object","","ReadOnly, AllScope"
"ebp","Enable-PSBreakpoint","","ReadOnly, AllScope"
"epal","Export-Alias","","ReadOnly, AllScope"
"epcsv","Export-Csv","","ReadOnly, AllScope"
"fc","Format-Custom","","ReadOnly, AllScope"
"fl","Format-List","","ReadOnly, AllScope"
"ft","Format-Table","","ReadOnly, AllScope"
"fw","Format-Wide","","ReadOnly, AllScope"
"gal","Get-Alias","","ReadOnly, AllScope"
"gbp","Get-PSBreakpoint","","ReadOnly, AllScope"
"gc","Get-Content","","ReadOnly, AllScope"
"gci","Get-ChildItem","","ReadOnly, AllScope"
"gcm","Get-Command","","ReadOnly, AllScope"
"gdr","Get-PSDrive","","ReadOnly, AllScope"
"gcs","Get-PSCallStack","","ReadOnly, AllScope"
"ghy","Get-History","","ReadOnly, AllScope"
"gi","Get-Item","","ReadOnly, AllScope"
"gl","Get-Location","","ReadOnly, AllScope"
"gm","Get-Member","","ReadOnly, AllScope"
"gmo","Get-Module","","ReadOnly, AllScope"
"gp","Get-ItemProperty","","ReadOnly, AllScope"
"gpv","Get-ItemPropertyValue","","ReadOnly, AllScope"
"gps","Get-Process","","ReadOnly, AllScope"
"group","Group-Object","","ReadOnly, AllScope"
"gsv","Get-Service","","ReadOnly, AllScope"
"gu","Get-Unique","","ReadOnly, AllScope"
"gv","Get-Variable","","ReadOnly, AllScope"
"iex","Invoke-Expression","","ReadOnly, AllScope"
"ihy","Invoke-History","","ReadOnly, AllScope"
"ii","Invoke-Item","","ReadOnly, AllScope"
"ipmo","Import-Module","","ReadOnly, AllScope"
"ipal","Import-Alias","","ReadOnly, AllScope"
"ipcsv","Import-Csv","","ReadOnly, AllScope"
"measure","Measure-Object","","ReadOnly, AllScope"
"mi","Move-Item","","ReadOnly, AllScope"
"mp","Move-ItemProperty","","ReadOnly, AllScope"
"nal","New-Alias","","ReadOnly, AllScope"
"ndr","New-PSDrive","","ReadOnly, AllScope"
"ni","New-Item","","ReadOnly, AllScope"
"nv","New-Variable","","ReadOnly, AllScope"
"nmo","New-Module","","ReadOnly, AllScope"
"oh","Out-Host","","ReadOnly, AllScope"
"rbp","Remove-PSBreakpoint","","ReadOnly, AllScope"
"rdr","Remove-PSDrive","","ReadOnly, AllScope"
"ri","Remove-Item","","ReadOnly, AllScope"
"rni","Rename-Item","","ReadOnly, AllScope"
"rnp","Rename-ItemProperty","","ReadOnly, AllScope"
"rp","Remove-ItemProperty","","ReadOnly, AllScope"
"rmo","Remove-Module","","ReadOnly, AllScope"
"rv","Remove-Variable","","ReadOnly, AllScope"
"rvpa","Resolve-Path","","ReadOnly, AllScope"
"sal","Set-Alias","","ReadOnly, AllScope"
"sasv","Start-Service","","ReadOnly, AllScope"
"sbp","Set-PSBreakpoint","","ReadOnly, AllScope"
"sc","Set-Content","","ReadOnly, AllScope"
"select","Select-Object","","ReadOnly, AllScope"
"si","Set-Item","","ReadOnly, AllScope"
"sl","Set-Location","","ReadOnly, AllScope"
"sleep","Start-Sleep","","ReadOnly, AllScope"
"sort","Sort-Object","","ReadOnly, AllScope"
"sp","Set-ItemProperty","","ReadOnly, AllScope"
"saps","Start-Process","","ReadOnly, AllScope"
"start","Start-Process","","ReadOnly, AllScope"
"spps","Stop-Process","","ReadOnly, AllScope"
"spsv","Stop-Service","","ReadOnly, AllScope"
"sv","Set-Variable","","ReadOnly, AllScope"
"tee","Tee-Object","","ReadOnly, AllScope"
"write","Write-Output","","ReadOnly, AllScope"
"irm","Invoke-RestMethod","","ReadOnly, AllScope"
"iwr","Invoke-WebRequest","","ReadOnly, AllScope"
"asnp","Add-PSSnapIn","","ReadOnly, AllScope"
"gsnp","Get-PSSnapIn","","ReadOnly, AllScope"
"gwmi","Get-WmiObject","","ReadOnly, AllScope"
"iwmi","Invoke-WMIMethod","","ReadOnly, AllScope"
"ogv","Out-GridView","","ReadOnly, AllScope"
"ise","powershell_ise.exe","","ReadOnly, AllScope"
"rsnp","Remove-PSSnapin","","ReadOnly, AllScope"
"rwmi","Remove-WMIObject","","ReadOnly, AllScope"
"swmi","Set-WMIInstance","","ReadOnly, AllScope"
"shcm","Show-Command","","ReadOnly, AllScope"
"trcm","Trace-Command","","ReadOnly, AllScope"
"wget","Invoke-WebRequest","","AllScope"
"curl","Invoke-WebRequest","","AllScope"
"lp","Out-Printer","","AllScope"
"cat","Get-Content","","AllScope"
"cd","Set-Location","","AllScope"
"clear","Clear-Host","","AllScope"
"cp","Copy-Item","","AllScope"
"h","Get-History","","AllScope"
"history","Get-History","","AllScope"
"kill","Stop-Process","","AllScope"
"ls","Get-ChildItem","","AllScope"
"man","help","","AllScope"
"mount","New-PSDrive","","AllScope"
"md","mkdir","","AllScope"
"mv","Move-Item","","AllScope"
"popd","Pop-Location","","AllScope"
"ps","Get-Process","","AllScope"
"pushd","Push-Location","","AllScope"
"pwd","Get-Location","","AllScope"
"r","Invoke-History","","AllScope"
"rm","Remove-Item","","AllScope"
"rmdir","Remove-Item","","AllScope"
"echo","Write-Output","","AllScope"
"cls","Clear-Host","","AllScope"
"chdir","Set-Location","","AllScope"
"copy","Copy-Item","","AllScope"
"del","Remove-Item","","AllScope"
"dir","Get-ChildItem","","AllScope"
"erase","Remove-Item","","AllScope"
"move","Move-Item","","AllScope"
"rd","Remove-Item","","AllScope"
"ren","Rename-Item","","AllScope"
"set","Set-Variable","","AllScope"
"type","Get-Content","","AllScope"
"icm","Invoke-Command","","AllScope"
"clhy","Clear-History","","ReadOnly, AllScope"
"gjb","Get-Job","","AllScope"
"rcjb","Receive-Job","","AllScope"
"rjb","Remove-Job","","AllScope"
"sajb","Start-Job","","AllScope"
"spjb","Stop-Job","","AllScope"
"wjb","Wait-Job","","AllScope"
"sujb","Suspend-Job","","AllScope"
"rujb","Resume-Job","","AllScope"
"npssc","New-PSSessionConfigurationFile","","ReadOnly, AllScope"
"ipsn","Import-PSSession","","AllScope"
"epsn","Export-PSSession","","AllScope"
"cnsn","Connect-PSSession","","ReadOnly, AllScope"
"dnsn","Disconnect-PSSession","","ReadOnly, AllScope"
"nsn","New-PSSession","","AllScope"
"gsn","Get-PSSession","","AllScope"
"rsn","Remove-PSSession","","AllScope"
"etsn","Enter-PSSession","","AllScope"
"rcsn","Receive-PSSession","","ReadOnly, AllScope"
"exsn","Exit-PSSession","","AllScope"
"sls","Select-String","","None"
"gcb","Get-Clipboard","","None"
"gin","Get-ComputerInfo","","None"
"gtz","Get-TimeZone","","None"
"scb","Set-Clipboard","","None"
"stz","Set-TimeZone","","None"
"CFS","ConvertFrom-String","","None"
"fhx","Format-Hex","","None"
```

```ps1
gps -comp Server1
```

```txt
C:\Users\eric.helander> $objectCmdlets = help object
C:\Users\eric.helander> $objectCmdlets.Length
28
```

```txt
C:\Users\eric.helander> help *array*


ABOUT_ARRAYS


Short Description

Describes arrays, which are data structures designed to store collections
of items.
```

## 4.10 Lab

List of running processes:

```txt
C:\WINDOWS\system32> Get-Process

Handles  NPM(K)    PM(K)      WS(K)     CPU(s)     Id  SI ProcessName
-------  ------    -----      -----     ------     --  -- -----------
    397      19    15920      18680             20116   0 amagent
    354      21    11316      30864       0.06  70200   1 ApplicationFrameHost
    134       9     1932       6620             20124   0 armsvc
    219      12     8240      15940       0.91  32052   0 audiodg
    749      47    19008      13972       0.41  46112   1 background
```

```txt
C:\WINDOWS\system32> Get-EventLog -Newest 100
cmdlet Get-EventLog at command pipeline position 1
Supply values for the following parameters:
LogName: Application

   Index Time          EntryType   Source                 InstanceID Message
   ----- ----          ---------   ------                 ---------- -------
   29824 Sep 03 21:58  Information Windows Error Rep...         1001 Fault bucket LKD_0x17D_TOAST_IMAGE_twinui.dll, type ...
   29823 Sep 03 21:58  Information Windows Error Rep...         1001 Fault bucket , type 0...
   29822 Sep 03 21:57  Information Software Protecti...   1073758208 Successfully scheduled Software Protection service f...
   29821 Sep 03 21:56  Information Software Protecti...   3221241866 Offline downlevel migration succeeded.
   29820 Sep 03 21:56  Information Software Protecti...   1073758208 Successfully scheduled Software Protection service f...
```

```txt
C:\WINDOWS\system32> Get-Command -CommandType Cmdlet

CommandType     Name                                               Version    Source
-----------     ----                                               -------    ------
Cmdlet          Add-AppvClientConnectionGroup                      1.0.0.0    AppvClient
Cmdlet          Add-AppvClientPackage                              1.0.0.0    AppvClient
Cmdlet          Add-AppvPublishingServer                           1.0.0.0    AppvClient
Cmdlet          Add-AppxPackage                                    2.0.1.0    Appx
Cmdlet          Add-AppxProvisionedPackage                         3.0        Dism
```

```txt
C:\WINDOWS\system32> Get-Alias

CommandType     Name                                               Version    Source
-----------     ----                                               -------    ------
Alias           % -> ForEach-Object
Alias           ? -> Where-Object
Alias           ac -> Add-Content
Alias           asnp -> Add-PSSnapin
Alias           cat -> Get-Content
Alias           cd -> Set-Location
Alias           CFS -> ConvertFrom-String                          3.1.0.0    Microsoft.PowerShell.Utility
Alias           chdir -> Set-Location
Alias           clc -> Clear-Content
Alias           clear -> Clear-Host
Alias           clhy -> Clear-History
Alias           cli -> Clear-Item
Alias           clp -> Clear-ItemProperty
Alias           cls -> Clear-Host
Alias           clv -> Clear-Variable
Alias           cnsn -> Connect-PSSession
Alias           compare -> Compare-Object
Alias           copy -> Copy-Item
Alias           cp -> Copy-Item
Alias           cpi -> Copy-Item
Alias           cpp -> Copy-ItemProperty
Alias           curl -> Invoke-WebRequest
Alias           cvpa -> Convert-Path
Alias           dbp -> Disable-PSBreakpoint
Alias           del -> Remove-Item
Alias           diff -> Compare-Object
Alias           dir -> Get-ChildItem
Alias           dnsn -> Disconnect-PSSession
Alias           ebp -> Enable-PSBreakpoint
Alias           echo -> Write-Output
Alias           epal -> Export-Alias
Alias           epcsv -> Export-Csv
Alias           epsn -> Export-PSSession
Alias           erase -> Remove-Item
Alias           etsn -> Enter-PSSession
Alias           exsn -> Exit-PSSession
Alias           fc -> Format-Custom
Alias           fhx -> Format-Hex                                  3.1.0.0    Microsoft.PowerShell.Utility
Alias           fl -> Format-List
Alias           foreach -> ForEach-Object
Alias           ft -> Format-Table
Alias           fw -> Format-Wide
Alias           gal -> Get-Alias
Alias           gbp -> Get-PSBreakpoint
Alias           gc -> Get-Content
Alias           gcb -> Get-Clipboard                               3.1.0.0    Microsoft.PowerShell.Management
Alias           gci -> Get-ChildItem
Alias           gcm -> Get-Command
Alias           gcs -> Get-PSCallStack
Alias           gdr -> Get-PSDrive
Alias           ghy -> Get-History
Alias           gi -> Get-Item
Alias           gin -> Get-ComputerInfo                            3.1.0.0    Microsoft.PowerShell.Management
Alias           gjb -> Get-Job
Alias           gl -> Get-Location
Alias           gm -> Get-Member
Alias           gmo -> Get-Module
Alias           gp -> Get-ItemProperty
Alias           gps -> Get-Process
Alias           gpv -> Get-ItemPropertyValue
Alias           group -> Group-Object
Alias           gsn -> Get-PSSession
Alias           gsnp -> Get-PSSnapin
Alias           gsv -> Get-Service
Alias           gtz -> Get-TimeZone                                3.1.0.0    Microsoft.PowerShell.Management
Alias           gu -> Get-Unique
Alias           gv -> Get-Variable
Alias           gwmi -> Get-WmiObject
Alias           h -> Get-History
Alias           history -> Get-History
Alias           icm -> Invoke-Command
Alias           iex -> Invoke-Expression
Alias           ihy -> Invoke-History
Alias           ii -> Invoke-Item
Alias           ipal -> Import-Alias
Alias           ipcsv -> Import-Csv
Alias           ipmo -> Import-Module
Alias           ipsn -> Import-PSSession
Alias           irm -> Invoke-RestMethod
Alias           ise -> powershell_ise.exe
Alias           iwmi -> Invoke-WmiMethod
Alias           iwr -> Invoke-WebRequest
Alias           kill -> Stop-Process
Alias           lp -> Out-Printer
Alias           ls -> Get-ChildItem
Alias           man -> help
Alias           md -> mkdir
Alias           measure -> Measure-Object
Alias           mi -> Move-Item
Alias           mount -> New-PSDrive
Alias           move -> Move-Item
Alias           mp -> Move-ItemProperty
Alias           mv -> Move-Item
Alias           nal -> New-Alias
Alias           ndr -> New-PSDrive
Alias           ni -> New-Item
Alias           nmo -> New-Module
Alias           npssc -> New-PSSessionConfigurationFile
Alias           nsn -> New-PSSession
Alias           nv -> New-Variable
Alias           ogv -> Out-GridView
Alias           oh -> Out-Host
Alias           popd -> Pop-Location
Alias           ps -> Get-Process
Alias           pushd -> Push-Location
Alias           pwd -> Get-Location
Alias           r -> Invoke-History
Alias           rbp -> Remove-PSBreakpoint
Alias           rcjb -> Receive-Job
Alias           rcsn -> Receive-PSSession
Alias           rd -> Remove-Item
Alias           rdr -> Remove-PSDrive
Alias           ren -> Rename-Item
Alias           ri -> Remove-Item
Alias           rjb -> Remove-Job
Alias           rm -> Remove-Item
Alias           rmdir -> Remove-Item
Alias           rmo -> Remove-Module
Alias           rni -> Rename-Item
Alias           rnp -> Rename-ItemProperty
Alias           rp -> Remove-ItemProperty
Alias           rsn -> Remove-PSSession
Alias           rsnp -> Remove-PSSnapin
Alias           rujb -> Resume-Job
Alias           rv -> Remove-Variable
Alias           rvpa -> Resolve-Path
Alias           rwmi -> Remove-WmiObject
Alias           sajb -> Start-Job
Alias           sal -> Set-Alias
Alias           saps -> Start-Process
Alias           sasv -> Start-Service
Alias           sbp -> Set-PSBreakpoint
Alias           sc -> Set-Content
Alias           scb -> Set-Clipboard                               3.1.0.0    Microsoft.PowerShell.Management
Alias           select -> Select-Object
Alias           set -> Set-Variable
Alias           shcm -> Show-Command
Alias           si -> Set-Item
Alias           sl -> Set-Location
Alias           sleep -> Start-Sleep
Alias           sls -> Select-String
Alias           sort -> Sort-Object
Alias           sp -> Set-ItemProperty
Alias           spjb -> Stop-Job
Alias           spps -> Stop-Process
Alias           spsv -> Stop-Service
Alias           start -> Start-Process
Alias           stz -> Set-TimeZone                                3.1.0.0    Microsoft.PowerShell.Management
Alias           sujb -> Suspend-Job
Alias           sv -> Set-Variable
Alias           swmi -> Set-WmiInstance
Alias           tee -> Tee-Object
Alias           trcm -> Trace-Command
Alias           type -> Get-Content
Alias           wget -> Invoke-WebRequest
Alias           where -> Where-Object
Alias           wjb -> Wait-Job
Alias           write -> Write-Output
```

```txt
C:\WINDOWS\system32> help New-Alias

NAME
    New-Alias

SYNOPSIS
    Creates a new alias.


SYNTAX
    New-Alias [-Name] <System.String> [-Value] <System.String> [-Description <System.String>] [-Force] [-Option {None |
    ReadOnly | Constant | Private | AllScope | Unspecified}] [-PassThru] [-Scope <System.String>] [-Confirm] [-WhatIf]
    [<CommonParameters>]


DESCRIPTION
    The `New-Alias` cmdlet creates a new alias in the current Windows PowerShell session. Aliases created by using
    `New-Alias` are not saved after you exit the session or close Windows PowerShell. You can use the `Export-Alias` cmdlet
    to save your alias information to a file. You can later use `Import-Alias` to retrieve that saved alias information.


RELATED LINKS
    Online Version: https://docs.microsoft.com/powershell/module/microsoft.powershell.utility/new-alias?view=powershell-5.1&
    WT.mc_id=ps-gethelp
    Export-Alias
    Get-Alias
    Import-Alias
    Set-Alias

REMARKS
    To see the examples, type: "get-help New-Alias -examples".
    For more information, type: "get-help New-Alias -detailed".
    For technical information, type: "get-help New-Alias -full".
    For online help, type: "get-help New-Alias -online"



C:\WINDOWS\system32> help new-alias -example

NAME
    New-Alias

SYNOPSIS
    Creates a new alias.


    ----------- Example 1: Create an alias for a cmdlet -----------

    New-Alias -Name "List" Get-ChildItem

    This command creates an alias named List to represent the Get-ChildItem cmdlet.
    ------- Example 2: Create a read-only alias for a cmdlet -------

    New-Alias -Name "C" -Value Get-ChildItem -Description "quick gci alias" -Option ReadOnly
    Get-Alias -Name "C" | Format-List *

    This command creates an alias named `C` to represent the `Get-ChildItem` cmdlet. It creates a description, quick wmi
    alias, for the alias and makes it read-only. The last line of the command uses `Get-Alias` to get the new alias and
    pipes it to Format-List to display all of the information about it.




C:\WINDOWS\system32> New-Alias -Name "np" .\notepad.exe

C:\WINDOWS\system32> np
```

```txt
C:\WINDOWS\system32> Get-Service m*

Status   Name               DisplayName
------   ----               -----------
Stopped  MapsBroker         Downloaded Maps Manager
Stopped  MessagingServic... MessagingService_3d44cf
Running  MHC.CPS.OnPremA... MHC CPS OnPremAgent
Stopped  MicrosoftEdgeEl... Microsoft Edge Elevation Service (M...
Running  MicrosoftSearch... Microsoft Search in Bing
Stopped  MixedRealityOpe... Windows Mixed Reality OpenXR Service
Stopped  MozillaMaintenance Mozilla Maintenance Service
Running  mpssvc             Windows Defender Firewall
Stopped  MSDTC              Distributed Transaction Coordinator
Stopped  MSiSCSI            Microsoft iSCSI Initiator Service
Stopped  msiserver          Windows Installer
Stopped  MsKeyboardFilter   Microsoft Keyboard Filter
```

```ps1
Get-NetFirewallRule

# Name                  : HNS Container Networking - DNS (UDP-In) - 244E48D1-C913-48B0-8C53-DDEA6710F86D - 0
# DisplayName           : HNS Container Networking - DNS (UDP-In) - 244E48D1-C913-48B0-8C53-DDEA6710F86D - 0
# Description           : HNS Container Networking - DNS (UDP-In) - 244E48D1-C913-48B0-8C53-DDEA6710F86D - 0
# DisplayGroup          :
# Group                 :
# Enabled               : True
# Profile               : Any
# Platform              : {}
# Direction             : Inbound
# Action                : Allow
# EdgeTraversalPolicy   : Block
# LooseSourceMapping    : False
# LocalOnlyMapping      : False
# Owner                 :
# PrimaryStatus         : OK
# Status                : The rule was parsed successfully from the store. (65536)
# EnforcementStatus     : NotApplicable
# PolicyStoreSource     : PersistentStore
# PolicyStoreSourceType : Local
```

```txt
C:\WINDOWS\system32> Get-NetFirewallRule -Direction Inbound
```
