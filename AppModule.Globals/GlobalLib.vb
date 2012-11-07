'
' Created by SharpDevelop.
' User: urx
' Date: 06.11.2012
' Time: 08:49
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Module GlobalLib
	Public const ProgramVersion As String = "0.1.0"
	Public const ProgramName As String = "Net Profiles mod"
	
	Public CommonApplicationDataFolder As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData) + "\" + ProgramName
	Public ProfilesFolder As String = CommonApplicationDataFolder + "\profiles"
End Module
