'
' Created by SharpDevelop.
' User: urx
' Date: 29.10.2012
' Time: 21:57
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Module TcpIp
	Public Sub SaveTCPIPSettings(ByRef IPAddress As String, ByRef SubnetMask As String, ByRef Gateway As String, ByRef PDNSServer As String, ByRef ADNSServer As String, ByRef WINSServer As String, ByRef DNSSuffix As String, ByRef DHCP As Boolean, ByRef MACAddress As String)
		Dim objNetAdapter As Object
		Dim strDNSServers As Object
		Dim strWINSServer As Object
		Dim strDNSSuffix As Object
		Dim strGatewaymetric As Object
		Dim strGateway As Object
		Dim strSubnetMask As Object
		Dim strIPAddress As Object
		Dim colNetAdapters As Object
		Dim objWMIService As Object
		Dim strComputer As Object

		strComputer = "."
        'objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
        objWMIService = GetObject("winmgmts:\\.\root\cimv2")
		colNetAdapters = objWMIService.ExecQuery("Select * from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE and MACAddress='" & MACAddress.Replace("-", ":") & "'")
		'Dim setIPYN As Boolean
		'Dim setSubnetYN As Boolean
		Dim setGatewayYN As Boolean = False
		Dim setPDNSYN As Boolean = False
		Dim setADNSYN As Boolean = False
		'Dim setWINS As Boolean
		
		If IPAddress.Trim.Length.Equals(0) Then IPAddress = ""
		If SubnetMask.Trim.Length.Equals(0) Then SubnetMask = ""
		If Gateway.Trim.Length <> 0 Then setGatewayYN = True
		If PDNSServer.Trim.Length <> 0 Then setPDNSYN = True
		If ADNSServer.Trim.Length <> 0 Then setADNSYN = True
		If WINSServer.Trim.Length.Equals(0) Then WINSServer = ""
		
		strIPAddress = New Object(){IPAddress}
		strSubnetMask = New Object(){SubnetMask}

		If setGatewayYN.Equals(True) Then
			strGateway = New Object(){Gateway}
			strGatewaymetric = New Object(){1}
		Else
			Dim GatewayValue(-1) As String
			Dim Cost(-1) As String
			strGateway = New Object(){GatewayValue}
			strGatewaymetric = New Object(){Cost}
		End If
		strWINSServer = WINSServer
		If setPDNSYN.Equals(True) And setADNSYN.Equals(True) Then
			strDNSServers = New Object(){PDNSServer, ADNSServer}
		ElseIf setPDNSYN.Equals(True) And setADNSYN.Equals(False) Then 
			strDNSServers = New Object(){PDNSServer}
		ElseIf setPDNSYN.Equals(False) And setADNSYN.Equals(True) Then 
			strDNSServers = New Object(){ADNSServer}
		Else
			strDNSServers = New Object(){""}
		End If
		strDNSSuffix = DNSSuffix
		
        For Each objNetAdapter In colNetAdapters
            If DHCP.Equals(True) Then
                ' EnableDHCP() doesn't clear the default gateway on Windows Vista and newer.
                ' Two default gateways will be active if the gateway assigned by DHCP differs
                ' from the previously used gateway.
                ' The workaround for clearing the default gateway is to set the gateway to
                ' the IP address of the adapter.
                ' Here we apply the described workaround:
                objNetAdapter.SetGateways(New Object(){objNetAdapter.IPAddress(0)}, New Object(){1})
                
                objNetAdapter.SetDNSDomain("")
                objNetAdapter.SetDNSServerSearchOrder()
                objNetAdapter.SetDynamicDNSRegistration(True)
                objNetAdapter.EnableDHCP()
                objNetAdapter.RenewDHCPLease()
            Else
                objNetAdapter.SetDNSDomain(strDNSSuffix)
                objNetAdapter.EnableStatic(strIPAddress, strSubnetMask)
                objNetAdapter.SetGateways(strGateway, strGatewaymetric)
                objNetAdapter.SetDNSServerSearchOrder()
                objNetAdapter.SetDNSServerSearchOrder(strDNSServers)
                objNetAdapter.SetWINSServer(strWINSServer, "")
            End If
        Next objNetAdapter
	End Sub

	Public Sub ApplyProfile(ByVal ThisProfile As String, ByVal MACAddress As String)
        '*** START SAVE TCP/IP SETTINGS ***
        Dim strIPAddress As String = INIRead(ThisProfile, "TCP/IP Settings", "IP Address", "")
        Dim strSubnetMask As String = INIRead(ThisProfile, "TCP/IP Settings", "Subnet Mask", "")
        Dim strDefaultGateway As String = INIRead(ThisProfile, "TCP/IP Settings", "Default Gateway", "")
        Dim strPrefDNSServer As String = INIRead(ThisProfile, "TCP/IP Settings", "DNS Server", "")
        Dim strAltDNSServer As String = INIRead(ThisProfile, "TCP/IP Settings", "Alternate DNS Server", "")
        Dim strWINSServer As String = INIRead(ThisProfile, "TCP/IP Settings", "WINS Server", "")
        Dim strDNSSuffix As String = INIRead(ThisProfile, "TCP/IP Settings", "DNS Suffix", "")
        Dim strDHCP As String = INIRead(ThisProfile, "TCP/IP Settings", "DHCP", "0")
        Dim boolDHCP As Boolean
        If strDHCP.Equals("0") Then boolDHCP = False
        If strDHCP.Equals("1") Then boolDHCP = True
        Dim strAutoConfigAddress As String = INIRead(ThisProfile, "Internet Settings", "AutoConfigAddress", "")
        Dim strUseProxySettings As String = INIRead(ThisProfile, "Internet Settings", "UseProxySettings", "0")
        Dim boolUseProxySettings As Boolean
        If strUseProxySettings.Equals("0") Then boolUseProxySettings = False
        If strUseProxySettings.Equals("1") Then boolUseProxySettings = True
        Dim strProxyServerAddress As String = INIRead(ThisProfile, "Internet Settings", "ProxyServerAddress", "")
        Dim strProxyExceptions As String = INIRead(ThisProfile, "Internet Settings", "ProxyExceptions", "")
        Dim boolProxyBypass As Boolean = Convert.ToBoolean(INIRead(ThisProfile, "Internet Settings", "ProxyBypass", Convert.ToString(False)))
        Dim boolProxyIE As Boolean = Convert.ToBoolean(INIRead(ThisProfile, "Internet Settings", "InternetExplorer", Convert.ToString(False)))
        Dim boolProxyFirefox As Boolean = Convert.ToBoolean(INIRead(ThisProfile, "Internet Settings", "Firefox", Convert.ToString(False)))
        Dim strDefaultHomepage As String = INIRead(ThisProfile, "Internet Settings", "DefaultHomepage", "")
        Dim TheMACAddress() As String = StrReverse(ThisProfile).Split(System.Convert.ToChar("\"))
        Dim UseThisMACAddress As String = StrReverse(TheMACAddress(1))
        If MACAddress.Length > 0 Then
            UseThisMACAddress = MACAddress
        End If

        Call SaveTCPIPSettings(strIPAddress, strSubnetMask, strDefaultGateway, strPrefDNSServer, strAltDNSServer, strWINSServer, strDNSSuffix, boolDHCP, UseThisMACAddress)
        '*** END SAVE TCP/IP SETTINGS ***
	End Sub
End Module
