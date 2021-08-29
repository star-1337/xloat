﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ColdWarScript
{
	public static class Mouse
	{
		private const int MOUSEEVENTF_LEFTDOWN = 0x02;
		private const int MOUSEEVENTF_LEFTUP = 0x04;
		private const int MOUSEEVENTF_MOVE = 0x0001;

		[DllImport("user32.dll")]
		static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);


		[DllImport("user32.dll")]
		private static extern ushort GetAsyncKeyState(int vKey);

		[DllImport("user32.dll")]
		static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,int dwExtraInfo);

		public static void KeyPress(byte vKeyCode = 0x22, int sleep = 95)
		{
			keybd_event(vKeyCode, 0x45, 0x1, 0);
			Thread.Sleep(sleep);
			keybd_event(vKeyCode, 0x45, 0x1 | 0x2, 0);
		}

		public static void RelativeMove(int relx, int rely)
		{
			mouse_event(0x0001, relx, rely, 0, 0);
		}

		public static bool IsKeyDown(Keys key)
		{
			return 0 != (GetAsyncKeyState((int)key) & 0x8000);
		}

		public static void MousePress()
        {
			mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
			mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
		}



	}
}