'ftp://admin:admin@192.168.43.1:2121
set objShell = CreateObject("WScript.Shell")
Login = "admin"
'If your username contains the @ symbol, and your web browser does not support this, you can substitute for the +
Login = Replace(Login,"@","+")
Password = "admin"
FTPSERVER = "192.168.43.1:2121"
'RemoteFolder = "RemoteFolderName"
FTPURL = "ftp://"& Login &":"& Password &"@"& FTPSERVER '&"/"& RemoteFolder
Connect2FTP = objShell.run("Explorer "& FTPURL ,1,False)

