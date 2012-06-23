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

#ifdef MESSAGEBOXHOOK_EXPORTS
#define MESSAGEBOXHOOK_API __declspec(dllexport)
#else
#define MESSAGEBOXHOOK_API __declspec(dllimport)
#endif

#include <string>

namespace std
{
#if defined UNICODE || defined _UNICODE
	typedef wstring tstring;
#else
	typedef string tstring;
#endif
}

LRESULT CALLBACK CBTProc(int nCode, WPARAM wParam, LPARAM lParam);
void SetHook(DWORD dwThreadId);
void UnHook();
bool IsHookOn();
void CALLBACK TimerProc(HWND hwnd, UINT uMsg, UINT_PTR idEvent, DWORD dwTime);
BOOL CALLBACK EnumChildProcSetFont(HWND hwnd, LPARAM lParam);
BOOL CALLBACK EnumChildProcEnableButtons(HWND hwnd, LPARAM lParam);
BOOL CALLBACK EnumChildProcStretch(HWND hwnd, LPARAM lParam);
INT_PTR CALLBACK MessageBoxProc(HWND hwndDlg, UINT uMsg, WPARAM wParam, LPARAM lParam);
void SetMessageBoxManager(System::Object^ pMBM);
void ResetMessageBoxManager();
bool IsThisAMessageBox(HWND hWnd);
void StretchWindow(HWND hWnd, int percentage, BOOL bChild = FALSE);
void StretchDialog(HWND hWnd, int percentage);
void CenterWindow(HWND hWndChild, HWND hWndParent);
void SetCustomIcon(HWND hWnd);
void AddCheckBox(RECT& childRect);
int CalculateStretchPercentage();