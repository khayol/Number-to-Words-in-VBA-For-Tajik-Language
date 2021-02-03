Dim WshShell
Dim objReg
Dim cmdArr(100)
Dim AllAddCmdArr(100)
Dim maxCmdArr
Dim maxAllAddCmdArr
Dim txt_chooes_opt
Dim chooes_opt
Dim path1
Dim pathFull
Dim pathFullEN
Dim pathFullRU
Dim cmdName

Set WshShell = CreateObject("WScript.Shell")
	'подключение к WMI
Set objReg = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\default:StdRegProv")
    ' Run As Admin
	if WScript.Arguments.length=0 then
	Set ObjShell=CreateObject("Shell.Application")
	ObjShell.ShellExecute "wscript.exe" _
	,"""" & WScript.ScriptFullName & """ RunAsAdministrator", ,"runas",1
	WScript.Quit
	end if

Const HKEY_LOCAL_MACHINE 	= &H80000002
'Const HKEY_CLASSES_ROOT 	= &H80000000
'Const HKEY_CURRENT_USER 	= &H80000001
'Const HKEY_USERS 	    	= &H80000003
'Const HKEY_CURRENT_CONFIG 	= &H80000005


	AllAddCmdArr(1)=Array("","a","ф","E:\D_KhProgrammFiles2\A_VBS\MyDesktopManager.vbs")
	AllAddCmdArr(2)=Array("","s","ы","E:\D_KhProgrammFiles2\A_VBS\CopyToClipboard.vbs")
	AllAddCmdArr(3)=Array("","d","в","E:\D_KhProgrammFiles2\A_VBS\DiffFile\NOTES.txt")
	AllAddCmdArr(4)=Array("","1","1","E:\D_KhProgrammFiles2\A_VBS\DotNetSqlServManager\DotNetSqlServManager.vbs")
	AllAddCmdArr(5)=Array("","2","2","E:\CURRPJ")
	maxAllAddCmdArr=5
	
	



    cmdArr(1)=Array("","Delete Additional  CMD","")
    cmdArr(2)=Array("","Create Additional CMD","")
	cmdArr(3)=Array("","Delete All Additional CMDs","")
    cmdArr(4)=Array("","Create All Additional CMDs","")
	cmdArr(5)=Array("","Open the Folder of All Additional CMDs","")
	maxCmdArr=5
	
	txt_chooes_opt=""
	For j= 1 to UBound(cmdArr)
		if j<=maxCmdArr then
		txt_chooes_opt=txt_chooes_opt & j & " - " & cmdArr(j)(1) & Chr(13)
		end if
	next
	txt_chooes_opt=txt_chooes_opt & Chr(13) & Chr(13) & " choose the operations"
	chooes_opt= InputBox(txt_chooes_opt,"Operations","5")


  
if chooes_opt=1  then 'Delete Additional  CMD
   cmdName= InputBox("Enter the Name Of CMD","")
   path1="SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\"
   pathFull=path1 & cmdName & ".exe"  

		objReg.DeleteKey HKEY_LOCAL_MACHINE, pathFull	
		WScript.Echo cmdName &  " was Deleted!"
elseif chooes_opt=2  then 'Create Additional CMD
   cmdName= InputBox("Enter the Name Of CMD","")
   path1="SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\"
   pathFull=path1 & cmdName & ".exe"  


		objReg.DeleteKey HKEY_LOCAL_MACHINE, pathFull

		appPath= InputBox("Enter the Application Path","")
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
elseif chooes_opt=3  then 'Delete All Additional CMDs

	For k= 1 to UBound(AllAddCmdArr)
	if k<=maxAllAddCmdArr then
	 path1="SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\"
     pathFullEN=path1 & AllAddCmdArr(k)(1) & ".exe":
	 pathFullRU=path1 & AllAddCmdArr(k)(2) & ".exe"
	 objReg.DeleteKey HKEY_LOCAL_MACHINE, pathFullEN	
	 objReg.DeleteKey HKEY_LOCAL_MACHINE, pathFullRU	
	end if
	next
		WScript.Echo cmdName &  " All Addi CMDs were Deleted!"
elseif chooes_opt=4  then 'Create All Additional CMDs

For k= 1 to UBound(AllAddCmdArr)
	if k<=maxAllAddCmdArr then
	 path1="SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\"
     pathFullEN=path1 & AllAddCmdArr(k)(1) & ".exe": 
	 pathFullRU=path1 & AllAddCmdArr(k)(2) & ".exe"
	 objReg.DeleteKey HKEY_LOCAL_MACHINE, pathFullEN	
	 objReg.DeleteKey HKEY_LOCAL_MACHINE, pathFullRU
	 
	 'EN-----------------------------------------------------------
	 if AllAddCmdArr(k)(1)<>"" and AllAddCmdArr(k)(3)<>"" then
	 intRes = objReg.CreateKey(HKEY_LOCAL_MACHINE, pathFullEN)
					If intRes <>0 Then
						WScript.Echo intRes & ": ERR"
						WScript.Quit
					End If
		   'strValueName="ValueName" ' This means the New Parameterwill created
			strValueName = ""  ' This means the Default value name
			strValue=AllAddCmdArr(k)(3)
		objReg.SetStringValue HKEY_LOCAL_MACHINE, pathFullEN, strValueName, strValue	
     End if
	'RU-----------------------------------------------------------
	if AllAddCmdArr(k)(2)<>"" and AllAddCmdArr(k)(3)<>"" then
	 intRes = objReg.CreateKey(HKEY_LOCAL_MACHINE, pathFullRU)
					If intRes <>0 Then
						WScript.Echo intRes & ": ERR"
						WScript.Quit
					End If
		   'strValueName="ValueName" ' This means the New Parameterwill created
			strValueName = ""  ' This means the Default value name
			strValue=AllAddCmdArr(k)(3)
		objReg.SetStringValue HKEY_LOCAL_MACHINE, pathFullRU, strValueName, strValue	
     end if
	'-----------------------------------------------------------	 
	 
	end if
	next
		WScript.Echo cmdName &  " All Addi CMDs were Created!"
		

elseif chooes_opt=5  then 'Open the Folder of All Additional CMDs
' 
      ' Nothing ' HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\excel.exe
	  'MsgBox "Choosed the incorrect CMD"
	  	JumpToKey=cmdName '"HKCU\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" 'Inputbox("Which registry key would you like to open?")
			WshShell.RegWrite "HKCU\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\",JumpToKey,"REG_SZ"
			WshShell.Run "regedit", 1,True
end if			
		
Set WshShell = Nothing		
			
			