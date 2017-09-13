
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
		/// [GL] Value of GL_FRAGMENT_LIGHTING_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHTING_SGIX = 0x8400;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_COLOR_MATERIAL_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403;

		/// <summary>
		/// [GL] Value of GL_MAX_FRAGMENT_LIGHTS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int MAX_FRAGMENT_LIGHTS_SGIX = 0x8404;

		/// <summary>
		/// [GL] Value of GL_MAX_ACTIVE_LIGHTS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int MAX_ACTIVE_LIGHTS_SGIX = 0x8405;

		/// <summary>
		/// [GL] Value of GL_CURRENT_RASTER_NORMAL_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int CURRENT_RASTER_NORMAL_SGIX = 0x8406;

		/// <summary>
		/// [GL] Value of GL_LIGHT_ENV_MODE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int LIGHT_ENV_MODE_SGIX = 0x8407;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT0_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT0_SGIX = 0x840C;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT1_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT1_SGIX = 0x840D;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT2_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT2_SGIX = 0x840E;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT3_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT3_SGIX = 0x840F;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT4_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT4_SGIX = 0x8410;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT5_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT5_SGIX = 0x8411;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT6_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT6_SGIX = 0x8412;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_LIGHT7_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT7_SGIX = 0x8413;

		/// <summary>
		/// [GL] glFragmentColorMaterialSGIX: Binding for glFragmentColorMaterialSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentColorMaterialSGIX(MaterialFace face, MaterialParameter mode)
		{
			Debug.Assert(Delegates.pglFragmentColorMaterialSGIX != null, "pglFragmentColorMaterialSGIX not implemented");
			Delegates.pglFragmentColorMaterialSGIX((Int32)face, (Int32)mode);
			LogCommand("glFragmentColorMaterialSGIX", null, face, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentLightfSGIX: Binding for glFragmentLightfSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightSGIX(Int32 light, Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglFragmentLightfSGIX != null, "pglFragmentLightfSGIX not implemented");
			Delegates.pglFragmentLightfSGIX(light, pname, param);
			LogCommand("glFragmentLightfSGIX", null, light, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentLightfvSGIX: Binding for glFragmentLightfvSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightSGIX(Int32 light, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentLightfvSGIX != null, "pglFragmentLightfvSGIX not implemented");
					Delegates.pglFragmentLightfvSGIX(light, pname, p_params);
					LogCommand("glFragmentLightfvSGIX", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentLightiSGIX: Binding for glFragmentLightiSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightSGIX(Int32 light, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFragmentLightiSGIX != null, "pglFragmentLightiSGIX not implemented");
			Delegates.pglFragmentLightiSGIX(light, pname, param);
			LogCommand("glFragmentLightiSGIX", null, light, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentLightivSGIX: Binding for glFragmentLightivSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightSGIX(Int32 light, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentLightivSGIX != null, "pglFragmentLightivSGIX not implemented");
					Delegates.pglFragmentLightivSGIX(light, pname, p_params);
					LogCommand("glFragmentLightivSGIX", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentLightModelfSGIX: Binding for glFragmentLightModelfSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FragmentLightModelParameterSGIX"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightModelSGIX(FragmentLightModelParameterSGIX pname, float param)
		{
			Debug.Assert(Delegates.pglFragmentLightModelfSGIX != null, "pglFragmentLightModelfSGIX not implemented");
			Delegates.pglFragmentLightModelfSGIX((Int32)pname, param);
			LogCommand("glFragmentLightModelfSGIX", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentLightModelfvSGIX: Binding for glFragmentLightModelfvSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FragmentLightModelParameterSGIX"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightModelSGIX(FragmentLightModelParameterSGIX pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentLightModelfvSGIX != null, "pglFragmentLightModelfvSGIX not implemented");
					Delegates.pglFragmentLightModelfvSGIX((Int32)pname, p_params);
					LogCommand("glFragmentLightModelfvSGIX", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentLightModeliSGIX: Binding for glFragmentLightModeliSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FragmentLightModelParameterSGIX"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightModelSGIX(FragmentLightModelParameterSGIX pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFragmentLightModeliSGIX != null, "pglFragmentLightModeliSGIX not implemented");
			Delegates.pglFragmentLightModeliSGIX((Int32)pname, param);
			LogCommand("glFragmentLightModeliSGIX", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentLightModelivSGIX: Binding for glFragmentLightModelivSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FragmentLightModelParameterSGIX"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightModelSGIX(FragmentLightModelParameterSGIX pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentLightModelivSGIX != null, "pglFragmentLightModelivSGIX not implemented");
					Delegates.pglFragmentLightModelivSGIX((Int32)pname, p_params);
					LogCommand("glFragmentLightModelivSGIX", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentMaterialfSGIX: Binding for glFragmentMaterialfSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, float param)
		{
			Debug.Assert(Delegates.pglFragmentMaterialfSGIX != null, "pglFragmentMaterialfSGIX not implemented");
			Delegates.pglFragmentMaterialfSGIX((Int32)face, (Int32)pname, param);
			LogCommand("glFragmentMaterialfSGIX", null, face, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentMaterialfvSGIX: Binding for glFragmentMaterialfvSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentMaterialfvSGIX != null, "pglFragmentMaterialfvSGIX not implemented");
					Delegates.pglFragmentMaterialfvSGIX((Int32)face, (Int32)pname, p_params);
					LogCommand("glFragmentMaterialfvSGIX", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentMaterialiSGIX: Binding for glFragmentMaterialiSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFragmentMaterialiSGIX != null, "pglFragmentMaterialiSGIX not implemented");
			Delegates.pglFragmentMaterialiSGIX((Int32)face, (Int32)pname, param);
			LogCommand("glFragmentMaterialiSGIX", null, face, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFragmentMaterialivSGIX: Binding for glFragmentMaterialivSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentMaterialivSGIX != null, "pglFragmentMaterialivSGIX not implemented");
					Delegates.pglFragmentMaterialivSGIX((Int32)face, (Int32)pname, p_params);
					LogCommand("glFragmentMaterialivSGIX", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetFragmentLightfvSGIX: Binding for glGetFragmentLightfvSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void GetFragmentLightSGIX(Int32 light, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFragmentLightfvSGIX != null, "pglGetFragmentLightfvSGIX not implemented");
					Delegates.pglGetFragmentLightfvSGIX(light, pname, p_params);
					LogCommand("glGetFragmentLightfvSGIX", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetFragmentLightivSGIX: Binding for glGetFragmentLightivSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void GetFragmentLightSGIX(Int32 light, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFragmentLightivSGIX != null, "pglGetFragmentLightivSGIX not implemented");
					Delegates.pglGetFragmentLightivSGIX(light, pname, p_params);
					LogCommand("glGetFragmentLightivSGIX", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetFragmentMaterialfvSGIX: Binding for glGetFragmentMaterialfvSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void GetFragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFragmentMaterialfvSGIX != null, "pglGetFragmentMaterialfvSGIX not implemented");
					Delegates.pglGetFragmentMaterialfvSGIX((Int32)face, (Int32)pname, p_params);
					LogCommand("glGetFragmentMaterialfvSGIX", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetFragmentMaterialivSGIX: Binding for glGetFragmentMaterialivSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void GetFragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFragmentMaterialivSGIX != null, "pglGetFragmentMaterialivSGIX not implemented");
					Delegates.pglGetFragmentMaterialivSGIX((Int32)face, (Int32)pname, p_params);
					LogCommand("glGetFragmentMaterialivSGIX", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glLightEnviSGIX: Binding for glLightEnviSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:LightEnvParameterSGIX"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void LightEnvSGIX(LightEnvParameterSGIX pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLightEnviSGIX != null, "pglLightEnviSGIX not implemented");
			Delegates.pglLightEnviSGIX((Int32)pname, param);
			LogCommand("glLightEnviSGIX", null, pname, param			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentColorMaterialSGIX(Int32 face, Int32 mode);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentColorMaterialSGIX pglFragmentColorMaterialSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentLightfSGIX(Int32 light, Int32 pname, float param);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentLightfSGIX pglFragmentLightfSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentLightfvSGIX(Int32 light, Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentLightfvSGIX pglFragmentLightfvSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentLightiSGIX(Int32 light, Int32 pname, Int32 param);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentLightiSGIX pglFragmentLightiSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentLightivSGIX(Int32 light, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentLightivSGIX pglFragmentLightivSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentLightModelfSGIX(Int32 pname, float param);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentLightModelfSGIX pglFragmentLightModelfSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentLightModelfvSGIX(Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentLightModelfvSGIX pglFragmentLightModelfvSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentLightModeliSGIX(Int32 pname, Int32 param);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentLightModeliSGIX pglFragmentLightModeliSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentLightModelivSGIX(Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentLightModelivSGIX pglFragmentLightModelivSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentMaterialfSGIX(Int32 face, Int32 pname, float param);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentMaterialfSGIX pglFragmentMaterialfSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentMaterialfvSGIX(Int32 face, Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentMaterialfvSGIX pglFragmentMaterialfvSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentMaterialiSGIX(Int32 face, Int32 pname, Int32 param);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentMaterialiSGIX pglFragmentMaterialiSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentMaterialivSGIX(Int32 face, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glFragmentMaterialivSGIX pglFragmentMaterialivSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFragmentLightfvSGIX(Int32 light, Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glGetFragmentLightfvSGIX pglGetFragmentLightfvSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFragmentLightivSGIX(Int32 light, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glGetFragmentLightivSGIX pglGetFragmentLightivSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFragmentMaterialfvSGIX(Int32 face, Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glGetFragmentMaterialfvSGIX pglGetFragmentMaterialfvSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFragmentMaterialivSGIX(Int32 face, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glGetFragmentMaterialivSGIX pglGetFragmentMaterialivSGIX;

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightEnviSGIX(Int32 pname, Int32 param);

			[RequiredByFeature("GL_SGIX_fragment_lighting")]
			[ThreadStatic]
			internal static glLightEnviSGIX pglLightEnviSGIX;

		}
	}

}
