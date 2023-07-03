using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locker {
    // https://stackoverflow.com/questions/3213606/how-to-suppress-task-switch-keys-winkey-alt-tab-alt-esc-ctrl-esc-using-low
    // Prevents tabbing out and the like

    internal class SwitchSuppress {
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyInfo {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        //System level functions to be used for hook and unhook keyboard input  
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);

        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;

        // Singleton instance of suppressor
        public static SwitchSuppress switchSuppress = new SwitchSuppress();

        private IntPtr CaptureKey(int nCode, IntPtr wp, IntPtr lp) {
            if (nCode >= 0) {
                KeyInfo objKeyInfo = (KeyInfo)Marshal.PtrToStructure(lp, typeof(KeyInfo));

                // Disabling Windows keys 

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || (objKeyInfo.key == Keys.Escape || objKeyInfo.key == Keys.F4) && (Keys.Modifiers & Keys.Control) == Keys.Control) {
                    return (IntPtr)1; // if 0 is returned then All the above keys will be enabled
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        private bool HasAltModifier(int flags) {
            return (flags & 0x20) == 0x20;
        }

        internal void LoadSuppressor() {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(CaptureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
        }
    }
}
