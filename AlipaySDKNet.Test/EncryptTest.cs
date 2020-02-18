using NUnit.Framework;
using Aop.Api.Util;
using System;

namespace Test
{

    [TestFixture()]
    public class EncryptTest
    {

        [Test()]
        public void should_get_correct_chipertext()
        {
            String chipertext = AlipayEncrypt.AesEncrypt("aa4BtZ4tspm2wnXLb1ThQA==", "test1234567", "utf-8");
            Assert.AreEqual(chipertext, "ILpoMowjIQjfYMR847rnFQ==");
        }

        [Test()]
        public void should_get_correct_plaintext()
        {
            String plaintext = AlipayEncrypt.AesDencrypt("aa4BtZ4tspm2wnXLb1ThQA==", "ILpoMowjIQjfYMR847rnFQ==", "utf-8");
            Assert.AreEqual(plaintext, "test1234567");
        }
    }
}
