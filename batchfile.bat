@ECHO OFF 
call D:
call D:\OneDrive - Constellation HomeBuilder Systems\VSprojects\SauceLabs\bin\Debug
call vstest.console.exe SauceLabs.dll /logger:trx
call TrxerConsole.exe "D:\OneDrive - Constellation HomeBuilder Systems\VSprojects\SauceLabs\bin\Debug\TestResults\sauddser_CRKRL-SAUDDSER1_2022-02-09_16_30_50.trx"

