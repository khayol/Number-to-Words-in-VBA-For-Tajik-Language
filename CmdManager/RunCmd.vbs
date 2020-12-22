'===============================================================================
   ' Script Created By: Khayol Noranjov
'===============================================================================
   ' Declaration Section and some  Initializations
   On Error Resume Next
	Dim LocArr(100)
	Dim GrCodeGenFile(200)
	Dim FileNames(500): Dim maxLocArr: Dim groupName: Dim migrPath
	Set objFSO = CreateObject("Scripting.FileSystemObject")
	'-------------------------------------------------------------------------
	  ' Run this script  As Administrator
	'if WScript.Arguments.length=0 then
	'Set ObjShellADmin=CreateObject("Shell.Application")
	'ObjShellADmin.ShellExecute "wscript.exe" _
	',"""" & WScript.ScriptFullName & """ RunAsAdministrator", ,"runas",1
	'WScript.Quit
	'end if
	
	
	'-------------------------------------------------------------------------
	Set oShell = WScript.CreateObject ("WScript.Shell")
	
	thisYear=Year(Now):  thisMonth=LPad(Month(Now), 2, "0") : 
	thisDay=LPad(Day(Now), 2, "0"):thisHour=LPad(Hour(Now), 2, "0"):
	thisMinute=LPad(Minute(Now), 2, "0") :thisSecond=LPad(Second(Now), 2, "0")
	thisTime=thisHour & thisMinute & thisSecond
	thisDate=thisYear & thisMonth & thisDay
	addAfterName="-" & thisDate & thisTime
    '-------------------------------------------------------------------------
	
'===============================================================================
                                  'Main Section
'===============================================================================

	strComputerNameFirst = oShell.ExpandEnvironmentStrings("%COMPUTERNAME%") 
	'if strComputerNameFirst="IMON" then
	'	chooseConnStr="DefaultConnection"
	'elseif strComputerNameFirst="HO-KHAYOL-PC" then
    '   chooseConnStr="hoConnStr2"
    'else
	'end if	
    chooseConnStr="."	
	defauldInputVal="19"
    '-------------------------	
	ConnStr=chooseConnStr
    '-------------------------	
	cmdFolder="\Data\Cmd"
	migrFolder="\Migrations"
	'-------------------------
	archiveFld="Archive" 
	dbArchFld="DbArch" 
	filesArchFld="FilesArch"
	slash="\"
    '-------------------------
	iURL_Site="https://localhost:5001"                                     ' Application URL
	cmdCreatorFile="CreateDeleteCmd.vbs"
	logFileName="_MyCurrentProjectsHistory.log"
	AppSettFile="appsettings.json"
	dbFileNameForRestore=""                                                ' первоначальное значение
	dbEx=".bak"                                                            ' Extantion of Db
	'------------------------
	passApp="Nav@2017"                                                    ' Application User Password for Testing 
	'------------------------
	sleep1=3000
	'------------------------
	
