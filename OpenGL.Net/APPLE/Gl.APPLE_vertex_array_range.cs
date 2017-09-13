
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
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_APPLE = 0x851D;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_STORAGE_HINT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_POINTER_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521;

		/// <summary>
		/// [GL] Value of GL_STORAGE_CLIENT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int STORAGE_CLIENT_APPLE = 0x85B4;

		/// <summary>
		/// [GL] Value of GL_STORAGE_CACHED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int STORAGE_CACHED_APPLE = 0x85BE;

		/// <summary>
		/// [GL] Value of GL_STORAGE_SHARED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int STORAGE_SHARED_APPLE = 0x85BF;

		/// <summary>
		/// [GL] glVertexArrayRangeAPPLE: Binding for glVertexArrayRangeAPPLE.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public static void VertexArrayRangeAPPLE(Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexArrayRangeAPPLE != null, "pglVertexArrayRangeAPPLE not implemented");
			Delegates.pglVertexArrayRangeAPPLE(length, pointer);
			LogCommand("glVertexArrayRangeAPPLE", null, length, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFlushVertexArrayRangeAPPLE: Binding for glFlushVertexArrayRangeAPPLE.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public static void FlushVertexArrayRangeAPPLE(Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglFlushVertexArrayRangeAPPLE != null, "pglFlushVertexArrayRangeAPPLE not implemented");
			Delegates.pglFlushVertexArrayRangeAPPLE(length, pointer);
			LogCommand("glFlushVertexArrayRangeAPPLE", null, length, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexArrayParameteriAPPLE: Binding for glVertexArrayParameteriAPPLE.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public static void VertexArrayParameterAPPLE(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglVertexArrayParameteriAPPLE != null, "pglVertexArrayParameteriAPPLE not implemented");
			Delegates.pglVertexArrayParameteriAPPLE(pname, param);
			LogCommand("glVertexArrayParameteriAPPLE", null, pname, param			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			[ThreadStatic]
			internal static glVertexArrayRangeAPPLE pglVertexArrayRangeAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFlushVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			[ThreadStatic]
			internal static glFlushVertexArrayRangeAPPLE pglFlushVertexArrayRangeAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayParameteriAPPLE(Int32 pname, Int32 param);

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			[ThreadStatic]
			internal static glVertexArrayParameteriAPPLE pglVertexArrayParameteriAPPLE;

		}
	}

}
