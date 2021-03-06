//
// SCNSceneRenderer.cs
//
// Authors:
//   Rolf Bjarne Kvinge <rolf@xamarin.com>
//
// Copyright 2015 Xamarin Inc. All rights reserved.
//

using System;
using System.Runtime.InteropServices;

using XamCore.ObjCRuntime;
using XamCore.Foundation;
using XamCore.CoreGraphics;

namespace XamCore.SceneKit {

#if !XAMCORE_3_0
	public static partial class SCNSceneRenderer_Extensions {
		public static SCNHitTestResult[] HitTest (ISCNSceneRenderer This, CGPoint thePoint, SCNHitTestOptions options)
		{
			return This.HitTest (thePoint, options == null ? null : options.Dictionary);
		}
	}
#endif
}
