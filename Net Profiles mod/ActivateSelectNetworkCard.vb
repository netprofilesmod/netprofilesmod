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
' User: DMilner
' Date: 2/1/2007
' Time: 3:15 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class ActivateSelectNetworkCard
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub ButtonCancelClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Dispose
	End Sub
	
	Sub ButtonActivateClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Visible = False
		Call MainForm.ApplyProfile(MainForm.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal", Me.comboBoxNetworkCards.SelectedValue.ToString)
		Me.Dispose
	End Sub
	
	Sub ActivateSelectNetworkCardLoad(ByVal sender As Object, ByVal e As EventArgs)
		Me.labelProfile.Text = MainForm.listViewProfiles.SelectedItems.Item(0).SubItems.Item(0).Text
		Me.comboBoxNetworkCards.DataSource = NetworkCardList
		Me.comboBoxNetworkCards.DisplayMember = "Value"
		Me.comboBoxNetworkCards.ValueMember = "Key"
		
		Call LoadLanguage
	End Sub
	
	Public Sub LoadLanguage()
		Dim lang As SetLanguage = New SetLanguage("/Language/ActivateSelectNetworkCard/")
		
		lang.SetText(Me.Text, "WindowTitle")
		lang.SetText(labelProfileTitle.Text, "labelProfileTitle")
		lang.SetText(labelSelectNetworkCard.Text, "labelSelectNetworkCard")
		lang.SetText(buttonActivate.Text, "buttonActivate")
		lang.SetText(buttonCancel.Text, "buttonCancel")
	End Sub
End Class
