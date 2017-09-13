
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] glMultiModeDrawArraysIBM: Binding for glMultiModeDrawArraysIBM.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="modestride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
		public static void MultiModeDrawArraysIBM(Int32[] mode, Int32[] first, Int32[] count, Int32 primcount, Int32 modestride)
		{
			unsafe {
				fixed (Int32* p_mode = mode)
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiModeDrawArraysIBM != null, "pglMultiModeDrawArraysIBM not implemented");
					Delegates.pglMultiModeDrawArraysIBM(p_mode, p_first, p_count, primcount, modestride);
					LogCommand("glMultiModeDrawArraysIBM", null, mode, first, count, primcount, modestride					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiModeDrawElementsIBM: Binding for glMultiModeDrawElementsIBM.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:DrawElementsType"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="modestride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
		public static void MultiModeDrawElementsIBM(Int32[] mode, Int32[] count, DrawElementsType type, IntPtr[] indices, Int32 primcount, Int32 modestride)
		{
			unsafe {
				fixed (Int32* p_mode = mode)
				fixed (Int32* p_count = count)
				fixed (IntPtr* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMultiModeDrawElementsIBM != null, "pglMultiModeDrawElementsIBM not implemented");
					Delegates.pglMultiModeDrawElementsIBM(p_mode, p_count, (Int32)type, p_indices, primcount, modestride);
					LogCommand("glMultiModeDrawElementsIBM", null, mode, count, type, indices, primcount, modestride					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiModeDrawArraysIBM(Int32* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);

			[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
			[ThreadStatic]
			internal static glMultiModeDrawArraysIBM pglMultiModeDrawArraysIBM;

			[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiModeDrawElementsIBM(Int32* mode, Int32* count, Int32 type, IntPtr* indices, Int32 primcount, Int32 modestride);

			[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
			[ThreadStatic]
			internal static glMultiModeDrawElementsIBM pglMultiModeDrawElementsIBM;

		}
	}

}