'===============================================================================
	CurrentDirectory = objFSO.GetAbsolutePathName(".")                     '"E:\D_KhProgrammFiles2\A_VBS\DotNetSqlServManager"    ' Location of this file ' OR use this => objFSO.GetAbsolutePathName(".")
	CurrentFilePath=WScript.ScriptFullName
	PathCurrent = objFSO.GetParentFolderName(CurrentFilePath)
	PathParent = objFSO.GetParentFolderName(PathCurrent) '& slash
	PathWoorjAdmin=PathParent & slash & "WoorjAdminForAreas\publish"  
	PathParent2 = objFSO.GetParentFolderName(objFSO.GetParentFolderName(PathCurrent)) & slash
	exeScrips = PathParent2  & "ExeScrips" 

	PrjFolderName = objFSO.GetFolder(PathParent).Name
    '----------------------------------
	cmdFolderNext=PathParent & cmdFolder & slash
	AppSettFilePath=PathParent & slash & AppSettFile
	fileNameCrDlCmd=PathCurrent & slash & cmdCreatorFile
	projectName=PrjFolderName                                               '"Woorj"              ' Add your Project Name
	prjMainFld=PathParent2                                                  '"E:\CURRPJ\"         ' Application Location
	'----------------------------------
	strComputerName =Trim(fGetConnStrData("comp",AppSettFilePath,ConnStr))  'oShell.ExpandEnvironmentStrings("%COMPUTERNAME%")     ' You can change the  Comuter Name to IP address of the server where your SqlServer installed. 
	servName=Trim(fGetConnStrData("srv",AppSettFilePath,ConnStr))           '"SQLEXPRESS"         ' Sql Server Name
	projectDbName=Trim(fGetConnStrData("db",AppSettFilePath,ConnStr))       '"woorjdb"            ' The Name of Db on Sql Server
	usr=Trim(fGetConnStrData("usr",AppSettFilePath,ConnStr))                '"woorju"             ' SqlServer User(login)
	pass=Trim(fGetConnStrData("pas",AppSettFilePath,ConnStr))               '"Woorj#2017"         ' SqlServer password for DataBase User(login)
    '-------------------------------------
	' Some facilities for Initialization
	Set objLog = objFSO.OpenTextFile(CurrentDirectory & slash & thisYear & logFileName, 8, True) 
	'objLog.WriteLine("------------------------------------------------------------------")
	'------------------------------------
	serv=strComputerName & slash & servName
	dbFileNameForBackUp=projectDbName & addAfterName
	'backUpAdr=prjMainFld & archiveFld & slash & projectName & dbArchFld & slash
	backUpAdr=prjMainFld & archiveFld & slash & projectName & dbArchFld & slash & thisYear & slash & thisMonth & slash & thisDay & slash 
	appFileArchFolder=prjMainFld & archiveFld & slash & projectName & filesArchFld & slash & thisYear & slash & thisMonth & slash & thisDay & slash & projectName & addAfterName &"-" & CopyDESCR &  "\" & projectName
	appFolder=prjMainFld & projectName
	appExeScripsFileArchFolder=prjMainFld & archiveFld & slash & projectName & filesArchFld & slash & projectName & addAfterName & "\" & "ExeScrips"
'===============================================================================
	LocArr(0)=Array("","Get BeckUp of DB","")
    LocArr(1)=Array("","DeleteDB","")
	LocArr(2)=Array("","CreateNewDB","")
	LocArr(3)=Array("","DeleteDB-CreateNewDB","")
	LocArr(4)=Array("","RestoreBackupOfDB","")
	LocArr(5)=Array("","Delete - CreateNewDB - RestoreBackupOfDB","")
	LocArr(6)=Array("","CreateNewDB - RestoreBackupOfDB","")
	LocArr(7)=Array("","BeckUps Application Files","")
	LocArr(8)=Array("","Get BeckUp of DB and Application Files","")
	LocArr(9)=Array("","---------------------------","")
	LocArr(10)=Array("","Remove Migration","dotnet ef migrations remove")
	LocArr(11)=Array("","Add Migration","dotnet ef migrations add")
	'---------------------------------------------
	LocArr(12)=Array("","Drop DataBase from EF","dotnet ef database drop")
	LocArr(13)=Array("","Update DataBase","dotnet ef database update")
	LocArr(14)=Array("","Build Application","dotnet build")
	LocArr(15)=Array("","Run Application","dotnet run")
	LocArr(16)=Array("","Build and Run Application","dotnet build & dotnet run")
	'Publish Application","appcmd stop sites woorj & dotnet publish & appcmd start sites woorj 
	LocArr(17)=Array("","Publish Application","IISRESET /stop & IISRESET /start & dotnet build & dotnet publish")
	LocArr(18)=Array("","Dotnet Restore","dotnet restore")
	LocArr(19)=Array("","dotnet watch run","dotnet watch run")
	'---------------------------------------------	
	LocArr(20)=Array("","Code-Generatore Method 2(seperate folder)","Here Dinamic CMD")
	LocArr(21)=Array("","dbo CMDs in Terminal","Here Dinamic CMD")
	LocArr(22)=Array("","Open the project folder","Here seperate CMD")
	LocArr(23)=Array("","Delete-Create All ","Here seperate CMD")
	LocArr(24)=Array("","Open Site ","Here seperate CMD")
	LocArr(25)=Array("","Close All Command Lines (Kill) ","Here seperate CMD")
	LocArr(26)=Array("","Delete-Create All Build Run Open Site","Here seperate CMD")
	LocArr(27)=Array("","DB Password (Copy To Clipboard)",pass)
	LocArr(28)=Array("","User Password (Copy To Clipboard)",passApp)
	LocArr(29)=Array("","KILL NET CORE AND HOST","-----------------")
	LocArr(30)=Array("","Run WoorjAdminForAreas","")
	LocArr(31)=Array("","Add or Delete Command in CMD for that sctipt","")
	LocArr(32)=Array("","Update DataBase for Some Mgration File","dotnet ef database update")
	maxLocArr=32
