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

#include "stdafx.h"
#include "MessageBoxHook.h"
#include "MessageBoxManager.h"
#include <gcroot.h>

#ifdef _MANAGED
#pragma managed(push, off)
#endif

HHOOK hHook = NULL;
HWND hWndMsgBox = NULL;
HWND hWndChk = NULL;
UINT_PTR nTimerID = NULL;
std::tstring gOrigTitle;
DLGPROC pOldProc = NULL;
HFONT hCustomFont = NULL;
int nTimeOut = 0;
gcroot<MessageBoxManager^> pMessageBoxManager =  nullptr;

#define SIZEINCREASEFORCHKBOX 23

BOOL APIENTRY DllMain( HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}

#ifdef _MANAGED
#pragma managed(pop)
#endif

void SetMessageBoxManager(System::Object^ pMBM)
{
	pMessageBoxManager = safe_cast<MessageBoxManager^>(pMBM);
}

void ResetMessageBoxManager()
{
	pMessageBoxManager = nullptr;
}

LRESULT CALLBACK CBTProc(int nCode, WPARAM wParam, LPARAM lParam)
{
	if(nCode == HCBT_ACTIVATE)
	{
		if(!IsThisAMessageBox((HWND)wParam))
			return 0;

		UnHook();
		hWndMsgBox = (HWND)wParam;

		int len = GetWindowTextLength(hWndMsgBox);
		PTCHAR buff = new TCHAR[len+1];
		GetWindowText(hWndMsgBox, buff, len+1);
		gOrigTitle = buff;
		delete[] buff;

		if(pMessageBoxManager->DisableButtons && (pMessageBoxManager->TimeOut > 0))
			EnumChildWindows(hWndMsgBox, EnumChildProcEnableButtons, (LPARAM)FALSE);

		RECT childRect;
		GetWindowRect(hWndMsgBox, &childRect);

		if(pMessageBoxManager->ShowNextTimeCheck)
		{
			AddCheckBox(childRect);
			MoveWindow(hWndMsgBox, childRect.left, childRect.top,
				childRect.right - childRect.left,
				childRect.bottom - childRect.top, TRUE);
		}

		int stretchpercentage = 0;

		if(pMessageBoxManager->TextFont)
		{
			hCustomFont = (HFONT)pMessageBoxManager->TextFont->ToHfont().ToPointer();
			stretchpercentage = CalculateStretchPercentage();

			SendMessage(hWndMsgBox, WM_SETFONT, (WPARAM)hCustomFont, 0);
			EnumChildWindows (hWndMsgBox, EnumChildProcSetFont, (LPARAM)hCustomFont);
		}	

		if(pMessageBoxManager->CustomIcon)
		{
			SetCustomIcon(hWndMsgBox);
		}		

		if(stretchpercentage > 0)
		{
			StretchDialog(hWndMsgBox, stretchpercentage);			
		}

		if(pMessageBoxManager->CenterWindow)
		{
			CenterWindow(hWndMsgBox, GetParent(hWndMsgBox));
		}		

		pOldProc = (DLGPROC)SetWindowLongPtr(hWndMsgBox, DWL_DLGPROC, (LONG_PTR)MessageBoxProc);
		nTimeOut = pMessageBoxManager->TimeOut;
		if(nTimeOut > 0)
			nTimerID = SetTimer(NULL, 0, 1000, TimerProc);
	}
	return 0;
}

void SetCustomIcon(HWND hWnd)
{
	HWND hwndChildAfter = NULL;
	while(HWND hIconWnd = FindWindowEx(hWnd, hwndChildAfter, _T("STATIC"), NULL))
	{
		if(GetWindowLong(hIconWnd, GWL_STYLE) & SS_ICON)
		{
			SendMessage(hIconWnd, STM_SETIMAGE, (WPARAM)IMAGE_ICON,
				(LPARAM)(HICON)pMessageBoxManager->CustomIcon->Handle.ToPointer());
			break;
		}
		hwndChildAfter = hIconWnd;
	}
}

void SetHook(DWORD dwThreadId)
{
	hHook = SetWindowsHookEx(WH_CBT, CBTProc, NULL, dwThreadId); 	
}

