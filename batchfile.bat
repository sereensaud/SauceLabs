@ECHO OFF
ECHO Demo Automation Execution Started.

set testCategory1=Login
set dllpath=D:\OneDrive - Constellation HomeBuilder Systems\VSprojects\SauceLabs\bin\Debug\SauceLabs.dll
set trxerpath=D:\OneDrive - Constellation HomeBuilder Systems\VSprojects\SauceLabs\bin\Debug
set reportpath=D:\OneDrive - Constellation HomeBuilder Systems\VSprojects\SauceLabs\Reports
set vsCmdRunner=C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat
set trxerConsolePath=D:\OneDrive - Constellation HomeBuilder Systems\VSprojects\SauceLabs\bin\Debug\TrxerConsole.exe

call "%vsCmdRunner%"
VSTest.Console.exe "%dllpath%" /TestCaseFilter:"(TestCategory=%testcategory1%)" /Logger:"trx;LogFileName=%reportpath%\Testdemo"

cd "%trxerpath%"
"%trxerConsolePath%" "%reportpath%"\Testdemo