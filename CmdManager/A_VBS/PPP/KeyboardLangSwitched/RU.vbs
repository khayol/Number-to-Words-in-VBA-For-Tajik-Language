'-----------------------------------------------
'Script Created By Khayol
On Error Resume Next 
'-----------------------------------------------
Dim shell: Dim i: Dim j: Dim WshShell
Set shell = wscript.CreateObject("Shell.Application")
Set WshShell = CreateObject("WScript.Shell")
'-----------------------------------------------
    resSTR =    "powershell "& chr(34) & "Set-WinUserLanguageList -LanguageList ru, en-us,tg-tj -force"& chr(34) 
	flgCOmOrNot="cmd"
    call OpenThisFolderOrRunFile(resSTR,flgCOmOrNot)
'-----------------------------------------------
Sub OpenThisFolderOrRunFile(pPath,pflgCOmOrNot)
   if pflgCOmOrNot="cmd" then
	WshShell.Run "cmd.exe /C" &  Chr(34) & pPath & Chr(34) ,0 '0 or  1
    else
	WshShell.Run   Chr(34) & pPath & Chr(34) ,0 '0 or  1
   end if   
End Sub
'-----------------------------------------------
WshShell=nothing
shell=nothing
'-----------------------------------------------

