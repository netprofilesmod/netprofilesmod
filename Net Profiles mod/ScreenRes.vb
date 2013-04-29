'
' Copyright 2004-2012 Hugo Anton Feldhammer, Urs Geissbühler, Daniel Milner, Corey McInroy
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
Public Class clsScreenRes
	Private Const ENUM_CURRENT_SETTINGS As Integer = -1&
	Private Const CCDEVICENAME As Short = 32
	Private Const CCFORMNAME As Short = 32
	
	Private Const DM_BITSPERPEL As Integer = &H60000
	Private Const DM_PELSWIDTH As Integer = &H80000
	Private Const DM_PELSHEIGHT As Integer = &H100000
	Private Const DM_DISPLAYFREQUENCY As Integer = &H400000
	
	Private Declare Function EnumDisplaySettings Lib "user32" Alias "EnumDisplaySettingsA" (ByVal lpszDeviceName As Integer, ByVal iModeNum As Integer, ByRef lpDevMode As DEVMODE) As Boolean
	Private Declare Function ChangeDisplaySettings Lib "user32" Alias "ChangeDisplaySettingsA" (ByRef lpDevMode As DEVMODE, ByVal dwflags As Integer) As Integer
	
	'Devmode Structure for EnumDisplay API
	Private Structure DEVMODE
		<VBFixedString(CCDEVICENAME), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=CCDEVICENAME)> Public dmDeviceName As String
		Dim dmSpecVersion As Short
		Dim dmDriverVersion As Short
		Dim dmSize As Short
		Dim dmDriverExtra As Short
		Dim dmFields As Integer
		Dim dmOrientation As Short
		Dim dmPaperSize As Short
		Dim dmPaperLength As Short
		Dim dmPaperWidth As Short
		Dim dmScale As Short
		Dim dmCopies As Short
		Dim dmDefaultSource As Short
		Dim dmPrintQuality As Short
		Dim dmColor As Short
		Dim dmDuplex As Short
		Dim dmYResolution As Short
		Dim dmTTOption As Short
		Dim dmCollate As Short
		<VBFixedString(CCFORMNAME), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=CCFORMNAME)> Public dmFormName As String
		Dim dmUnusedPadding As Short
		Dim dmBitsPerPel As Integer
		Dim dmPelsWidth As Integer
		Dim dmPelsHeight As Integer
		Dim dmDisplayFlags As Integer
		Dim dmDisplayFrequency As Integer
	End Structure
	
	
	Sub SetDisplay(Width As Integer, Height As Integer, BPP As Integer, RefreshRate As Integer)
		Dim DevM As New DEVMODE
		
		' Needed to set all fields of DevM
		EnumDisplaySettings(0, ENUM_CURRENT_SETTINGS, DevM)
		
		With DevM
			.dmFields = DM_PELSWIDTH Or DM_PELSHEIGHT Or DM_BITSPERPEL Or DM_DISPLAYFREQUENCY
			.dmPelsWidth = Width
			.dmPelsHeight = Height
			.dmBitsPerPel = BPP
			.dmDisplayFrequency = RefreshRate
		End With
		
		Call ChangeDisplaySettings(DevM, 0)
	End Sub
	
	
	Sub SetDisplay(Width As Integer, Height As Integer)
		Dim DevM As New DEVMODE
		
		' Needed to set all fields of DevM
		EnumDisplaySettings(0, ENUM_CURRENT_SETTINGS, DevM)
		
		With DevM
			.dmFields = DM_PELSWIDTH Or DM_PELSHEIGHT
			.dmPelsWidth = Width
			.dmPelsHeight = Height
		End With
		
		Call ChangeDisplaySettings(DevM, 0)
	End Sub
	
	
	Public Function GetCurrentSettings() As Integer()
		Dim DevM As New DEVMODE
		EnumDisplaySettings(0, ENUM_CURRENT_SETTINGS, DevM)
		Return New Integer() {DevM.dmPelsWidth, DevM.dmPelsHeight, DevM.dmBitsPerPel, DevM.dmDisplayFrequency}
	End Function
	
	
	Public Function GetResolutions(ResFromProfile As Integer()) As List(Of Integer())
		Dim l As Long
		Dim DevM As New DEVMODE
		Dim lnumModes As Integer = 0
		
		l = CLng(EnumDisplaySettings(0, -1, DevM))
		
		Dim sortedResolutions As New SortedDictionary(Of Integer, SortedDictionary(Of Integer, Boolean)) 
		
		' Add the current resolution regardless of the required minumun resolution of 640x480
		Dim currentSettings As Integer() = Me.GetCurrentSettings()
		sortedResolutions.Add(currentSettings(0), New SortedDictionary(Of Integer, Boolean))
		sortedResolutions(currentSettings(0)).Add(currentSettings(1), False)
		
		' Add the resolution saved in the profile regardless of the required minumun resolution of 640x480
		Try
			sortedResolutions.Add(ResFromProfile(0), New SortedDictionary(Of Integer, Boolean))
		Catch
		End Try
		Try
			sortedResolutions(ResFromProfile(0)).Add(ResFromProfile(1), False)
		Catch
		End Try
		
		Do While CBool(l)
			' Only add resolutions with 32 bits per pixel
			If DevM.dmBitsPerPel = 32 Then
				' Filter widths lower than 640
				If DevM.dmPelsWidth >= 640 Then
					Try
						sortedResolutions.Add(DevM.dmPelsWidth, New SortedDictionary(Of Integer, Boolean))
					Catch
					End Try
					' Filter heights lower than 480
					If DevM.dmPelsHeight >= 480 Then
						Try
							sortedResolutions(DevM.dmPelsWidth).Add(DevM.dmPelsHeight, False)
						Catch
						End Try
					End If
				End If
			End If
			
			lnumModes = lnumModes + 1
			l = CLng(EnumDisplaySettings(0, lnumModes, DevM))
		Loop
		
		Dim resolutions As New List(Of Integer())
		For Each width As Integer In sortedResolutions.Keys
			For Each height As Integer In sortedResolutions(width).Keys
				resolutions.Add(New Integer(){width, height})
			Next
		Next
		
		Return resolutions
	End Function
End Class
