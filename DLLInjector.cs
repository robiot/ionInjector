using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ionInjectorZ
{
    internal class DLLInjection
    {
        public enum DllInjectionResult
        {
            DllNotFound,
            GameProcessNotFound,
            InjectionFailed,
            Success,
        }

        public sealed class DllInjector
        {
            private static readonly IntPtr INTPTR_ZERO = (IntPtr)0;
            private static DLLInjection.DllInjector _instance;

            public static DLLInjection.DllInjector GetInstance
            {
                get
                {
                    if (DLLInjection.DllInjector._instance == null)
                        DLLInjection.DllInjector._instance = new DLLInjection.DllInjector();
                    return DLLInjection.DllInjector._instance;
                }
            }

            private DllInjector()
            {
            }

            private bool bInject(uint pToBeInjected, string sDllPath)
            {
                IntPtr num1 = DLLInjection.DllInjector.OpenProcess(1082U, 1, pToBeInjected);
                if (num1 == DLLInjection.DllInjector.INTPTR_ZERO)
                    return false;
                IntPtr procAddress = DLLInjection.DllInjector.GetProcAddress(DLLInjection.DllInjector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
                if (procAddress == DLLInjection.DllInjector.INTPTR_ZERO)
                    return false;
                IntPtr num2 = DLLInjection.DllInjector.VirtualAllocEx(num1, (IntPtr)0, (IntPtr)sDllPath.Length, 12288U, 64U);
                if (num2 == DLLInjection.DllInjector.INTPTR_ZERO)
                    return false;
                byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
                if (DLLInjection.DllInjector.WriteProcessMemory(num1, num2, bytes, (uint)bytes.Length, 0) == 0 || DLLInjection.DllInjector.CreateRemoteThread(num1, (IntPtr)0, DLLInjection.DllInjector.INTPTR_ZERO, procAddress, num2, 0U, (IntPtr)0) == DLLInjection.DllInjector.INTPTR_ZERO)
                    return false;
                DLLInjection.DllInjector.CloseHandle(num1);
                return true;
            }

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern int CloseHandle(IntPtr hObject);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr CreateRemoteThread(
              IntPtr hProcess,
              IntPtr lpThreadAttribute,
              IntPtr dwStackSize,
              IntPtr lpStartAddress,
              IntPtr lpParameter,
              uint dwCreationFlags,
              IntPtr lpThreadId);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

            public DLLInjection.DllInjectionResult Inject(string sProcName, string sDllPath)
            {
                if (!File.Exists(sDllPath))
                    return DLLInjection.DllInjectionResult.DllNotFound;
                uint pToBeInjected = 0;
                Process[] processes = Process.GetProcesses();
                for (int index = 0; index < processes.Length; ++index)
                {
                    if (!(processes[index].ProcessName != sProcName))
                    {
                        pToBeInjected = (uint)processes[index].Id;
                        break;
                    }
                }
                if (pToBeInjected == 0U)
                    return DLLInjection.DllInjectionResult.GameProcessNotFound;
                return !this.bInject(pToBeInjected, sDllPath) ? DLLInjection.DllInjectionResult.InjectionFailed : DLLInjection.DllInjectionResult.Success;
            }

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr OpenProcess(
              uint dwDesiredAccess,
              int bInheritHandle,
              uint dwProcessId);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr VirtualAllocEx(
              IntPtr hProcess,
              IntPtr lpAddress,
              IntPtr dwSize,
              uint flAllocationType,
              uint flProtect);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern int WriteProcessMemory(
              IntPtr hProcess,
              IntPtr lpBaseAddress,
              byte[] buffer,
              uint size,
              int lpNumberOfBytesWritten);
        }
    }
}