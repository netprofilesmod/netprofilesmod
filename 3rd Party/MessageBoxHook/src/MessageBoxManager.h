/***
	MessageBoxManager - Enhanced message box functionality for .NET

	Author	:	Nishant Sivakumar
	Email	:	voidnish@gmail.com	
	Blog	:	http://blog.voidnish.com
	Web		:	http://www.voidnish.com 	

	You may freely use this code as long as you include
	this copyright. 
	
	You may freely modify and use this code as long
	as you include this copyright in your modified version. 

	This code is provided "as is" without express or implied warranty. 
	
	Copyright © Nishant Sivakumar, 2006.
	All Rights Reserved.
***/

#pragma once
#include "MessageBoxHook.h"

using namespace System;
using namespace System::Threading;
using namespace System::Collections::Generic;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Drawing;
using namespace System::ComponentModel;

public ref class MessageBoxManager : Component
{
	bool _DesignModeHookEnabled;
public:
	property int TimeOut;
	property bool ShowTitleCountDown;		
	property bool AutoClose;
	property bool ShowNextTimeCheck;
	property DialogResult AutoCloseResult;
	property bool LastCheckState;
	property bool CenterWindow;
	[DefaultValue((Object^)(String^)nullptr)]
	property Font^ TextFont;
	[DefaultValue((Object^)(String^)nullptr)]
	property Icon^ CustomIcon;
	property bool DisableButtons;
	property bool DisableCancel;
	property bool HookEnabled
	{	
		void set(bool bHook)
		{
			if(!DesignMode)
			{
				if(bHook)
				{
					if(!IsHookOn())
					{
						SetMessageBoxManager(this);
						SetHook(GetCurrentThreadId());
					}
				}
				else
				{
					UnHook();
					ResetMessageBoxManager();
				}
			}
			else
				_DesignModeHookEnabled = bHook;
		}
		bool get()
		{
			if(!DesignMode)
				return IsHookOn();
			else
				return _DesignModeHookEnabled;
		}
	}		
};
