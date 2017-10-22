using System;
using System.Runtime.InteropServices;

namespace ROGGamingCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int VK_NUMLOCK = 0x90;
            PressKeyboardButton(VK_NUMLOCK);
        }

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private static void PressKeyboardButton(int keyCode)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;
            keybd_event((byte)keyCode, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event((byte)keyCode, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}
