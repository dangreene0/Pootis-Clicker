@ECHO off
echo Compiling build...
dotnet publish -r win-x64 -c Release --self-contained /p:PublishSingleFile=true
echo --------------------------------------------
echo Please add this into the project XML instead.
pause

# Sources:
# https://dotnetcoretutorials.com/2019/06/20/publishing-a-single-exe-file-in-net-core-3-0/
# https://dotnetcoretutorials.com/2019/06/27/the-publishtrimmed-flag-with-il-linker/