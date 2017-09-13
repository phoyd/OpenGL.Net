
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
		/// [GL] Value of GL_FILTER4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public const int FILTER4_SGIS = 0x8146;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_FILTER4_SIZE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public const int TEXTURE_FILTER4_SIZE_SGIS = 0x8147;

		/// <summary>
		/// [GL] glGetTexFilterFuncSGIS: Binding for glGetTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public static void GetTexFilterFuncSGIS(TextureTarget target, Int32 filter, [Out] float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglGetTexFilterFuncSGIS != null, "pglGetTexFilterFuncSGIS not implemented");
					Delegates.pglGetTexFilterFuncSGIS((Int32)target, filter, p_weights);
					LogCommand("glGetTexFilterFuncSGIS", null, target, filter, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexFilterFuncSGIS: Binding for glTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public static void TexFilterFuncSGIS(TextureTarget target, Int32 filter, Int32 n, float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglTexFilterFuncSGIS != null, "pglTexFilterFuncSGIS not implemented");
					Delegates.pglTexFilterFuncSGIS((Int32)target, filter, n, p_weights);
					LogCommand("glTexFilterFuncSGIS", null, target, filter, n, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexFilterFuncSGIS: Binding for glTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public static void TexFilterFuncSGIS(TextureTarget target, Int32 filter, float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglTexFilterFuncSGIS != null, "pglTexFilterFuncSGIS not implemented");
					Delegates.pglTexFilterFuncSGIS((Int32)target, filter, (Int32)weights.Length, p_weights);
					LogCommand("glTexFilterFuncSGIS", null, target, filter, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_texture_filter4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexFilterFuncSGIS(Int32 target, Int32 filter, float* weights);

			[RequiredByFeature("GL_SGIS_texture_filter4")]
			[ThreadStatic]
			internal static glGetTexFilterFuncSGIS pglGetTexFilterFuncSGIS;

			[RequiredByFeature("GL_SGIS_texture_filter4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexFilterFuncSGIS(Int32 target, Int32 filter, Int32 n, float* weights);

			[RequiredByFeature("GL_SGIS_texture_filter4")]
			[ThreadStatic]
			internal static glTexFilterFuncSGIS pglTexFilterFuncSGIS;

		}
	}

}
