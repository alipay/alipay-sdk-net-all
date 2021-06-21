using NUnit.Framework;
using Aop.Api.Util;
using System;
using System.Collections.Generic;

namespace Test
{
    /// <summary>
    /// 注意：本单元测试中使用的是商户私钥（因为拿不到支付宝私钥）签名后的参数进行测试，所以验签时指定的是商户的公钥证书。
    /// 实际使用RSACheck系列函数时，应该是指定支付宝公钥证书，对支付宝私钥签名后的参数进行验签
    /// </summary>
    [TestFixture()]
    public class CertificateRSACheckTest
    {

        [Test()]
        public void should_pass_rsa_check_when_sign_type_is_rsa()
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters.Add("method", "koubei.marketing.data.indicator.query");
            parameters.Add("app_id", "2019090366875133");
            parameters.Add("sign_type", "RSA");
            parameters.Add("sign", "jzUcBt9ZqDWNGg1rzAjqJFPLdvMs7icKUNb27O8xXH2bUtRiEtzwOkJl4VMZNIE0dWJNF9KauImnKf44U33ly1pxcYxg0gcM9C0i65NzvLu+1zoTNWUkIS/iHC4c0lNlAbyLJyhc35mc/6ISXfZcDDd3kkzrGHAliU5PhjbpPSRlBDZfyC4XpREQgwUnxpPRra6NM6vKIhCLkmt3u/DvnL8K2AmZkQk0mtfV7s7B3RFReJlM88mEhvhgOf+B13SDv8p0lBFFnrk2CAmFbZCCXQJdmxiC0D6wSzY4yLBqWggHQlmaMJ0fV3mCZDVEB1gMo0OfJi/0PG/eeZXN/sa2Ag==");

            bool result = AlipaySignature.RSACertCheckV2(parameters, TestAccount.ProdCert.GetConfig().AppCertPath, "utf-8", "RSA");

            Assert.AreEqual(result, true);
        }

        [Test()]
        public void should_pass_rsa_check_when_sign_type_is_rsa2()
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters.Add("method", "koubei.marketing.data.indicator.query");
            parameters.Add("app_id", "2019090366875133");
            parameters.Add("sign_type", "RSA2");
            parameters.Add("sign", "f032wwnTFj2klLz3xRM1tr/6JUiJkXIE4Rm0iBVZRQqDSRhv2nRBiykH+dRSie0MImuwuRMHwLdDHRD9MyeBp/vmmLjH08YtpUQXoEE7OUkbBM/grQDo5XoiKWj+CjF+kWagEc4L3nKahAYEIXQS086Jd7gJ0264kpKQ2GH4ric+X35+kX5qI6wnOUNeut5VqWvL1e+a8+Hy9EWqP4+YIY+nQEB3u4FOjjpT7knFdLnM6yJQZDSBYGdmoHlFGXLh0KbtHVp4QpG3jlzngiMZvyBBcuhZnssV+8tZtzJMMhEarvn7vYwvBfaIrt0c/GQrddOKsYfEvNf3DLktd7+KUA==");

            bool result = AlipaySignature.RSACertCheckV2(parameters, TestAccount.ProdCert.GetConfig().AppCertPath, "utf-8", "RSA2");

            Assert.AreEqual(result, true);
        }

        [Test()]
        public void should_pass_rsa_check_when_charset_is_utf8()
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters.Add("method", "koubei.marketing.data.indicator.query");
            parameters.Add("app_id", "2019090366875133");
            parameters.Add("extra", "中文测试");
            parameters.Add("sign_type", "RSA2");
            parameters.Add("sign", "dnjqgT/7DWQyGw+KfXa/0kZaFrrsipN9MSDP5lBWm9AB+OjmkZkl4qkKfpzHQo4z786lK2sjmSMviT9I89BM7E5nAh/Q371sc6Q8vjXn+n6bSjLqnzceSAqlJwUWGmFN5UZXins5OexYyeTp1bvfKk+GdWYrA6UUOw0Uo2YEZAX49Y+z0gGZl0knnDEPkGIVXY2G8v+BUU2U64I3DM5Ihd11sgEtXcI5Rop28wbTTEIVhl08gmmA1Jngs2v+yXE4mgtQdZJzaUAleew/xipfOas72xNZk+qkkIOPBGOBLzH9L22A3muX9aO0S+FD+lipfltawtt2ENr4vAtghXYwIQ==");

            bool result = AlipaySignature.RSACertCheckV2(parameters, TestAccount.ProdCert.GetConfig().AppCertPath, "utf-8", "RSA2");

            Assert.AreEqual(result, true);
        }
    }
}
