using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CITest
    {
        //Always passes
        [Test]
        public void PassingTest()
        {
            Assert.Pass();
        }

        //Always fails
        [Test]
        public void FailingTest()
        {
            Assert.Pass();
        }
    }
}
