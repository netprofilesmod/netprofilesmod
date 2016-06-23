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
' Date: 06.11.2012
' Time: 08:49
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Module GlobalLib
	Public const ProgramVersion As String = "0.2.5"
	Public const ProgramName As String = "Net Profiles mod"
	
	Public CommonApplicationDataFolder As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData) + "\" + ProgramName
	Public ProfilesFolder As String = CommonApplicationDataFolder + "\profiles"
End Module
