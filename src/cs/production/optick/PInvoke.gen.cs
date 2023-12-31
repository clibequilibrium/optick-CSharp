
// <auto-generated>
//  This code was generated by the following tool on 2023-07-30 21:33:00 GMT-04:00:
//      https://github.com/bottlenoselabs/c2cs (v6.1.2.0)
//
//  Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ReSharper disable All

#region Template
#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS8981
using bottlenoselabs.C2CS.Runtime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
#endregion

namespace Optick;

public static unsafe partial class PInvoke
{
    private const string LibraryName = "OptickCore";

    #region API

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_AttachTag_Float")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIAttachTagFloat(ulong inEventDescription, float inValue);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_AttachTag_Int32")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIAttachTagInt32(ulong inEventDescription, int inValue);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_AttachTag_Point")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIAttachTagPoint(ulong inEventDescription, float x, float y, float z);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_AttachTag_String")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIAttachTagString(ulong inEventDescription, CString inValue, ushort intValueLength);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_AttachTag_UInt32")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIAttachTagUInt32(ulong inEventDescription, uint inValue);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_AttachTag_UInt64")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIAttachTagUInt64(ulong inEventDescription, ulong inValue);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_CreateEventDescription")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial ulong OptickAPICreateEventDescription(CString inFunctionName, ushort inFunctionLength, CString inFileName, ushort inFileNameLenght, uint inFileLine);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_NextFrame")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPINextFrame();

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_PopEvent")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIPopEvent(ulong inEventData);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_PushEvent")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial ulong OptickAPIPushEvent(ulong inEventDescription);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_RegisterThread")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIRegisterThread(CString inThreadName, ushort inThreadNameLength);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_StartCapture")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIStartCapture();

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "OptickAPI_StopCapture")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void OptickAPIStopCapture(CString inFileName, ushort inFileNameLength);

    #endregion

    #region Types

    [CNode(Kind = "MacroObject")]
    public const int OptickEnableGpu = 1;

    [CNode(Kind = "MacroObject")]
    public const int OptickEnableGpuD3d12 = 1;

    [CNode(Kind = "MacroObject")]
    public const int OptickEnableGpuVulkan = 1;

    [CNode(Kind = "MacroObject")]
    public const int OptickEnableTracing = 1;

    [CNode(Kind = "MacroObject")]
    public const int UseOptick = 1;

    #endregion
}
