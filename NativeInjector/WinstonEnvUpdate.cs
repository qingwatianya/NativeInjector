﻿using System.Runtime.InteropServices;

namespace NativeInjector
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    struct WinstonEnvUpdate
    {
        public const string SharedMemName = "WinstonEnvUpdate";

        public const string Prepend = "prepend";

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string Operation;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32767)]
        public string Path;
    }
}