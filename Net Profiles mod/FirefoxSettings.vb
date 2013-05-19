'
' Copyright 2004-2012 Hugo Anton Feldhammer, Urs Geissbühler, Daniel Milner
'
'
' This file is part of Net Profiles mod.
'
' Net Profiles mod is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' Net Profiles mod is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with Net Profiles mod.  If not, see <http://www.gnu.org/licenses/>.
'
'

' Created by SharpDevelop.
' User: Urs Geissbühler
' Date: 09.12.2012
' Time: 21:40
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.IO
Imports AppModule.Globals

Public Class FirefoxSettings
	Private const PrefsFile As String = "prefs.js"
	Private const SessionstoreFile As String = "sessionstore.js"
	Private PrefsPath As String
	Private PrefsList As List(Of String)
	
	Public Sub New()
		Dim IniPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\profiles.ini"
		Dim StartWithLastProfile As String = INIRead(iniPath, "General", "StartWithLastProfile", "0")
		Dim i As Integer = 0
		Dim IsDefault As String = ""
		Dim IsRelative As String = ""
		Dim ProfilePath As String = ""
		Dim CurrentPath As String = ""
		Me.PrefsPath = ""
		Me.PrefsList = New List(Of String)
		
		' Iterate over profile sections in profiles.ini starting with [Profile0]
		Do
			' CurrentPath will be empty if reading a non-existent profile section
			CurrentPath = INIRead(IniPath, "Profile" & i, "Path").Replace("/", "\")
			If CurrentPath <> "" Then
				ProfilePath = CurrentPath
				IsDefault = INIRead(IniPath, "Profile" & i, "Default")
				IsRelative = INIRead(IniPath, "Profile" & i, "IsRelative", "1")
				i = i + 1
			End If
		Loop While (IsDefault <> "1" And CurrentPath <> "")
		If (ProfilePath <> "" And (IsDefault = "1" Or i = 1)) Then
			Try
				Dim oRead As System.IO.StreamReader
				If IsRelative = "0" Then
					Me.PrefsPath = ProfilePath
					oRead = File.OpenText(Me.PrefsPath & "\" & FirefoxSettings.PrefsFile)
				Else
					Me.PrefsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\" & ProfilePath
					oRead = File.OpenText(Me.PrefsPath & "\" & FirefoxSettings.PrefsFile)
				End If
				Do While oRead.Peek() >= 0
					Me.PrefsList.Add(oRead.ReadLine)
				Loop
				oRead.Close()
			Catch
				' Failed attempt of reading prefs.js is ignored and PrefsList remains empty
			End Try
		End If
	End Sub
	
	Private Function ConvertPort(Port As String) As Object
		Try
			Return Convert.ToInt16(Port)
		Catch
			' Port setting will be deleted
			Return ""
		End Try
	End Function
	
	Public Sub ChangeSetting(Setting As String, Value As String)
		' Value: empty string will removes setting, "" saves empty setting
		If (Value = "") Or (Value = Chr(34) & Chr(34)) Then
			Me.SetPref(Setting, Value)
		Else
			Me.SetPref(Setting, Chr(34) & Value & Chr(34))
		End If
	End Sub
	
	Public Sub ChangeSetting(Setting As String, Value As Boolean)
		If Value Then
			Me.SetPref(Setting, "true")
		Else
			Me.SetPref(Setting, "false")
		End If
	End Sub
	
	Public Sub ChangeSetting(Setting As String, Value As Integer)
		Me.SetPref(Setting, Value.ToString())
	End Sub
	
	Private Sub SetPref(Setting As String, Value As String)
		Dim SettingChanged As Boolean = False
		Dim i As Integer = 0
		While i < Me.PrefsList.Count
			If Me.PrefsList(i).Contains("user_pref(" & Chr(34) & Setting & Chr(34) & ", ") Then
				If SettingChanged Or (Value = "") Then
					' Remove setting if duplicated or has to be deleted
					Me.PrefsList.RemoveAt(i)
				Else
					Me.PrefsList(i) = "user_pref(" & Chr(34) & Setting & Chr(34) & ", " & Value & ");"
					SettingChanged = True
				End If
			End If
			i = i + 1
		End While
		If Not SettingChanged And (Value <> "") Then
			me.PrefsList.Add("user_pref(" & Chr(34) & Setting & Chr(34) & ", " & Value & ");")
		End if
	End Sub
	
	Public Sub SetProxySettings(ByVal ProxyGlobal As String, ByVal ProxyGlobalPort As String, ByVal ProxyHttp As String, ByVal ProxyHttpPort As String, ByVal ProxyHttps As String, ByVal ProxyHttpsPort As String, ByVal ProxyFtp As String, ByVal ProxyFtpPort As String, ByVal ProxySocks As String, ByVal ProxySocksPort As String, ByVal ProxyGopher As String, ByVal ProxyGopherPort As String, ByVal ProxyExceptions As Array, ProxyBypass As Boolean)
		Dim ProxyEnable As Boolean
		Dim ShareProxySettings As Boolean
		Dim NoProxyOn As String = ""
		Dim ProxyLh As Boolean = True
		Dim Proxy127 As Boolean = True
		
		If ProxyExceptions.Length > 0 Then
			For Each Exception As String In ProxyExceptions
				If NoProxyOn = "" Then
					NoProxyOn = Exception
				Else
					NoProxyOn = NoProxyOn & ", " & Exception
				End If
				If Exception.ToLower() = "localhost" Then
					ProxyLh = False
				ElseIf Exception = "127.0.0.1" Then
					Proxy127 = False
				End If
			Next
			If ProxyBypass Then
				' Make sure localhost and 127.0.0.1 are included, but only once
				If ProxyLh Then
					NoProxyOn = NoProxyOn & ", localhost"
				End If
				If Proxy127 Then
					NoProxyOn = NoProxyOn & ", 127.0.0.1"
				End If
			End If
		Else
			If ProxyBypass Then
				' Firefox will use the default 'localhost, 127.0.0.1' when nothing is configured
				NoProxyOn = ""
			Else
				' Firefox will use no proxy exceptions when an empty string is configured
				NoProxyOn = Chr(34) & Chr(34)
			End If
		End If
		
		If ProxyGlobal <> "" Then
			ShareProxySettings = True
			ProxyHttp = ProxyGlobal
			ProxyHttpPort = ProxyGlobalPort
			ProxyHttps = ProxyGlobal
			ProxyHttpsPort = ProxyGlobalPort
			ProxyFtp = ProxyGlobal
			ProxyFtpPort = ProxyGlobalPort
			ProxySocks = ProxyGlobal
			ProxySocksPort = ProxyGlobalPort
			ProxyGopher = ProxyGlobal
			ProxyGopherPort = ProxyGlobalPort
		Else
			ShareProxySettings = False
		End If
		
		If (ProxyGlobal = "" And ProxyHttp = "" And ProxyHttps = "" And ProxyFtp = "" And ProxySocks = "" And ProxyGopher = "") Then
			ProxyEnable = False
		Else
			ProxyEnable = True
		End If
		
		If ProxyEnable Then
			Me.ChangeSetting("network.proxy.type", 1)
			Me.ChangeSetting("network.proxy.share_proxy_settings", ShareProxySettings)
		Else
			Me.ChangeSetting("network.proxy.type", 0)
			Me.ChangeSetting("network.proxy.share_proxy_settings", "")
		End If
		Me.ChangeSetting("network.proxy.http", ProxyHttp)
		Me.ChangeSetting("network.proxy.http_port", ConvertPort(ProxyHttpPort))
		Me.ChangeSetting("network.proxy.ssl", ProxyHttps)
		Me.ChangeSetting("network.proxy.ssl_port", ConvertPort(ProxyHttpsPort))
		Me.ChangeSetting("network.proxy.ftp", ProxyFtp)
		Me.ChangeSetting("network.proxy.ftp_port", ConvertPort(ProxyFtpPort))
		Me.ChangeSetting("network.proxy.socks", ProxySocks)
		Me.ChangeSetting("network.proxy.socks_port", ConvertPort(ProxySocksPort))
		Me.ChangeSetting("network.proxy.gopher", ProxyGopher)
		Me.ChangeSetting("network.proxy.gopher_port", ConvertPort(ProxyGopherPort))
		Me.ChangeSetting("network.proxy.no_proxies_on", NoProxyOn)
	End Sub

	Public Sub Apply(DontAskBeforeRestarting As Boolean)
		Dim oRead As System.IO.StreamReader
		Dim oWrite As System.IO.StreamWriter
		Dim FFProcess As System.Diagnostics.Process = Nothing
		Dim FFPath As String = ""
		' List all Firefox processes from all users
		Dim Processes As Process() = System.Diagnostics.Process.GetProcessesByName("firefox")
		For Each Process As System.Diagnostics.Process In Processes
			' Firefox prevents starting itself more than once with the same user account, also if the user is logged
			' in with multiple sessions. Only processes of the current user have to be killed, for simplicity the
			' rare case where Firefox runs in an other session of the current user is ignored.
			If Process.SessionID = System.Diagnostics.Process.GetCurrentProcess().SessionId Then
				Try
					FFProcess = Process
					FFPath = Process.MainModule.FileName
				Catch
					'Fails if Firefox runs as administrator
				End Try
			End If
		Next
		
		If FFPath <> "" Then
			Dim MsgBoxManager As MessageBoxManager
			MsgBoxManager = New MessageBoxManager
			MsgBoxManager.AutoClose = True
			MsgBoxManager.AutoCloseResult = System.Windows.Forms.DialogResult.Yes
			MsgBoxManager.CenterWindow = True
			MsgBoxManager.DisableButtons = False
			MsgBoxManager.DisableCancel = False
			MsgBoxManager.HookEnabled = False
			MsgBoxManager.LastCheckState = False
			MsgBoxManager.ShowNextTimeCheck = False
			MsgBoxManager.ShowTitleCountDown = True
			MsgBoxManager.TimeOut = 10
			
			Dim lang As SetLanguage = New SetLanguage("/Language/Misc/")
			
			
			Dim restartFirefox As System.Windows.Forms.DialogResult
			
			If DontAskBeforeRestarting Then
				restartFirefox = System.Windows.Forms.DialogResult.Yes
			Else
				Dim ConfirmPromptTitle As String = lang.GetText("FirefoxSettings-ConfirmPrompt-Title", "Confirm Firefox Restart")
				Dim ConfirmPromptMessage As String = lang.GetText("FirefoxSettings-ConfirmPrompt-Message", "Would you like to restart Firefox to apply the new proxy settings?")
				
				'Confirm Prompt: Returns Yes/No (DialogResult)
				MsgBoxManager.HookEnabled = True
				restartFirefox = MessageBox.Show(ConfirmPromptMessage, ConfirmPromptTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
				MsgBoxManager.HookEnabled = False
			End If
			
			If restartFirefox = System.Windows.Forms.DialogResult.Yes Then
				' Make sure Firefox restores the previous session after killing it (default setting is enabled but set it anyway)
				Me.ChangeSetting("browser.sessionstore.resume_from_crash", True)
				
				FFProcess.Kill()
				' Wait until process is killed or timeout occurs after 5 seconds
				FFProcess.WaitForExit(5000)
			Else
				FFPath = ""
			End If
		End If
		
		' Save modified preferences (will have no affect if Firefox is running and the restart was denied)
		Try
			oWrite = File.CreateText(Me.PrefsPath & "\" & FirefoxSettings.PrefsFile)
			For Each Line As String In Me.PrefsList
				oWrite.WriteLine(Line)
			Next
			oWrite.Close()
		Catch
			' Ignore falied attempts to write prefs.js
		End Try
		
		' Start Firefox if it was killed before changing the settings
		If FFPath <> "" Then
			Try
				' Prevent displaying the recovery page by setting the counter of recent crashes to 0
				oRead = File.OpenText(Me.PrefsPath & "\" & FirefoxSettings.SessionstoreFile)
				Dim Sessionstore As String = oRead.ReadToEnd
				oRead.Close()
				Dim Pos1 As Integer = Sessionstore.IndexOf(",""recentCrashes"":") + ",""recentCrashes"":".Length
				Dim Pos2 As Integer = Pos1 + Sessionstore.Substring(Pos1).IndexOf("}")
				oWrite = File.CreateText(Me.PrefsPath & "\" & FirefoxSettings.SessionstoreFile)
				oWrite.Write(Sessionstore.Substring(0, Pos1) & "0" & Sessionstore.Substring(Pos2))
				oWrite.Close
			Catch
				' Ignore falied attempt to change sessionstore.js
			End Try
			
			Process.Start(FFPath)
		End If
	End Sub	
End Class
