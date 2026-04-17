@echo off
echo Installing required workloads...
dotnet workload install android
dotnet workload install maui

echo Restoring required workloads...
dotnet workload restore

echo Building Android APK...
dotnet build MobileClient/MobileClient.csproj -f net6.0-android

echo Build process completed. APK file should be generated in the bin directory.
pause