void UnHook()
{
	UnhookWindowsHookEx(hHook);
	hHook = NULL;
}

bool IsHookOn()
{
	return hHook != NULL;
}

void CALLBACK TimerProc(HWND hwnd, UINT uMsg, UINT_PTR idEvent, DWORD dwTime)
{
	if(--nTimeOut == 0)
	{
		KillTimer(NULL, nTimerID);
		SetWindowText(hWndMsgBox, gOrigTitle.c_str());

		if(pMessageBoxManager->DisableButtons)
			EnumChildWindows(hWndMsgBox, EnumChildProcEnableButtons, (LPARAM)TRUE);

		if(pMessageBoxManager->AutoClose)
		{	
			PostMessage(hWndMsgBox,WM_COMMAND,
				MAKEWPARAM((int)pMessageBoxManager->AutoCloseResult,BN_CLICKED),
				(LPARAM)GetDlgItem(hWndMsgBox,(int)pMessageBoxManager->AutoCloseResult));
			PostMessage(hWndMsgBox, WM_CLOSE, 0, 0);			
		}
		hWndMsgBox = NULL;
	}
	else
	{
		if(pMessageBoxManager->ShowTitleCountDown)
		{
			TCHAR buff[100];
			_stprintf_s(buff,99,_T("%d seconds remaining..."),nTimeOut);
			SetWindowText(hWndMsgBox, buff);
		}
	}
}

BOOL CALLBACK EnumChildProcSetFont(HWND hwnd, LPARAM lParam)
{
	SendMessage(hwnd, WM_SETFONT, (WPARAM)lParam, 0);
	return TRUE;
}

BOOL CALLBACK EnumChildProcEnableButtons(HWND hwnd, LPARAM lParam)
{
	TCHAR classname[32];
	if(GetClassName(hwnd, classname, 32) && (_tcsicmp(classname, _T("button"))==0))
	{	
		if((BOOL)lParam && (GetDlgCtrlID(hwnd) == IDCANCEL)
			&& !pMessageBoxManager->DisableCancel
			&& !IsWindowEnabled(hwnd))
		{
			EnableWindow(hwnd,(BOOL)lParam);
		}
		else if((GetDlgCtrlID(hwnd) != IDCANCEL) || pMessageBoxManager->DisableCancel)
		{
			EnableWindow(hwnd,(BOOL)lParam);			
		}
	}
	return TRUE;
}

INT_PTR CALLBACK MessageBoxProc(HWND hwndDlg, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	if( (uMsg == WM_COMMAND) && (HIWORD(wParam) == BN_CLICKED) )
	{
		if((HWND)lParam == hWndChk) 
			pMessageBoxManager->LastCheckState = SendMessage(hWndChk, BM_GETCHECK,0 ,0)==BST_CHECKED;
		else if( nTimeOut > 0 && pMessageBoxManager->DisableButtons )
			return TRUE;
	}

	if( uMsg == WM_DESTROY )
	{
		KillTimer(NULL, nTimerID);
		if(hCustomFont)
		{
			DeleteObject(hCustomFont);
			hCustomFont = NULL;
		}
		SetHook(GetCurrentThreadId());
	}	

	return pOldProc(hwndDlg, uMsg, wParam, lParam);
}

bool IsThisAMessageBox(HWND hWnd)
{
	bool bDialogClass = false;
	bool bFoundKnownButton = false;
	bool bFoundOtherControls = true;

	TCHAR classname[32];
	if(GetClassName(hWnd, classname, 32))
	{
		if(_tcsicmp(classname, _T("#32770")) == 0)
		{
			bDialogClass = true;
		}
	}
	bFoundKnownButton = (GetDlgItem(hWnd, IDOK)!=NULL) || (GetDlgItem(hWnd, IDCANCEL)!=NULL)
		|| (GetDlgItem(hWnd, IDYES)!=NULL) || (GetDlgItem(hWnd, IDNO)!=NULL)
		|| (GetDlgItem(hWnd, IDABORT)!=NULL) || (GetDlgItem(hWnd, IDRETRY)!=NULL)
		|| (GetDlgItem(hWnd, IDIGNORE)!=NULL);

	bFoundOtherControls = FindWindowEx(hWnd, NULL, _T("COMBOBOX"), NULL) 
		|| FindWindowEx(hWnd, NULL, _T("EDIT"), NULL);

	return bDialogClass && bFoundKnownButton && !bFoundOtherControls;
}

