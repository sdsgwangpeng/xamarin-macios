﻿#if !__WATCHOS__

using System;

#if XAMCORE_2_0
using Metal;
#else
using MonoTouch.Metal;
#endif

using NUnit.Framework;

namespace MonoTouchFixtures.Metal {

	[TestFixture]
	public class MTLPointerTypeTests {
		MTLPointerType ptrType = null;

		[SetUp]
		public void SetUp ()
		{
			TestRuntime.AssertXcodeVersion (9, 0);
			ptrType = new MTLPointerType ();
		}

		[TearDown]
		public void TearDown ()
		{
			if (ptrType != null)
				ptrType.Dispose ();
			ptrType = null;
		}

		[Test]
		public void GetAccessTest ()
		{
			Assert.AreEqual (MTLArgumentAccess.ReadOnly, ptrType.Access);
		}

		[Test]
		public void GetAlignmentTest ()
		{
			Assert.AreEqual (0, ptrType.Alignment);
		}

		[Test]
		public void GetDataSizeTest ()
		{
			Assert.AreEqual (0, ptrType.DataSize);
		}

		[Test]
		public void GetElementIsArgumentBufferTest ()
		{
			Assert.False (ptrType.ElementIsArgumentBuffer);
		}

		[Test]
		public void GetElementTypeTest ()
		{
			Assert.AreEqual (MTLDataType.None, ptrType.ElementType);
		}
	}
}

#endif // !__WATCHOS__
