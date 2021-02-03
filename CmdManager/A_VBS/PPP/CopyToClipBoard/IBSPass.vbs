resSTR ="PiTbull4#K$"
call CopyAndSaveInBuffer(resSTR)

Sub CopyAndSaveInBuffer(TxtForBuffer)
	strTextToCB = TxtForBuffer '& vbCrLf & "с переводом строк."
	'strTextToCB = Replace(strTextToCB, vbCrLf, "\n")
	CreateObject("WScript.Shell").Run "mshta.exe ""javascript:clipboardData.setData('text','" & StrTextToCB & "');close();""", 2
End Sub