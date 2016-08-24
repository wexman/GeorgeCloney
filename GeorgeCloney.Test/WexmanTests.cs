﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgeCloney.Test
{
    [TestClass]
    public class WexmanTests
    {
        [TestMethod]
        public void bla()
        {
            BaseClass obj1 = new DerivedClass();

            var clone = obj1.DeepCloneWithoutSerialization();
        }

        public abstract class BaseClass
        {
            public string BaseMember { get; set; }
        }

        public class DerivedClass : BaseClass
        {
            public string DerivedMember { get; set; }
        }
    }
}
