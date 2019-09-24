﻿using System.Runtime.InteropServices;

using Windows.Graphics.DirectX.Direct3D11;

using QuickCapture.Interop.Win32;

using SharpDX.Direct3D11;

namespace QuickCapture.Interop
{
    internal static class Direct3D11Helper
    {
        public static IDirect3DDevice CreateDeviceFromSharpDXDevice(Device device)
        {
            var hr = NativeMethods.CreateDirect3D11DeviceFromDXGIDevice(device.NativePointer, out var pUnknown);
            if (hr != 0)
                return null;

            var rtDevice = (IDirect3DDevice) Marshal.GetObjectForIUnknown(pUnknown);
            Marshal.Release(pUnknown);

            return rtDevice;
        }
    }
}