void StretchDialog(HWND hWnd, int percentage)
{
	StretchWindow(hWnd, percentage);
	EnumChildWindows(hWnd, EnumChildProcStretch, (LPARAM)percentage);
}

void StretchWindow(HWND hWnd, int percentage, BOOL bChild /*FALSE*/)
{
	RECT rect;
	GetWindowRect(hWnd, &rect);
	POINT pt;
	pt.x = rect.left;
	pt.y = rect.top;
	if(bChild)
	{
		ScreenToClient(GetParent(hWnd), &pt);
		pt.x += percentage * pt.x / 100;
		pt.y += percentage * pt.y / 100;
	}
	rect.right += percentage * (rect.right - rect.left) / 100;
	rect.bottom += percentage * (rect.bottom - rect.top) / 100;
	MoveWindow(hWnd, pt.x, pt.y,
		rect.right - rect.left, rect.bottom - rect.top, TRUE);		
}

BOOL CALLBACK EnumChildProcStretch(HWND hwnd, LPARAM lParam)
{
	StretchWindow(hwnd, (int)lParam, TRUE);
	return TRUE;
}

void CenterWindow(HWND hWndChild, HWND hWndParent)
{
	RECT parentRect;
	RECT childRect;
	GetWindowRect(hWndParent?hWndParent:GetDesktopWindow(), &parentRect);
	GetWindowRect(hWndChild, &childRect);
	int widthParent = parentRect.right - parentRect.left;
	int heightParent = parentRect.bottom - parentRect.top;
	int widthChild = childRect.right - childRect.left;
	int heightChild = childRect.bottom - childRect.top;
	childRect.left = parentRect.left + (widthParent-widthChild)/2;
	childRect.top = parentRect.top + (heightParent-heightChild)/2;
	MoveWindow(hWndChild, childRect.left, childRect.top,
		widthChild,heightChild, TRUE);	
}

void AddCheckBox(RECT& childRect)
{
	childRect.bottom += SIZEINCREASEFORCHKBOX;
	POINT pt;
	pt.x = childRect.left;
	pt.y = childRect.bottom - SIZEINCREASEFORCHKBOX;
	ScreenToClient(hWndMsgBox, &pt);
	HFONT hFont = (HFONT)SendMessage(hWndMsgBox, WM_GETFONT, 0, 0);
	hWndChk = CreateWindow(_T("BUTTON"),_T("Show this dialog again?"),
		WS_CHILD|WS_VISIBLE|BS_AUTOCHECKBOX,
		pt.x + 7, pt.y, (childRect.right-childRect.left) - 10, 20,
		hWndMsgBox, NULL, NULL, NULL);
	SendMessage(hWndChk, WM_SETFONT, (WPARAM)hFont, 0);
	pMessageBoxManager->LastCheckState = false;
}

int CalculateStretchPercentage()
{
	HDC hDC = GetDC(hWndMsgBox);	
	HFONT hDefaultFont = (HFONT)SendMessage(hWndMsgBox, WM_GETFONT, 0, 0);
	
	TCHAR TestMessage[] = _T("ASDFGHJKLqwertyuiop123456789");

	HFONT hFontOld = (HFONT)SelectObject(hDC, hDefaultFont);
	SIZE szbefore;
	GetTextExtentPoint32(hDC,TestMessage,_tcslen(TestMessage),&szbefore);			

	SelectObject(hDC, hCustomFont);
	SIZE szafter;
	GetTextExtentPoint32(hDC,TestMessage,_tcslen(TestMessage),&szafter);

	SelectObject(hDC, hFontOld);
	ReleaseDC(hWndMsgBox, hDC);	

	return max(szafter.cx * 100 / szbefore.cx - 100,
		szafter.cy * 100 / szbefore.cy - 100);
}