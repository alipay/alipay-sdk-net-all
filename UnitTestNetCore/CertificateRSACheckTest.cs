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
            parameters.Add("sign", "dgpopfYI2Z6MIQrHFMiBbFm2XYqHbCA6LKyeDlV2zo/UvsQ4Ni5L8EBM6QWucPhSjRR4yJQcNIjC1XK9d547W/6d+5i5wy7VBXSdnH+Mf9kU/IfPyIEKCWlT8EB7o6526p19qbnKU4EpcUQ73FljfX5cPVkjePhHaNpU5h0u0OOIKWQP+VO/0YMBM2x8y5y4kiJBmOxV1Zl7l53v2VYGBH9z75AjYRWoA0M+l06crqtYYppNbbGbq3KWQA56tdVmuqfg9kpudo8CjdX+qtfDg2TZU/UaEDQLZnyAk9u3US85eF2w7g+4RpiIAKVDySksRXyk9kit6GroUe4Zb79KBQ==");

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
            parameters.Add("sign", "hTyUiy2Y1R+jWRjejbNGvIgri5LC7MYvotjVTSOxZgchbVC674+uJqd7p0+JXQRDH+PxN0asNR9X5aa72qTqGf39XsptAdTDCAf9+QsYN0MLOLw1KPcKfnvqDsWEyrniopu+p6rtsxFzpIk1Oc2IxS7IRfaRCliO6s7xaoiqsLcxHWc0E5dnmAW5sXrc4EdzMj8Hk9It72HNYYIE4q3/8/Xn7iTQ4JuCeHtpijH9VqXE1MB9kWf0f3dP8PY8TtFZKxhMpXyjyHrbmQ2ITnBzGqzh8Zp4bpy5PWg8w/MluQmUv8H861pFfK3FjgaCM/ISR7jrIFN/34vCu7hVLd79Ng==");

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
            parameters.Add("sign", "InT5Qa2uTvOEytpp5suWulmN4UoCOCPthIJHo39OfzZcNUOa7Q9MyLda1HcfUg99AyWXQUyL6oi5X6NYJrQxKi04i6+lQbV/WZnuLB1k97ctmPB+akYqEbHLDscefbfXfhty26MYWZqPBkAIup4qJWz/eYEkeHL5Nj147WcrweEyoB8rQUgFGb+5fm5Mp1jLdpX7kXBfzK1WuwYQOvhn3a2cUI+Kn0a1krxzHyF+uKiIAlGDYFKBAtZKuoQ1OtIrrghECDn6aud3DP8ziAlV7mer7/tzhi4JcURxZDq4JnGa3gb79+A8QXrA1lPdN9XbU9N5SaVbXR6ODtiM9fjivA==");

            bool result = AlipaySignature.RSACertCheckV2(parameters, TestAccount.ProdCert.GetConfig().AppCertPath, "utf-8", "RSA2");

            Assert.AreEqual(result, true);
        }
    }
}
