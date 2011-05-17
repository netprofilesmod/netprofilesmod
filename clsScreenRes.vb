'************************************************************************************
'clsScreenRes by Corey McInroy
'email: creptic@gmail.com
'Date: 8/01/2005
'Compiler Visual Basic 2005 (Beta 2)
'Purpose: Class for changing Resolution, and getting Display Settings.
'Method List and short info:
'-
'bValidate: Validates Resolution,BPP, and RefreshRate (must be valid mode) : Boolean
'bConfirmPrompt: Show Confirm Prompt : Boolean
'bRevertPrompt: Show Keep Settings Prompt: Boolean 
'-
'ValidResolutions: Returns Valid Resolutions : Returns String : ex "640x480,800x600,etc"
'- ex. ValidResolutions(False) or ValidResolutions() will return all Resolutions.
'- ex. ValidResolutions(True) will return standard Resolutions. 
'- see GetValidResolutions to edit resolutions, in select case if needed.
'ValidBPPs: Return Valid Bit Per Pixels : String : ex "8,16,32"
'ValidRefreshRates: Return Valid Refresh Rates depending on resolution : String : ex "60,75,80"
'-
'CurrentResolution: Return Current Resolution : String : ex "1024x768"
'CurrentBPP: Returns Current Bits Per Pixel : Integer : ex 32
'CurrentRefreshRate: Returns Current Refresh Rate : Integer : ex 75
'-
'SavedResolution: returns m_resolution (for resetting) : string : ex "1024,768"
'SavedBPP: returns m_bpp (for resetting) : Integer : ex 16
'SavedRefreshRate: returns m_refreshrate (for resetting) : Integer : ex 75 
'-
'Reset: Resets resolution,bpp, & refreshrate using m_resolution,m_bpp, & m_refreshrate 
'- : String : ex "Passed" (returns value from ChangeDisplay)
'SaveCurrentSettings : Saves Current settings to m_resolution,m_bpp,m_refresh rate for resetting  
'- : String : Returns ex "1024,768,32,75"
'ChangeResolution: Changes Display. See overloaded functions. ex "Passed" 
'- : String : Returns value from ChangeDisplay
'

'Usage Example. 

'Dim MyNewScreen as New clsScreenRes

'MyNewScreen.bConfirmPrompt = True 
'MyNewScreen.bRevertPrompt = True
'MyNewScreen.bValidate = true
'MyNewScreen.ChangeResolution(1024,768) 

'**Validate is on as default.
'**When resolution is changed its NOT changed as default Windows Resolution in winXP, i dont know for 
'-certain for other OS. if you have a undesireable display. and reboot,
'-the settings in windows display settings should be displayed.

'Code distributed "as is" and can be used without permission. Enjoy. 
'************************************************************************************

Imports System.Xml

