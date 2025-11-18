using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Assert = UnityEngine.Assertions.Assert;

namespace Unity.XR.MockHMD.Tests
{
    class RuntimeTests {

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