'===============================================================================
 txt_chooes_opt=""
 txt_chooes_opt_file=""
   For j= 0 to UBound(LocArr)
    if j<=maxLocArr then
   	txt_chooes_opt=txt_chooes_opt & j & " - " & LocArr(j)(1) & Chr(13)
    end if
   next

   txt_chooes_opt=txt_chooes_opt & Chr(13) & Chr(13) & " choose the operations"
   chooes_opt= InputBox(txt_chooes_opt,"Operations",defauldInputVal)  
'===============================================================================
		' Action Section
		if  chooes_opt="0" then                            'Get BeckUp of DB
			call CreateFolder_Date_month_Day_Time(backUpAdr)
			call GetBackUp(usr,pass,serv,projectDbName,backUpAdr,dbFileNameForBackUp,dbEx)
		elseif  chooes_opt="1" then                          'DeleteDB
			call DeleteDB(usr,pass,serv,projectDbName)
		elseif  chooes_opt="2" then                          'CreateNewDB
			call CreateDB(usr,pass,serv,projectDbName)
		elseif  chooes_opt="3" then                        'DeleteDB-CreateNewDB
			call DeleteDB(usr,pass,serv,projectDbName)
			call CreateDB(usr,pass,serv,projectDbName)
		elseif chooes_opt="4" then                         'RestoreBackupOfDB
			WriteAllFileNamesToArray(objFSO.GetFolder(backUpAdr))
			dbFileNameForRestore=trim(objFSO.GetBaseName(chooseDBFile())) 
			call RestoreBackup(usr,pass,serv,projectDbName,backUpAdr,dbFileNameForRestore,dbEx)
		elseif chooes_opt="5" then                         'Delete - CreateNewDB - RestoreBackupOfDB
			call DeleteDB(usr,pass,serv,projectDbName)
			call CreateDB(usr,pass,serv,projectDbName)
			WriteAllFileNamesToArray(objFSO.GetFolder(backUpAdr))
			dbFileNameForRestore=trim(objFSO.GetBaseName(chooseDBFile())) 
			call RestoreBackup(usr,pass,serv,projectDbName,backUpAdr,dbFileNameForRestore,dbEx)
		elseif chooes_opt="6" then                         'CreateNewDB - RestoreBackupOfDB
			call CreateDB(usr,pass,serv,projectDbName)
			WriteAllFileNamesToArray(objFSO.GetFolder(backUpAdr))
			dbFileNameForRestore=trim(objFSO.GetBaseName(chooseDBFile())) 
			call RestoreBackup(usr,pass,serv,projectDbName,backUpAdr,dbFileNameForRestore,dbEx)	
		elseif chooes_opt="7" then                         'BeckUps Application Files
			     CopyDESCR= InputBox("Please Enter the description for that copy","BeckUps")
				if len(CopyDESCR)>0 then
				minusAdd="-"
				else
				minusAdd=""
				end if		
  	           appFileArchFolder=Trim(prjMainFld & archiveFld & slash & projectName & filesArchFld & slash & thisYear & slash & thisMonth & slash & thisDay & slash & projectName & addAfterName & minusAdd & CopyDESCR &  "\" & projectName)				 
	  		 if IsEmpty(CopyDESCR) then 
			  'Cancled
			 else
				 call CreateFolder_Date_month_Day_Time(appFileArchFolder)
				 objFSO.CopyFolder appFolder, appFileArchFolder
				'objFSO.CopyFolder exeScrips, appExeScripsFileArchFolder
				'objLog.WriteLine( now  & " The Application Folder " & appFolder & " copied to " & appFileArchFolder & " as application filesBackUp" )
		     end if
		elseif chooes_opt="8" then                         'Get BeckUp of DB and Application Files
			     CopyDESCR= InputBox("Please Enter the description for that copy","BeckUps")
					if len(CopyDESCR)>0 then
					minusAdd="-"
					else
					minusAdd=""
					end if					 

				 appFileArchFolder=prjMainFld & archiveFld & slash & projectName & filesArchFld & slash & thisYear & slash & thisMonth & slash & thisDay & slash & projectName & addAfterName & minusAdd & CopyDESCR &  "\" & projectName
	         if IsEmpty(CopyDESCR) then 
			  'Cancled
			 else
			call CreateFolder_Date_month_Day_Time(backUpAdr)
			call GetBackUp(usr,pass,serv,projectDbName,backUpAdr,dbFileNameForBackUp,dbEx)
			'----------------------
			call CreateFolder_Date_month_Day_Time(appFileArchFolder)
			objFSO.CopyFolder appFolder, appFileArchFolder		
			objFSO.CopyFolder exeScrips, appExeScripsFileArchFolder
			'objLog.WriteLine( now  & " The Application Folder " & appFolder & " copied to " & appFileArchFolder & " as application filesBackUp" )  
             end if		
		elseif chooes_opt="10" then                       'Remove Migration","dotnet ef migrations remove
				thisCMD=LocArr(10)(2)
				ActionsFromEF(thisCMD)
		 elseif chooes_opt="11" then                       'Add Migration","dotnet ef migrations add
				InitName= InputBox("Enter the Migration name or Number ", "CMDs of  this project")
				thisCMD=LocArr(11)(2) & " Init_" & InitName
				ActionsFromEF(thisCMD)
		 elseif CInt(chooes_opt)>=12 and CInt(chooes_opt)<=19  then    
				 '---------  'Kill First----------------
			  IF CInt(chooes_opt)=19 THEN
				' Kill All CMD.Exe Commands
				'killCMD="taskkill /IM cmd.exe"  
				'oShell.run(killCMD)
			  ELSEIF CInt(chooes_opt)=16 THEN
				killCMD="taskkill /IM cmd.exe"  
				oShell.run(killCMD)
				'oShell.run(iURL_Site)	
              ELSEIF CInt(chooes_opt)=17 THEN
				RunAsAdmin()				
				killCMD="taskkill /IM cmd.exe"  
				oShell.run(killCMD)
				'oShell.run(iURL_Site)
			  ELSEIF CInt(chooes_opt)=14  or CInt(chooes_opt)=15   THEN
				' Kill All CMD.Exe Commands
				killCMD="taskkill /IM cmd.exe"  
				oShell.run(killCMD)
				
			  END IF
			  Wscript.Sleep(sleep1)
				thisCMD=LocArr(chooes_opt)(2)	       
				ActionsFromEF(thisCMD)
			'LocArr(12)=Array("","Drop DataBase from EF","dotnet ef database drop")
			'LocArr(13)=Array("","Update DataBase","dotnet ef database update")
			'LocArr(14)=Array("","Build Application","dotnet build")
			'LocArr(15)=Array("","Run Application","dotnet run")
			'LocArr(16)=Array("","Build and Run Application","dotnet build & dotnet run")
			'LocArr(17)=Array("","Publish Application","dotnet publish")
			'LocArr(18)=Array("","Dotnet Restore","dotnet restore")
			call CopyAndSaveInBuffer("exit") 	


		elseif CInt(chooes_opt)=20   then                 'Code-Generatore Method 2(seperate folder)
				scaffName= InputBox("Enter the Scaffolding name ", "CMDs of  this project")
				
				dbAppConextName= InputBox("Add DbApplicationConext or leave that empty for getting default: ApplicationDbContext", _
				"CMDs of  this project")
				if dbAppConextName="" then 
				dbAppConext="ApplicationDbContext" 
				elseif dbAppConextName<>"" then 
				dbAppConext=dbAppConextName 
				end if
				
				DirName= InputBox("If you want to create or use Folder for that scafolding," & chr(13) & _
				"please enter the Directory Name," & chr(13) &" if No leve the textBox empty", "CMDs of  this project")
				if DirName="" then 
				slashThis="" 
				elseif DirName<>"" then 
				slashThis="\" 
				end if '& DirName & slash 
				fullCMD="dotnet aspnet-codegenerator controller -name " & scaffName & "Controller -actions -m " & scaffName & " -dc " & dbAppConext & " -outDir Controllers" & slashThis & DirName & "  -udl -f "		
				ActionsFromEF(fullCMD)
		elseif CInt(chooes_opt)=21 then	        'dbo CMDs in Terminal
				   k=0
				   Set objFolder = objFSO.GetFolder(cmdFolderNext)
				   GetCMDFiles	
				  ' MsgBox 

				 For s= 1 to UBound(GrCodeGenFile) 
                  cmdFileName= objFSO.GetFileName(GrCodeGenFile(s))
				  TwoFirstCmdFileName=Mid(cmdFileName,1,2)
				  
				  if GrCodeGenFile(s)<>"" and (TwoFirstCmdFileName="sc" or TwoFirstCmdFileName="cm" )then 
                  		  InputBoxMsg=InputBoxMsg &  s & "-" & cmdFileName & chr(13)
				  end if
				 next
				 groupName= InputBox(InputBoxMsg & chr(13) &  chr(13) & "Enter the group code ", "CMDs of  this project")
				  cmdMerge="" 
				 if groupName<>"" then
					 if  GrCodeGenFile(groupName)<>"" then
					 Set FileContent= objFSO.OpenTextFile(GrCodeGenFile(groupName))
						 killCMD="taskkill /IM cmd.exe"  
						 oShell.run(killCMD)
						 WScript.Sleep(sleep1)				 
						do until FileContent.AtEndOfStream
						cmdMerge=cmdMerge &  Trim(FileContent.ReadLine) & " & "
						loop
						cmdMergeFull= "dotnet build & " & cmdMerge
						ActionsFromEF(cmdMergeFull)
					    'MsgBox cmdMergeFull
					 FileContent.Close
					 end if
				 end if
		elseif CInt(chooes_opt)=22 then      'Open the project folder
				oShell.Run prjMainFld
		elseif CInt(chooes_opt)=23 then      'Delete-Create All
		                 killCMD="taskkill /IM cmd.exe"  
						 oShell.run(killCMD)
						 WScript.Sleep(sleep1)
						migrPath=appFolder & migrFolder
						If objFSO.FolderExists(migrPath) = True Then 
						 objFSO.DeleteFolder(migrPath)
						end if 
						call DeleteDB(usr,pass,serv,projectDbName)

						InitName= InputBox("Enter the Migration name or Number ", "CMDs of  this project")
						thisCMD=LocArr(11)(2) & " Init_" & InitName & " & " & LocArr(13)(2) 

						ActionsFromEF(thisCMD)

		elseif CInt(chooes_opt)=24 then     'Open Side 
						oShell.run(iURL_Site)
		elseif CInt(chooes_opt)=25 then     'Delete-Create All Build Run Open S
				' Kill All CMD.Exe Commands
				 killCMD="taskkill /IM cmd.exe"  
				 oShell.run(killCMD)
		elseif CInt(chooes_opt)=26 then    ' Close All CMDs (Kill)
			 '---------  'Kill First----------------
			' Kill All CMD.Exe Commands
			 killCMD="taskkill /IM cmd.exe"  
			 oShell.run(killCMD)
			 '---------------------------------
					migrPath=appFolder & "\Migrations"
					If objFSO.FolderExists(migrPath) = True Then 
					 objFSO.DeleteFolder(migrPath)
					end if 
					call DeleteDB(usr,pass,serv,projectDbName)
					   
					InitName= InputBox("Enter the Migration name or Number ", "CMDs of  this project")
					thisCMD=LocArr(11)(2) & " Init_" & InitName & " & " & _
					LocArr(13)(2) & " & dotnet build & dotnet run" 
					ActionsFromEF(thisCMD)
					WScript.Sleep(sleep1)
					oShell.run(iURL_Site)

		elseif CInt(chooes_opt)>=27 and  CInt(chooes_opt)<=28 then    'Copy to Clipboard 
				strForClipboard=LocArr(chooes_opt)(2)
				call CopyAndSaveInBuffer(strForClipboard) 
		elseif CInt(chooes_opt)=29 then    'Add the Hod Key For this Scrip
				call  KillTask("conhost.exe")
				call  KillTask("cmd.exe")
				call  KillTask("OmniSharp.exe")
				call  KillTask("dotnet.exe")
		elseif CInt(chooes_opt)=30 then    
				
					fullCMD="dotnet WoorjAdmin.dll "
				    'ActionsFromEF(fullCMD)
					call ActionsFromEFWithPath(PathWoorjAdmin,fullCMD)
				
    	elseif CInt(chooes_opt)=31 then   
			oShell.Run fileNameCrDlCmd 		
    	elseif CInt(chooes_opt)=32 then   
			InitName= InputBox("Enter the Migration File name ", "CMDs of  this project")
				thisCMD=LocArr(32)(2) & " " & InitName
				ActionsFromEF(thisCMD)
		else 
			'nothing 
		end if 

'===============================================================================
'===============================================================================
 Sub RunAsAdmin()
 ' Run this script  As Administrator
				if WScript.Arguments.length=0 then
				Set ObjShellADmin=CreateObject("Shell.Application")
				ObjShellADmin.ShellExecute "wscript.exe" _
				,"""" & WScript.ScriptFullName & """ RunAsAdministrator", ,"runas",1
				WScript.Quit
				end if
 End Sub
 
'Functionality Section 
 Sub GetBackUp(p_usr,p_pass,p_srv,p_projectDbName,p_backUpAdr,p_dbFileName,p_dbEx)
	connStr="sqlcmd -U " & p_usr & " -P " & p_pass & " -S " & p_srv & " -d " & p_projectDbName & " -Q "
    backUpCmd= """BACKUP DATABASE " & p_projectDbName & " TO DISK='" & p_backUpAdr & p_dbFileName & p_dbEx & "'"""
    backUpCmdSt=  connStr & backUpCmd 
	oShell.run backUpCmdSt ,1 , true
	
	objLog.WriteLine( now  & " The User " & p_usr & " got the backUp  of " & p_projectDbName & " from " &  p_srv &"\" & p_projectDbName & " to " & p_backUpAdr & p_dbFileName & p_dbEx )
 End Sub 
 

 
 Sub DeleteDB(p_usr,p_pass,p_srv,p_projectDbName)
	connStr="sqlcmd -U " & p_usr & " -P " & p_pass & " -S " & p_srv & " -d " & p_projectDbName & " -Q "
    deleteCmd= """ USE master; ALTER DATABASE " & p_projectDbName & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;  DROP DATABASE " & p_projectDbName & "; """
		deleteCmdSt=  connStr & deleteCmd 
		'MsgBox deleteCmdSt
		oShell.run deleteCmdSt ,1 , true
		
			objLog.WriteLine( now  & " The User " & p_usr & " deleted the Db " & p_srv & "\" & p_projectDbName)
 End Sub 
 
 Sub CreateDB(p_usr,p_pass,p_srv,p_projectDbName)
    connect2="sqlcmd -U " & p_usr & " -P " & p_pass & " -S " & p_srv & " -Q "
	createCmd= """CREATE DATABASE " & p_projectDbName & ";"""
	createCmdSt=connect2 & createCmd
	oShell.run createCmdSt ,1 , true
	
		objLog.WriteLine( now  & " The User " & p_usr & " created empty DataBase " & p_srv & "\" & p_projectDbName )
 End Sub 
 
 Sub RestoreBackup(p_usr,p_pass,p_srv,p_projectDbName,p_backUpAdr,p_dbFileName,p_dbEx)
	connStr="sqlcmd -U " & p_usr & " -P " & p_pass & " -S " & p_srv & " -d " & p_projectDbName & " -Q "
	restoreDbCmd="""USE master; ALTER DATABASE " & p_projectDbName & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE " & p_projectDbName & " FROM DISK='" & p_backUpAdr & p_dbFileName & p_dbEx & "' WITH REPLACE, STATS=5"""	
	restoreDbCmdSt=connStr & restoreDbCmd
	oShell.run restoreDbCmdSt ,1 , true
	
    objLog.WriteLine( now  & " The User " & p_usr & " Restored the  " & p_projectDbName & " from " & p_backUpAdr & p_dbFileName & p_dbEx & " to " & p_srv &"\" & p_projectDbName )
 End Sub 
'----------------------------------------------------------------------------- 
 Function LPad(s, l, c) ' добавить 0 в дату 
  Dim n : n = 0
  If l > Len(s) Then n = l - Len(s)
  LPad = String(n, c) & s
 End Function
 '---------------------------------------------------------------------------
 ' WriteAllFileNamesToArray
 Sub WriteAllFileNamesToArray(p_objFolder)
    Dim objFile, objSubFolder

    For Each objFile In p_objFolder.Files
    i=i+1
    If LCase(objFSO.GetExtensionName(objFile.Name)) = "bak" Then
           ' objTS.WriteLine(i & " )" & objfile.Path)
		   FileNames(i)=objfile.Name 'objfile.Path 
        End If
    Next
    ' Поиск файов в подпапки
    'For Each objSubFolder In p_objFolder.SubFolders
    '    WriteAllFileNamesToArray objSubFolder
    'Next
End Sub
Function chooseDBFile()
   For k= 0 to UBound(FileNames)
   if FileNames(k)<>"" then
   	txt_chooes_opt_file=txt_chooes_opt_file & k & " - " & left(FileNames(k),5) & Right(FileNames(k),19) & Chr(13)
	end if
   next
    txt_chooes_opt_file=txt_chooes_opt_file & Chr(13) & Chr(13) & "choose the backUp for Restoring"
	chooes_opt_file= InputBox(txt_chooes_opt_file,"BeckUps","")
    chooseDBFile= FileNames(chooes_opt_file)
End Function
'----------------------------------------------------------------------------
Function CreateFolder_Date_month_Day_Time(fullPathOfDirs)

  Dim arr, dir, path
			  arr = split(fullPathOfDirs, "\")
			  path = ""
			  For Each dir In arr
				If path <> "" Then path = path & slash
			
				path = path & dir 
				If objFSO.FolderExists(path) = False Then objFSO.CreateFolder(path)
			  Next
End Function
'-----------------------------------------------------------------------------

Sub ActionsFromEF(p_thisCMD)
	oShell.CurrentDirectory = appFolder
	prjPath = objFSO.GetAbsolutePathName(appFolder)

	thisCMD= "cmd /K CD " & prjPath & " & " & p_thisCMD ' Просто не забудьте поставить & между ними и все будет работать как надо
	if thisCMD<>"" then
	'oShell.run thisCMD,1,True
	oShell.run thisCMD
	end if
End Sub

Sub ActionsFromEFWithPath(p_AppFolder,p_thisCMD)
	oShell.CurrentDirectory = p_AppFolder
	prjPath = objFSO.GetAbsolutePathName(p_AppFolder)

	thisCMD= "cmd /K CD " & prjPath & " & " & p_thisCMD ' Просто не забудьте поставить & между ними и все будет работать как надо
	if thisCMD<>"" then
	'oShell.run thisCMD,1,True
	oShell.run thisCMD
	end if
End Sub
'----------------------------------------------------------------------------
Sub KillTask(p_strProcessToKill)
	On Error Resume Next
	strComputer = "."
	'msgbox(strComputer)
	strProcessToKill =p_strProcessToKill '"conhost.exe" 
	SET objWMIService = GETOBJECT("winmgmts:" _
		& "{impersonationLevel=impersonate}!\\" _ 
		& strComputer & "\root\cimv2") 
	SET colProcess = objWMIService.ExecQuery _
		("Select * from Win32_Process Where Name = '" & strProcessToKill & "'")
	count = 0
	FOR EACH objProcess in colProcess
		objProcess.Terminate()
		count = count + 1
	NEXT 
end sub 
'-----------------------------------------------------------------------------
Sub CopyAndSaveInBuffer(TxtForBuffer)
	strTextToCB = TxtForBuffer '& vbCrLf & "с переводом строк."
	'strTextToCB = Replace(strTextToCB, vbCrLf, "\n")
	CreateObject("WScript.Shell").Run "mshta.exe ""javascript:clipboardData.setData('text','" & StrTextToCB & "');close();""", 2
End Sub
'-----------------------------------------------------------------------------
function fGetConnStrData(pVal,pAppSettFilePath,pConnStr)
 Dim Res 
Res=""

 Set objSettFile= objFSO.OpenTextFile(pAppSettFilePath, 1)
					Do While Not objSettFile.AtEndOfStream
						strLine = objSettFile.readline
						if InStr(strLine,"DefaultConnection")>0 then 
								conStrSplit=Split(strLine,"""")
								conStr=Replace(Replace(conStrSplit(3),"=",";"),"\\",";")
								paramSplit=Split(conStr,";")										
									
									if pVal="comp"  then  
										Res=paramSplit(1)
									elseif pVal="srv"  then  
										Res=paramSplit(2)
									elseif pVal="db" then
										Res=paramSplit(4)
									elseif pVal="usr" then
										Res=paramSplit(6)
									elseif pVal="pas"  then  
										Res=paramSplit(8)
									end if						
					    end if
					Loop
 objSettFile.Close

 fGetConnStrData=Res 
End Function

'-----------------------------------------------------------------------------
Sub GetCMDFiles()
	Set colFiles = objFolder.Files
	For Each objFile in colFiles
	'Wscript.Echo objFile.path
	k=k+1
	GrCodeGenFile(k)=objFile.path
	Next
    	ShowSubfolders objFSO.GetFolder(cmdFolderNext)
end sub
'------------------------
Sub ShowSubFolders(Folder)
    For Each Subfolder in Folder.SubFolders
        'Wscript.Echo Subfolder.Path
        Set objFolder = objFSO.GetFolder(Subfolder.Path)
        Set colFiles = objFolder.Files
        For Each objFile in colFiles
            'Wscript.Echo objFile.path
			k=k+1
	        GrCodeGenFile(k)=objFile.path
        Next
        'Wscript.Echo
        ShowSubFolders Subfolder
    Next
End Sub
'-----------------------------------------------------------------------------
 ' Closing Connections
 objLog.Close
 Set objFSO = Nothing
 Set oShell = Nothing
'End Functionality Section 
'===============================================================================
'===============================================================================



'===============================================================================
'===============================================================================
                 ' Additional Necessary Notes
'-------------------------------------------------------------------------------

'other  Notes
 	'connStr="sqlcmd -U unakhchir -P Fmfb#2017 -S HO-KHAYOL-PC\SQLEXPRESS -d dbnakhchir1 -Q "
'-----------------------------------------------------------------------------
' GETING THE ACTIVE PROGRAM TaskManager FROM CMD 
'In cmd, run the following:
    'wmic process get processid,commandline

'To filter for a particular program:
   'wmic process where "name like '%chrome%'" get processid,commandline
'===============================================================================
 