Public Class clsScreenRes
    'Screen Resolution API and Constants

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

    'fields
    Private m_width As Integer
    Private m_height As Integer
    Private m_bpp As Integer
    Private m_refreshrate As Integer
    Private m_bRevertPrompt As Boolean
    Private m_bConfirmPrompt As Boolean
    Private m_bValidate As Boolean = True
    Private m_bResetting As Boolean
    Private m_currentRes As String
    Private m_currentRefresh As String
    Private m_currentBPP As String

    '********************************************************************************
    'Constructor
    Public Sub New()
        Dim DevM As New DEVMODE
        'get current resolution and store 
        EnumDisplaySettings(0, ENUM_CURRENT_SETTINGS, DevM)
        m_width = DevM.dmPelsWidth
        m_height = DevM.dmPelsHeight
        m_bpp = DevM.dmBitsPerPel
        m_refreshrate = DevM.dmDisplayFrequency
        'set default values
        m_bValidate = True
        m_currentRes = m_width & "x" & m_height
        'm_currentRes = m_width & " by " & m_height & " pixels"
        m_currentRefresh = m_refreshrate.ToString
        m_currentBPP = m_bpp.ToString
        'Select Case Val(m_bpp.ToString)
        '	Case 8
		'		m_currentBPP = "256 (8 bit)"
		'	Case 16
		'		m_currentBPP = "Lowest (16 bit)"
		'	Case 32
		'		m_currentBPP = "Highest (32 bit)"
        'End Select
    End Sub

    'Properties
    Public Property bConfimPrompt() As Boolean
        Get
            Return m_bConfirmPrompt
        End Get
        Set(ByVal value As Boolean)
            m_bConfirmPrompt = value
        End Set
    End Property

    Public Property bRevertPrompt() As Boolean
        Get
            Return m_bRevertPrompt
        End Get
        Set(ByVal value As Boolean)
            m_bRevertPrompt = value
        End Set
    End Property

    Public Property bValidate() As Boolean
        Get
            Return m_bValidate
        End Get
        Set(ByVal value As Boolean)
            m_bValidate = value
        End Set
    End Property

    'Methods

    '*********
    'Overloaded methods

    Public Function ChangeResolution(ByVal iWidth As Integer, ByVal iHeight As Integer) As String
        Return ChangeDisplay(iWidth, iHeight, m_bpp, m_refreshrate)
    End Function
    Public Function ChangeResolution(ByVal iWidth As Integer, ByVal iHeight As Integer, ByVal iBpp As Integer) As String
        Return ChangeDisplay(iWidth, iHeight, iBpp, m_refreshrate)
    End Function
    Public Function ChangeResolution(ByVal iWidth As Integer, ByVal iHeight As Integer, ByVal iBpp As Integer, ByVal iRefreshRate As Integer) As String
        Return ChangeDisplay(iWidth, iHeight, iBpp, iRefreshRate)
    End Function

    '**********
    Private Function ChangeDisplay(ByVal iWidth As Integer, ByVal iHeight As Integer, ByVal iBPP As Integer, ByVal iRefreshRate As Integer) As String
        'Change display (via api) and return a value
        'Decided to use string as return value instead of boolean. So errors can be returned.
        '#######################
        'Return values:
        '"Invalid Resolution" : if bvalidate is true and Invalid Resolution is Passed 
        '"Invalid Bpp" : if bvalidate is true and Invalid BPP is Passed 
        '"Invalid Refresh_Rate" if bvalidate is true and Invalid Refresh Rate is Passed 
        '"Confirm Failed" : if confirm prompt is enabled, and user selects "No"
        '"Revert Reset" : if revert prompt is enabled, and user selects "No" and is Reset
        '"Successful" : Resolution Changed Successfully
        'If Error Occurs Err.Description is Returned 
        '#######################

        'Note: if m_resetting is True it will bypass prompts (used for reseting display)

        On Error GoTo Errorhandler

        '*************************
        'Validate data

        If CheckResolution(iWidth, iHeight) = False And m_bValidate = True Then
            Debug.Print("Invalid Resolution (" & iWidth & "x" & iHeight & ")")
            Return "Invalid Resolution"
        End If

        If CheckValidBPP(iBPP) = False And m_bValidate = True Then
            Debug.Print("Invalid Bpp (" & iBPP & ")")
            Return "Invalid Bpp"
        End If

        If CheckValidRefresh(iWidth, iHeight, iRefreshRate) = False And m_bValidate = True Then
            Debug.Print("Invalid Refresh Rate: " & iRefreshRate & " for (" & iWidth & "x" & iHeight & ")")
            Return "Invalid Refresh_Rate"
        End If

        'Prompt for Confirmation (ConfirmPrompt)

        If m_bConfirmPrompt = True And m_bResetting = False Then
            If ShowConfirmPrompt(iWidth, iHeight, iBPP, iRefreshRate) = MsgBoxResult.No Then
                Call Reset()
                Return "Confirm Failed"
            End If
        End If

        'Get Mode and Change Display

        Dim bDone As Boolean
        Dim i As Integer ' counter

        i = 0
        Dim DevM As New DEVMODE
        Do
            bDone = EnumDisplaySettings(0, i, DevM)
            i += 1
        Loop Until (bDone = False)

        With DevM
            .dmFields = DM_PELSWIDTH Or DM_PELSHEIGHT Or DM_BITSPERPEL Or DM_DISPLAYFREQUENCY
            .dmPelsWidth = iWidth
            .dmPelsHeight = iHeight
            .dmBitsPerPel = iBPP
            .dmDisplayFrequency = iRefreshRate
        End With

        'Change Display is done here

        Call ChangeDisplaySettings(DevM, 0)

        'Prompt to Keep Settings RevertPrompt, if NO then  Reset.

        If m_bRevertPrompt = True And m_bResetting = False Then
            If ShowRevertPrompt(iWidth, iHeight, iBPP, iRefreshRate) = MsgBoxResult.No Then
                Call Reset()
                Return "Revert Reset"
            End If
        End If

        m_bResetting = False
        'Save settings as Current

        m_currentRes = DevM.dmPelsWidth & "x" & DevM.dmPelsHeight
        'm_currentRes = DevM.dmPelsWidth & " by " & DevM.dmPelsHeight & " pixels"
        m_currentRefresh = DevM.dmDisplayFrequency.ToString
        m_currentBPP = DevM.dmBitsPerPel.ToString
        'm_currentBPP = DevM.dmBitsPerPel.ToString & " bit"
        'Select Case DevM.dmBitsPerPel.ToString
        '	Case 8
		'		m_currentBPP = "256 (8 bit)"
		'	Case 16
		'		m_currentBPP = "Lowest (16 bit)"
		'	Case 32
		'		m_currentBPP = "Highest (32 bit)"
        'End Select

        Return "Success"
