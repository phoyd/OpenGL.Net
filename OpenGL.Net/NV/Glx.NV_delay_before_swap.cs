
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] glXDelayBeforeSwapNV: Binding for glXDelayBeforeSwapNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="seconds">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_delay_before_swap")]
		public static bool DelayBeforeSwapNV(IntPtr dpy, IntPtr drawable, float seconds)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXDelayBeforeSwapNV != null, "pglXDelayBeforeSwapNV not implemented");
			retValue = Delegates.pglXDelayBeforeSwapNV(dpy, drawable, seconds);
			LogCommand("glXDelayBeforeSwapNV", retValue, dpy, drawable, seconds			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_NV_delay_before_swap")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXDelayBeforeSwapNV(IntPtr dpy, IntPtr drawable, float seconds);

			[RequiredByFeature("GLX_NV_delay_before_swap")]
			internal static glXDelayBeforeSwapNV pglXDelayBeforeSwapNV;

		}
	}

}
