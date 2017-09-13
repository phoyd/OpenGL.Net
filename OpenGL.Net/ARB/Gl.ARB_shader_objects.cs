
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
		/// [GL] Value of GL_PROGRAM_OBJECT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		public const int PROGRAM_OBJECT_ARB = 0x8B40;

		/// <summary>
		/// [GL] Value of GL_SHADER_OBJECT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		public const int SHADER_OBJECT_ARB = 0x8B48;

		/// <summary>
		/// [GL] Value of GL_OBJECT_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_TYPE_ARB = 0x8B4E;

		/// <summary>
		/// [GL] Value of GL_OBJECT_SUBTYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_SUBTYPE_ARB = 0x8B4F;

		/// <summary>
		/// [GL] Value of GL_OBJECT_DELETE_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_DELETE_STATUS_ARB = 0x8B80;

		/// <summary>
		/// [GL] Value of GL_OBJECT_COMPILE_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_COMPILE_STATUS_ARB = 0x8B81;

		/// <summary>
		/// [GL] Value of GL_OBJECT_LINK_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_LINK_STATUS_ARB = 0x8B82;

		/// <summary>
		/// [GL] Value of GL_OBJECT_VALIDATE_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_VALIDATE_STATUS_ARB = 0x8B83;

		/// <summary>
		/// [GL] Value of GL_OBJECT_INFO_LOG_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84;

		/// <summary>
		/// [GL] Value of GL_OBJECT_ATTACHED_OBJECTS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85;

		/// <summary>
		/// [GL] Value of GL_OBJECT_ACTIVE_UNIFORMS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86;

		/// <summary>
		/// [GL] Value of GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87;

		/// <summary>
		/// [GL] Value of GL_OBJECT_SHADER_SOURCE_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88;

		/// <summary>
		/// [GL] glDeleteObjectARB: Binding for glDeleteObjectARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void DeleteObjectARB(UInt32 obj)
		{
			Debug.Assert(Delegates.pglDeleteObjectARB != null, "pglDeleteObjectARB not implemented");
			Delegates.pglDeleteObjectARB(obj);
			LogCommand("glDeleteObjectARB", null, obj			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetHandleARB: Binding for glGetHandleARB.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static UInt32 GetHandleARB(Int32 pname)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGetHandleARB != null, "pglGetHandleARB not implemented");
			retValue = Delegates.pglGetHandleARB(pname);
			LogCommand("glGetHandleARB", retValue, pname			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glGetObjectParameterfvARB: Binding for glGetObjectParameterfvARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetObjectParameterARB(UInt32 obj, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterfvARB != null, "pglGetObjectParameterfvARB not implemented");
					Delegates.pglGetObjectParameterfvARB(obj, pname, p_params);
					LogCommand("glGetObjectParameterfvARB", null, obj, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetObjectParameterfvARB: Binding for glGetObjectParameterfvARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetObjectParameterARB(UInt32 obj, Int32 pname, out float @params)
		{
			unsafe {
				fixed (float* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterfvARB != null, "pglGetObjectParameterfvARB not implemented");
					Delegates.pglGetObjectParameterfvARB(obj, pname, p_params);
					LogCommand("glGetObjectParameterfvARB", null, obj, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetObjectParameterivARB: Binding for glGetObjectParameterivARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetObjectParameterARB(UInt32 obj, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterivARB != null, "pglGetObjectParameterivARB not implemented");
					Delegates.pglGetObjectParameterivARB(obj, pname, p_params);
					LogCommand("glGetObjectParameterivARB", null, obj, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetObjectParameterivARB: Binding for glGetObjectParameterivARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetObjectParameterARB(UInt32 obj, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterivARB != null, "pglGetObjectParameterivARB not implemented");
					Delegates.pglGetObjectParameterivARB(obj, pname, p_params);
					LogCommand("glGetObjectParameterivARB", null, obj, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetInfoLogARB: Binding for glGetInfoLogARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="maxLength">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="infoLog">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetInfoLogARB(UInt32 obj, Int32 maxLength, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetInfoLogARB != null, "pglGetInfoLogARB not implemented");
					Delegates.pglGetInfoLogARB(obj, maxLength, p_length, infoLog);
					LogCommand("glGetInfoLogARB", null, obj, maxLength, length, infoLog					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetAttachedObjectsARB: Binding for glGetAttachedObjectsARB.
		/// </summary>
		/// <param name="containerObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="obj">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetAttachedObjectARB(UInt32 containerObj, out Int32 count, [Out] UInt32[] obj)
		{
			unsafe {
				fixed (Int32* p_count = &count)
				fixed (UInt32* p_obj = obj)
				{
					Debug.Assert(Delegates.pglGetAttachedObjectsARB != null, "pglGetAttachedObjectsARB not implemented");
					Delegates.pglGetAttachedObjectsARB(containerObj, (Int32)obj.Length, p_count, p_obj);
					LogCommand("glGetAttachedObjectsARB", null, containerObj, obj.Length, count, obj					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_shader_objects")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteObjectARB(UInt32 obj);

			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glDeleteObjectARB pglDeleteObjectARB;

			[RequiredByFeature("GL_ARB_shader_objects")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGetHandleARB(Int32 pname);

			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetHandleARB pglGetHandleARB;

			[RequiredByFeature("GL_ARB_shader_objects")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectParameterfvARB(UInt32 obj, Int32 pname, float* @params);

			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetObjectParameterfvARB pglGetObjectParameterfvARB;

			[RequiredByFeature("GL_ARB_shader_objects")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectParameterivARB(UInt32 obj, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetObjectParameterivARB pglGetObjectParameterivARB;

			[RequiredByFeature("GL_ARB_shader_objects")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInfoLogARB(UInt32 obj, Int32 maxLength, Int32* length, [Out] StringBuilder infoLog);

			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetInfoLogARB pglGetInfoLogARB;

			[RequiredByFeature("GL_ARB_shader_objects")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, Int32* count, UInt32* obj);

			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetAttachedObjectsARB pglGetAttachedObjectsARB;

		}
	}

}