Errorhandler:
        Return Err.Description.ToString
    End Function

    Public Function SaveCurrent() As String
        'saves current settings 
        '-used for reset, if values created when instance created need to be changed.
        'also returns current settings ex; "1024,768,32,75"

        Dim strSplit(1) As String
        strSplit = Split(m_currentRes, "x", 2, CompareMethod.Text)
        m_width = CInt(Val(strSplit(0)))
        m_height = CInt(Val(strSplit(1)))
        'Dim strSplit(2) As String
        'strSplit = Split(m_currentRes, " ", 3, CompareMethod.Text)
        'm_width = Val(strSplit(0))
        'm_height = Val(strSplit(2))
        m_bpp = CInt(Val(m_currentBPP))
        'Select Case m_currentBPP.ToString
        '	Case "256 (8 bit)"
		'		m_bpp = Val("8")
		'	Case "Lowest (16 bit)"
		'		m_bpp = Val("16")
		'	Case "Highest (32 bit)"
		'		m_bpp = Val("32")
        'End Select
        m_refreshrate = CInt(Val(m_currentRefresh))
        Return m_width & "x" & m_height & "x" & m_bpp & "x" & m_refreshrate

    End Function

    Public Function Reset() As String
        'Resets to variable values
        'returns value returned from ChangeDisplay
        m_bResetting = True
        Return ChangeDisplay(m_width, m_height, m_bpp, m_refreshrate)
    End Function

    Public Function CurrentResolution() As String
        Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement
		Dim byText As String = root.SelectSingleNode("/Language/ProfileSettings/ScreenResolutionText-By").InnerText
		Dim pixelsText As String = root.SelectSingleNode("/Language/ProfileSettings/ScreenResolutionText-Pixels").InnerText
        
        Dim strTempResArray() As String = m_currentRes.Split(CChar("x"))
        Return strTempResArray(0) & " " & byText & " " & strTempResArray(1) & " " & pixelsText
        'Return m_currentRes
    End Function

    Public Function CurrentRefreshRate() As String
        Return m_currentRefresh
    End Function

    Public Function CurrentBPP() As String
        Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement
		Dim bitText As String = root.SelectSingleNode("/Language/ProfileSettings/ColorQualityText-Bit").InnerText
		Dim lowestText As String = root.SelectSingleNode("/Language/ProfileSettings/ColorQualityText-Lowest").InnerText
		Dim highestText As String = root.SelectSingleNode("/Language/ProfileSettings/ColorQualityText-Highest").InnerText
        
        Dim ThisBPP As String = ""
		Select Case m_currentBPP
            Case "8"
                ThisBPP = "256 (8 " & bitText & ")"
            Case "16"
                ThisBPP = lowestText & " (16 " & bitText & ")"
            Case "32"
                ThisBPP = highestText & " (32 " & bitText & ")"
        End Select
        Return ThisBPP
    End Function

    Public Function ValidResolutions() As String
        Return GetValidResolutions(False)
    End Function
    Public Function ValidResolutions(ByVal bStandardResolutionsOnly As Boolean) As String
        Return GetValidResolutions(bStandardResolutionsOnly)
    End Function
    Private Function GetValidResolutions(ByVal bStandardResolutionsOnly As Boolean, Optional ByVal bValidating As Boolean = False) As String

        'returns ex. "600x800,640x800"

        Dim l As Long
        Dim lMaxModes As Long

        Dim strResolutions As String = ""
        Dim strFirst As String = ""
        Dim strPrevious As String = ""

        Dim DevM As New DEVMODE
        Dim lnumModes As Integer = 0

        l = CLng(EnumDisplaySettings(0, -1, DevM))

        Do While CBool(l)
            If DevM.dmBitsPerPel = 8 And strPrevious <> DevM.dmPelsWidth & "x" & DevM.dmPelsHeight Then
                'If DevM.dmBitsPerPel = 8 And strPrevious <> DevM.dmPelsWidth & " by " & DevM.dmPelsHeight & " pixels" Then
                If strResolutions = "" Then
                    strResolutions = DevM.dmPelsWidth & "x" & DevM.dmPelsHeight
                    'strResolutions = DevM.dmPelsWidth & " by " & DevM.dmPelsHeight & " pixels"
                    strFirst = strResolutions
                Else
                    If strFirst <> DevM.dmPelsWidth & "x" & DevM.dmPelsHeight Then
                        'If strFirst <> DevM.dmPelsWidth & " by " & DevM.dmPelsHeight & " pixels" Then
                        strResolutions = strResolutions & "," & DevM.dmPelsWidth & "x" & DevM.dmPelsHeight
                        'strResolutions = strResolutions & "," & DevM.dmPelsWidth & " by " & DevM.dmPelsHeight & " pixels"
                        ' Debug.Print(strResolutions)
                    End If
                End If
                strPrevious = DevM.dmPelsWidth & "x" & DevM.dmPelsHeight
                'strPrevious = DevM.dmPelsWidth & " by " & DevM.dmPelsHeight & " pixels"
            End If

            lnumModes = lnumModes + 1
            If lnumModes > lMaxModes Then lMaxModes = lMaxModes + 8
            l = CLng(EnumDisplaySettings(0, lnumModes, DevM))
        Loop

        If bStandardResolutionsOnly = True And bValidating = False Then
            Dim strTempMode As String = ""
            Dim strNewResolutionsArray() As String
            Dim strNewResolutions As String = ""

            strNewResolutionsArray = Split(strResolutions, ",")

            For Each strTempMode In strNewResolutionsArray

                Select Case strTempMode
                    Case "640x480", "800x600", "960x600", "1024x768", "1152x864", "1280x720", "1280x768", "1280x800", "1280x960", "1280x1024", "1360x768", "1600x1200", "1600x1280"
                    'Case "640 by 480 pixels", "800 by 600 pixels", "1024 by 768 pixels", "1280 by 1024 pixels", "1600 by 1200 pixels"
                        If strNewResolutions = "" Then
                            strNewResolutions = strTempMode
                        Else
                            strNewResolutions = strNewResolutions & "," & strTempMode
                        End If
                End Select

            Next
            strResolutions = strNewResolutions
        End If


        Return strResolutions
    End Function


    Public Function ValidBPPs() As String
        'Returns all valid BPPs as string ex "8,16,32"

        Dim strArrayBPP(2) As String
        Dim strBPP As String = ""
        Dim strModesBPP As String = ""

        Dim l As Long
        Dim lMaxModes As Long
        Dim lnumModes As Integer = 0

        Dim DevM As New DEVMODE


        l = CLng(EnumDisplaySettings(0, -1, DevM))

        Do While CBool(l)

            Select Case Val(DevM.dmBitsPerPel)
                Case 8
                    strArrayBPP(0) = "8"
                    'strArrayBPP(0) = "256 (8 bit)"
                Case 16
                    strArrayBPP(1) = "16"
                    'strArrayBPP(1) = "Lowest (16 bit)"
                Case 32
                    strArrayBPP(2) = "32"
                    'strArrayBPP(2) = "Highest (32 bit)"
            End Select

            lnumModes = lnumModes + 1
            If lnumModes > lMaxModes Then lMaxModes = lMaxModes + 8

            l = CLng(EnumDisplaySettings(0, lnumModes, DevM))

        Loop
        For Each strBPP In strArrayBPP
            If strModesBPP = "" Then
                strModesBPP = strBPP
            Else
                strModesBPP = strModesBPP & "," & strBPP
            End If
        Next

        Return strModesBPP


    End Function

    Public Function ValidRefreshRates(ByVal iWidth As Integer, ByVal iHeight As Integer) As String
        'returns Valid refresh rates depending on resolution passed
        'returns string ex. "60,75,85,100"
        Dim lngTemp As Long
        Dim lngMaxModes As Long
        Dim strTempRates As String = ""
        Dim strTempResolution As String
        Dim strCheckResolution As String

        Dim DevM As New DEVMODE

        Dim lnumModes As Integer = 0
        lngTemp = CLng(EnumDisplaySettings(0, -1, DevM))

        strCheckResolution = iWidth & "x" & iHeight
        'strCheckResolution = iWidth & " by " & iHeight & " pixels"

        Do While CBool(lngTemp)

            strTempResolution = DevM.dmPelsWidth & "x" & DevM.dmPelsHeight
            'strTempResolution = DevM.dmPelsWidth & " by " & DevM.dmPelsHeight & " pixels"

            If strTempResolution = strCheckResolution And DevM.dmBitsPerPel = 8 Then
                If strTempRates = "" Then
                    strTempRates = CStr(DevM.dmDisplayFrequency)
                Else
                    strTempRates = strTempRates & "," & DevM.dmDisplayFrequency

                End If
            End If

            lnumModes = lnumModes + 1
            If lnumModes > lngMaxModes Then lngMaxModes = lngMaxModes + 8

            lngTemp = CLng(EnumDisplaySettings(0, lnumModes, DevM))

        Loop

        Return strTempRates

    End Function

    Private Function CheckResolution(ByVal iWidth As Integer, ByVal iHeight As Integer) As Boolean
        'Purpose: check if Resolution is valid 
        'get Valid Screen Resolutions 
        'returns True/False
        Dim strTempValid As String = ""
        Dim strValidArray() As String
        Dim bValid As Boolean

        strTempValid = GetValidResolutions(False, True)
        strValidArray = Split(strTempValid, ",")

        'reuse strTempValid
        strTempValid = ""

        For Each strTempValid In strValidArray
            If strTempValid = iWidth & "x" & iHeight Then bValid = True
            'If strTempValid = iWidth & " by " & iHeight & " pixels" Then bValid = True
        Next

        Return bValid
    End Function

    Private Function CheckValidBPP(ByVal iBPP As Integer) As Boolean
        'Purpose: check if BPP is valid 
        'Returns True/False
        Dim strTempValid As String = ""
        Dim strValidArray() As String
        Dim bValid As Boolean

        strTempValid = ValidBPPs()
        strValidArray = Split(strTempValid, ",")

        'reuse strTempValid
        strTempValid = ""

        For Each strTempValid In strValidArray
            If Val(strTempValid) = Val(iBPP) Then bValid = True
        Next

        Return bValid
    End Function

    Private Function CheckValidRefresh(ByVal iWidth As Integer, ByVal iHeight As Integer, ByVal iRefreshRate As Integer) As Boolean
        'Purpose: check if Refresh Rate is valid  
        'returns True/False
        Dim strTempValid As String = ""
        Dim strValidArray() As String
        Dim bValid As Boolean

        strTempValid = ValidRefreshRates(iWidth, iHeight)
        strValidArray = Split(strTempValid, ",")

        'reuse strTempValid
        strTempValid = ""

        For Each strTempValid In strValidArray
            If Val(strTempValid) = Val(iRefreshRate) Then bValid = True
        Next

        Return bValid
    End Function
    
    Private Function ShowConfirmPrompt(ByVal iWidth As Integer, ByVal iHeight As Integer, ByVal iBPP As Integer, ByVal iRefreshRate As Integer) As MsgBoxResult
        Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement
		Dim ConfirmPromptTitle As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-ConfirmPrompt-Title").InnerText
		Dim ConfirmPromptMessage As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-ConfirmPrompt-Message").InnerText
		Dim ResolutionText As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-Resolution").InnerText
		Dim BitsText As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-Bits").InnerText
		Dim RefreshText As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-Refresh").InnerText
        
        'Confirm Prompt: Returns Yes/No (msgboxresult)
        Dim strMessage As String
        'strMessage = "Would you like to change display settings?" & vbCrLf
        'strMessage += vbCrLf & "Resolution: " & iWidth & "x" & iHeight
        'strMessage += vbCrLf & "Colour Bits: " & iBPP
        'strMessage += vbCrLf & "Refresh: " & (iRefreshRate) & vbCrLf
        'ShowConfirmPrompt = MessageBox.Show(strMessage, "Confirm Display Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        strMessage = ConfirmPromptMessage & vbCrLf
        strMessage += vbCrLf & ResolutionText & " " & iWidth & "x" & iHeight
        strMessage += vbCrLf & BitsText & " " & iBPP
        strMessage += vbCrLf & RefreshText & " " & (iRefreshRate) & vbCrLf
        ShowConfirmPrompt = MessageBox.Show(strMessage, ConfirmPromptTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    End Function
    
    Private Function ShowRevertPrompt(ByVal iWidth As Integer, ByVal iHeight As Integer, ByVal iBPP As Integer, ByVal iRefreshRate As Integer) As MsgBoxResult
        Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement
		Dim RevertPromptTitle As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-RevertPrompt-Title").InnerText
		Dim RevertPromptMessage As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-RevertPrompt-Message").InnerText
		Dim ResolutionText As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-Resolution").InnerText
		Dim BitsText As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-Bits").InnerText
		Dim RefreshText As String = root.SelectSingleNode("/Language/Misc/DisplaySettings-Refresh").InnerText
        
        'Revert Prompt: Returns Yes/No (msgboxresult)
        Dim strMessage As String
        'strMessage = "Would you like to keep current settings?" & vbCrLf
        'strMessage += vbCrLf & "Resolution: " & iWidth & "x" & iHeight
        'strMessage += vbCrLf & "Colour Bits: " & iBPP
        'strMessage += vbCrLf & "Refresh: " & (iRefreshRate) & vbCrLf
        'ShowRevertPrompt = MessageBox.Show(strMessage, "Display Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        strMessage = RevertPromptMessage & vbCrLf
        strMessage += vbCrLf & ResolutionText & " " & iWidth & "x" & iHeight
        strMessage += vbCrLf & BitsText & " " & iBPP
        strMessage += vbCrLf & RefreshText & " " & (iRefreshRate) & vbCrLf
        ShowRevertPrompt = MessageBox.Show(strMessage, RevertPromptTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    End Function


    Public Function SavedResolution() As String
        Return m_width & "x" & m_height
        'Return m_width & " by " & m_height & " pixels"
    End Function
    Public Function SavedBPP() As Integer
        Return m_bpp
    End Function
    Public Function SavedRefreshRate() As Integer
        Return m_refreshrate
    End Function
    '********************************************************************************
End Class
