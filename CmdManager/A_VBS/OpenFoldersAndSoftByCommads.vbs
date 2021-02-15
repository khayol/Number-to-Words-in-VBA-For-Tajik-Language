'-----------------------------------------------
'Script Created By Khayol
On Error Resume Next 
'-----------------------------------------------
Dim shell: Dim i: Dim j: Dim WshShell
Set shell = wscript.CreateObject("Shell.Application")
Set WshShell = CreateObject("WScript.Shell")
Dim chooseArr (100)

Dim ExcelFormula1  '="N'"&B5&"',"     
Dim ExcelFormula2  '=IF(B5="";"null,"; "N'"&B5&"',")
ExcelFormula1="=" & chr(34) & "N\'"&chr(34)& "&B5&"& chr(34)& "\'"&"," & chr(34)
ExcelFormula2="=IF( B5="& chr(34)& chr(34) & ";"& chr(34)& "null," & chr(34) & ";" & chr(34) & "N\'"&chr(34)& "&B5&"& chr(34)& "\'"&"," & chr(34) & ")"
'-----------------------------------------------
chooseArr(0)=Array("C","C:\","not_cmd") 
chooseArr(1)=Array("D","D:\","not_cmd")  
chooseArr(2)=Array("E","E:\","not_cmd") 
chooseArr(3)=Array("-------Q-DIR-----------","-----------------------","not_cmd") 
chooseArr(4)=Array("Net Core & Blazor Lessons","E:\A_SettingSoftware\Q_Dir_Sates\DotNetLessons.qdr","not_cmd") 
chooseArr(5)=Array("CFT_Folders","E:\A_SettingSoftware\Q_Dir_Sates\CFT_Folders.qdr","not_cmd") 
chooseArr(6)=Array("Own","E:\A_SettingSoftware\Q_Dir_Sates\Own.qdr","not_cmd") 
chooseArr(7)=Array("Projects","E:\A_SettingSoftware\Q_Dir_Sates\Projects.qdr","not_cmd")
chooseArr(8)=Array("NewProjects","E:\A_SettingSoftware\Q_Dir_Sates\NewProjects.qdr","not_cmd") 
chooseArr(9)=Array("--------SQL DEV APPS -------","------------------","not_cmd")  
chooseArr(10)=Array("MS SMS","C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Ssms.exe","not_cmd") 
chooseArr(11)=Array("Oracle PL\SQL Dev","C:\Program Files (x86)\PLSQL Developer 12\plsqldev.exe","not_cmd") 
chooseArr(12)=Array("DB2 IBM ","C:\Program Files (x86)\Quest Software\Toad for DB2 Freeware 5.6\toad.exe","not_cmd") 
chooseArr(13)=Array("-------Diff 1---------","-----------------------","not_cmd") 
chooseArr(14)=Array("Empty ??? ","E:\D_KhProgrammFiles2\A_VBS\OpenPhoneFTP.vbs","not_cmd") 
chooseArr(15)=Array("Toggle_Wi-Fi","E:\D_KhProgrammFiles2\A_VBS\WiFi_Connection_Managment\Toggle_Wi-Fi.vbs","not_cmd") 
chooseArr(16)=Array("FTP Phone","E:\D_KhProgrammFiles2\A_VBS\OpenPhoneFTP.vbs","not_cmd") 
chooseArr(17)=Array("-------Diff 2 --------","-----------------------","not_cmd") 
chooseArr(18)=Array("A_VBS","E:\D_KhProgrammFiles2\A_VBS","not_cmd") 
chooseArr(19)=Array("Flow!Works Pro V2.0","C:\Program Files (x86)\Flow!Works Pro\Flow!Works Pro V2.0.exe","not_cmd") 
chooseArr(20)=Array("Public 192.168.0.15","\\192.168.0.15\SharePoint\IT_Department\Khayol","not_cmd") 
chooseArr(21)=Array("MyBook","E:\B_Own\OWN\MyBook\MyBook.xlsm","not_cmd") 
chooseArr(22)=Array("Woorj HR","E:\A_Projects_A\CSharp\ASPNETCoreProjects\BlazorServerApps\WoorjHR","not_cmd") 
chooseArr(23)=Array("931231285","931231285","copy_to_buff") 
chooseArr(24)=Array("11613061","11613061","copy_to_buff") 
chooseArr(25)=Array("------Win Cmd---------","","not_cmd") 
chooseArr(26)=Array("Programs and Features","appwiz.cpl","cmd") 
chooseArr(27)=Array("NOTES","E:\D_KhProgrammFiles2\A_VBS\DiffFile\NOTES.txt","not_cmd") 
chooseArr(28)=Array("comp","zxas123#A","copy_to_buff") 
chooseArr(29)=Array("vpn","xcsd123#A","copy_to_buff") 
chooseArr(30)=Array("ScreenRec","E:\A_DiffFiles\ScreenRec","not_cmd") 
chooseArr(31)=Array("Fmfb#2017","Fmfb#2017","copy_to_buff") 
chooseArr(32)=Array("Track#2017","Track#2017","copy_to_buff") 
chooseArr(33)=Array("Public","\\192.168.0.15\SharePoint\Public","not_cmd") 
chooseArr(34)=Array(ExcelFormula1,ExcelFormula1,"copy_to_buff") 
chooseArr(35)=Array(ExcelFormula2,ExcelFormula2,"copy_to_buff") 
chooseArr(36)=Array("hosts","C:\Windows\System32\drivers\etc\hosts","not_cmd") 
 
'


'-------------------------------------------
pass_for_Exl="$#21" 
'-------------------------------------------
'Choosing the  Options  from InputBox
OptionsStr=""
defaultInputBoxVal="32"  '8  29 35

For j= 0 to UBound(chooseArr) 
    OptionsStr=OptionsStr & j & " - " & chooseArr(j)(0) & chr(13)
next
inputOptions =InputBox( OptionsStr & chr(13) & chr(13) & "Chose one of them", _
"Open Folder or Apps",defaultInputBoxVal)
'-----------------------------------------------
if IsEmpty(inputOptions) then 
' DoNothing  
else
    resSTR =chooseArr(inputOptions)(1)
    flgCOmOrNot =chooseArr(inputOptions)(2)
	
	if  inputOptions=21 then
	  CopyAndSaveInBuffer(pass_for_Exl): WScript.Sleep(1000)
	  openExcel(resSTR)
	elseif  flgCOmOrNot="copy_to_buff"   then
	  CopyAndSaveInBuffer(chooseArr(inputOptions)(1))
	else
    	 call OpenThisFolderOrRunFile(resSTR,flgCOmOrNot)
	 'Nothing 
	end if
end if
'-----------------------------------------------

Sub OpenThisFolderOrRunFile(pPath,pflgCOmOrNot)

   if pflgCOmOrNot="cmd" then
	WshShell.Run "cmd.exe /C" &  Chr(34) & pPath & Chr(34) ,1
    else
	WshShell.Run   Chr(34) & pPath & Chr(34) ,1
   end if
   
End Sub

Sub CopyAndSaveInBuffer(TxtForBuffer)
strTextToCB = TxtForBuffer '& vbCrLf & "с переводом строк."
'strTextToCB = Replace(strTextToCB, vbCrLf, "\n")
WshShell.Run "mshta.exe ""javascript:clipboardData.setData('text','" & StrTextToCB & "');close();""", 2
End Sub	

sub openExcel(p_FilePath) 
   Set objXLApp = CreateObject("Excel.Application")
    objXLApp.Visible = False
    objXLApp.DisplayAlerts = False
    Set objXLWb = objXLApp.Workbooks.Open(p_FilePath)
	Set objXLWb= Nothing
End sub 	
'-----------------------------------------------
WshShell=nothing
shell=nothing

