@echo off
cls

@echo ----------------------------------
@echo configure dev
@echo ----------------------------------


@echo -- Executa script Powershell
set scriptFileName=%~n0
set scriptFolderPath=%~dp0
set powershellScriptFileName=%scriptFileName%.ps1
powershell -Command "Start-Process powershell \"-ExecutionPolicy Bypass -NoExit -Command `\"cd \`\"%scriptFolderPath%`\"; & \`\".\%powershellScriptFileName%\`\"`\"\" -Verb RunAs"

