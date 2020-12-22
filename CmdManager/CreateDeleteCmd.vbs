Dim objReg: Dim cmdArr(100)
Dim maxCmdArr: Dim txt_chooes_opt : Dim chooes_opt
Dim path1: Dim pathFull: Dim cmdName: Dim objFSO:Dim WshShell


Set WshShell = CreateObject("WScript.Shell")
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set ObjShell=CreateObject("Shell.Application")
	
CurrentDirectory=objFSO.GetAbsolutePathName(".")
CurrentFileName= objFSO.GetFileName(WScript.ScriptFullName)  '
CurrentFolderName = objFSO.GetFolder(CurrentDirectory).Name

FilePathCurrent= WScript.ScriptFullName  '
PathCurrent = objFSO.GetParentFolderName(FilePathCurrent)
PathParent = objFSO.GetParentFolderName(PathCurrent)

fileNameRunCmd=PathCurrent & "\" & "RunCmd.vbs"


	'подключение к WMI
Set objReg = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\default:StdRegProv")
    ' Run As Admin
	if WScript.Arguments.length=0 then
	ObjShell.ShellExecute "wscript.exe" _
	,"""" & WScript.ScriptFullName & """ RunAsAdministrator", ,"runas",1
	WScript.Quit
	end if

Const HKEY_LOCAL_MACHINE 	= &H80000002

    cmdArr(1)=Array("","Delete CMD","")
    cmdArr(2)=Array("","Create CMD","")
	maxCmdArr=2
	
	txt_chooes_opt=""
	For j= 1 to UBound(cmdArr)
		if j<=maxCmdArr then
		txt_chooes_opt=txt_chooes_opt & j & " - " & cmdArr(j)(1) & Chr(13)
		end if
	next
	txt_chooes_opt=txt_chooes_opt & Chr(13) & Chr(13) & " choose the operations"
	chooes_opt= InputBox(txt_chooes_opt,"Operations","3")


  
if chooes_opt=1  then 'Delete Additional  CMD
	   cmdName= InputBox("Enter Command Name for that Project","")
	   if  cmdName<>"" then
			path1="SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\"
			pathFull=path1 & cmdName & ".exe"  

			objReg.DeleteKey HKEY_LOCAL_MACHINE, pathFull	
			WScript.Echo cmdName &  " was Deleted!"
	   End if		
elseif chooes_opt=2  then 'Create Additional CMD
	cmdName= InputBox("Enter Command Name for that Project","")
	if  cmdName<>"" then
		path1="SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\"
		pathFull=path1 & cmdName & ".exe"  

		objReg.DeleteKey HKEY_LOCAL_MACHINE, pathFull

		appPath= fileNameRunCmd 'InputBox("Enter the Application Path","")
					'Создание разделов
					intRes = objReg.CreateKey(HKEY_LOCAL_MACHINE, pathFull)
					If intRes <>0 Then
						WScript.Echo intRes & ": ERR"
						WScript.Quit
					End If
		   'strValueName="ValueName" ' This means the New Parameterwill created
			strValueName = ""  ' This means the Default value name
			strValue=appPath
		objReg.SetStringValue HKEY_LOCAL_MACHINE, pathFull, strValueName, strValue	
		 WScript.Echo cmdName &  " was created"
	End if	 
else 
'Nothing
end if			
		
Set ObjShell=Nothing		
Set WshShell = Nothing
Set objFSO = Nothing		
			
			