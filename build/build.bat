@echo off
echo --------------------------------------------------------------------------------------
echo =====    B u i l d  P r o j e c t                                                 =====
echo --------------------------------------------------------------------------------------
"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MsBuild.exe" ..\MyShortcut.sln /t:rebuild  /P:Configuration=Release /v:q

echo --------------------------------------------------------------------------------------
echo =====    C o p y  A s s e m b l i e s                                            =====
echo --------------------------------------------------------------------------------------
echo 1. Copy MyShortcut.exe
copy ..\src\MyShortcut\bin\Release\MyShortcut.exe .\src\
echo 2. Copy Newtonsoft.Json.dll 
copy ..\src\MyShortcut\bin\Release\Newtonsoft.Json.dll .\src\


echo --------------------------------------------------------------------------------------
echo =====    M e r g e  A s s e m b l i e s                                          =====
echo --------------------------------------------------------------------------------------

:: this script needs https://www.nuget.org/packages/ilmerge

:: set your target executable name (typically [projectname].exe)
SET APP_NAME=MyShortcut.exe

:: Set build, used for directory. Typically Release or Debug
SET ILMERGE_BUILD=Release 

:: Set platform, typically x64
SET ILMERGE_PLATFORM=x64

:: set your NuGet ILMerge Version, this is the number from the package manager install, for example:
:: PM> Install-Package ilmerge -Version 3.0.29
:: to confirm it is installed for a given project, see the packages.config file
SET ILMERGE_VERSION=3.0.29

:: the full ILMerge should be found here:
SET ILMERGE_PATH=%USERPROFILE%\.nuget\packages\ilmerge\%ILMERGE_VERSION%\tools\net452
:: dir "%ILMERGE_PATH%"\ILMerge.exe

echo Merging %APP_NAME% ...

:: add project DLL's starting with replacing the FirstLib with this project's DLL   %ILMERGE_PLATFORM%\
"%ILMERGE_PATH%"\ILMerge.exe src\%APP_NAME%  ^
  /lib:src\ ^
  /out:dist\%APP_NAME% ^
  Newtonsoft.Json.dll
