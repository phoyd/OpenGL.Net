﻿
using Android.App;
using Android.OS;

using OpenGL;
using OpenGL.Objects;
using OpenGL.Objects.Scene;
using OpenGL.Objects.State;

namespace HelloObjects_monodroid
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// Debugging:
	/// --setenv:OPENGL_NET_GL_STATIC_INIT=NO  --setenv:OPENGL_NET_EGL_STATIC_INIT=NO
	/// </remarks>
	[Activity(Label = "HelloObjects_monodroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			// Base implementation
			base.OnCreate(bundle);

			// Load layout
			SetContentView(Resource.Layout.Main);

			// Setup GL view
			GLSurfaceView glSurface = FindViewById<GLSurfaceView>(Resource.Id.GLSurface);

			glSurface.ContextCreated += GlSurface_ContextCreated;
			glSurface.ContextDestroying += GlSurface_ContextDestroying;
			glSurface.Render += GlSurface_Render;
		}

		private void GlSurface_ContextCreated(object sender, GLSurfaceViewEventArgs e)
		{
			// Wrap GL context with GraphicsContext
			_Context = new GraphicsContext(e.DeviceContext, e.RenderContext);

			_CubeScene = new SceneGraph();
			_CubeScene.SceneRoot = new SceneObjectGeometry();
			_CubeScene.SceneRoot.ObjectState.DefineState(new DepthTestState(DepthFunction.Less));

			_CubeScene.CurrentView = new SceneObjectCamera();
			_CubeScene.SceneRoot.Link(_CubeScene.CurrentView);

			_CubeScene.Create(_Context);

			Gl.ClearColor(0.1f, 0.1f, 0.1f, 0.0f);
		}

		private void GlSurface_Render(object sender, GLSurfaceViewEventArgs e)
		{
			GLSurfaceView senderControl = (GLSurfaceView)sender;
			float senderAspectRatio = (float)senderControl.Width / senderControl.Height;

			// Clear
			Gl.Viewport(0, 0, senderControl.Width, senderControl.Height);
			Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

			_CubeScene.Draw(_Context);
		}

		private void GlSurface_ContextDestroying(object sender, GLSurfaceViewEventArgs e)
		{
			_CubeScene.Dispose();
			_Context.Dispose();
		}

		/// <summary>
		/// The GL context.
		/// </summary>
		private GraphicsContext _Context;

		/// <summary>
		/// Scene drawn on screen.
		/// </summary>
		private SceneGraph _CubeScene;
	}
}
