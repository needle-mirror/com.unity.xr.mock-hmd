using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Assert = UnityEngine.Assertions.Assert;

namespace Unity.XR.MockHMD.Editor.Tests
{
    class EditorTests {

        [Test]
        public void SimplePasses() {
            Assert.IsTrue(true);
        }

        [UnityTest]
        public IEnumerator WithEnumeratorPasses() {
            yield return null;
        }
    }
}
