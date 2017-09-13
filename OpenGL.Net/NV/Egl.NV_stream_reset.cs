
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_SUPPORT_RESET_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_reset")]
		public const int SUPPORT_RESET_NV = 0x3334;

		/// <summary>
		/// [EGL] Value of EGL_SUPPORT_REUSE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_reset")]
		public const int SUPPORT_REUSE_NV = 0x3335;

		/// <summary>
		/// [EGL] eglResetStreamNV: Binding for eglResetStreamNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_stream_reset")]
		public static bool ResetStreamNV(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglResetStreamNV != null, "peglResetStreamNV not implemented");
			retValue = Delegates.peglResetStreamNV(dpy, stream);
			LogCommand("eglResetStreamNV", retValue, dpy, stream			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_stream_reset")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglResetStreamNV(IntPtr dpy, IntPtr stream);

			[RequiredByFeature("EGL_NV_stream_reset")]
			internal static eglResetStreamNV peglResetStreamNV;

		}
	}

}
