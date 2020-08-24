using System;
using Aop.Api;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    public static class TestAccount
    {
        public const string NotSetKeyAppId = "2019092567661029";

        public static class Mock
        {
            public static readonly String AppPrivateKey = GetPrivateKey("Mock");
            public const String AppPublicKey = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAgyfCUS7eDw4+ce4wGTvfXcJd1QXg79r+eeRWTFJako9Hu2pjY3f8k36vBW3n9usMPnQNaCoXvskqIogYfD1q3fvRhkdwa+i7lVZ2o3hb41a4BRr9tleIGj9Wshi1MbKarkcCvHFA2cWUGW+KXxffeIJ7qB28w3QjWLj2+WHoQ8K1Ll0jachKA8DCRYVs7Pfy4Yh8woUbI3LpMD6L81Mvcle319/9F72UKI+uXq6tVzwUZlh3UacRszD20XtWU6CiPWnqXV94k1euwCD52DTnS0FI4QdlOjKi1BlBlAdRKYxRj2Y55u7ADaDwPyyAs2kAoDOu4tIJInaZXzyxYzFmewIDAQAB";
            public static readonly String AppPrivateKeyFile = TestAccount.GetSolutionBasePath() + "/UnitTestNetCore/Fixture/mock-RSA-private.pem";
            public static readonly String AppPublicKeyFile = TestAccount.GetSolutionBasePath() + "/UnitTestNetCore/Fixture/mock-RSA-public.pem";
        }

        public static class Sandbox
        {
            public const String Gateway = "https://openapi.alipaydev.com/gateway.do";
            public const String AlipayPublicKey = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAohmWF9HXjI3VRxrKbuZq4YK6lIFAIzUZ4xvY4iw2zwYiblPkB0FWbqxouyyB9nmAyK+hN/5tyXatpskcy6rO6zJl3kfdog0lRA7g06+YpdHVHhu/bXfaz+BfCA3YHwjkBQffMa8Amwy6JZF6aDiXDdYP/YWKmFk1t4K6F1853EDf2vYsT6AsVYRk2xkw+fx3/qIWaidHETjNBnOOPRG68hLf0H0DCeEOsLp3mFox2LARRQol5IfV45nNq2a2zb6ubwZbgXypZM3vfLQekUaxAaC1Vuu4gYWxPRCzHE1e6aQpEuacVVYCnjNURvDmDpT7oMzh+HtN0DKCe6yOHRDZ3QIDAQAB";
            public const String AppId = "2016102200737202";
            public static readonly String AppPrivateKey = GetPrivateKey("Sandbox");
            public const String AesKey = "RrAdgyCsnkoE1a9A8cW72w==";
        }

        public static class ProdCert
        {
            public const String Gateway = "https://openapi.alipay.com/gateway.do";
            public const String AppId = "2019090366875133";
            public static readonly String AppPrivateKey = GetPrivateKey("ProdCert");
            public static CertParams CertParams = new CertParams
            {
                AlipayPublicCertPath = GetSolutionBasePath() + "/UnitTestNetCore/Fixture/alipayCertPublicKey_RSA2.crt",
                AppCertPath = GetSolutionBasePath() + "/UnitTestNetCore/Fixture/appCertPublicKey_2019090366875133.crt",
                RootCertPath = GetSolutionBasePath() + "/UnitTestNetCore/Fixture/alipayRootCert.crt"
            };
        }

        public static class DevSpi
        {
            public const String Gateway = "http://openapi.stable.dl.alipaydev.com/gateway.do";
            public const String AlipayPublicKey = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAysWfHt8zhqB4ImyYAtEQFMBT66psQHuayw12/qpzSCjKRB0UZRjtUHd8vr4ruvo2PzH0f/rqivqNXKDlb0Z6NQDFnW78Ul9DQ4cfAZU366aQ/e0iDF1pe1B1CAEm1jFVdxlUc16zIrjUrDSQpggqCv8hmeDWIr6obxX+rpQs5kPy2Kdj6nM1T3lW4NsptVfeVnzxupAW6kQDkBEu20mniDpi0KxuiFktuWWooHV77x5WotsBBOXnH6JPM+hFxdwO0QXtrnZZqFcopZ59GTNE+k0MvxUX1wtPAr5caLl6zE6YehoHdc7ieQzrWxCeiwgftGnQgA50a/YCmi6BToMNnwIDAQAB";
            public const String AppId = "2021000129658123";
            public const String AppPublicKey = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAhHib4vPseQQs4we0medk3nuTH3cOaY70C84TDcQJcIPgJ7sntRp3+HFy+5v3PQwyNWBH6AH5Kw+PnehlVI9D/E+2Gj9LrxJnK+WbrfTXSxNJoo6jM6Ol2lxVfm2Um/WN+v1Ctoz9Ec1evjU1kVWaOsLKBd4cV099JvrDHL7EnXGzYxZW3SZuDkSmSSTptssgfnJRbL8codclRYuN1w7HuCZLXK44je95Kf3WV0AApVn4BapgFR5e6MEf6573xNVqjMX1E+ahYU649OCmRUyMF3HoTMOsllsKWcgnrKb4mj79w67k/fqjGr5IqQhJiCWK/imHIUQdDQR0B9ALyHaqiQIDAQAB";
            public static readonly String AppPrivateKey = GetPrivateKey("DevSpi");
        }

        public static class DevSM2
        {
            public const String Gateway = "http://openapi-ztt-1.gz00b.dev.alipay.net/gateway.do";
            public const String AppId = "2021000146614327";
            public static readonly String AppPrivateKey = GetPrivateKey("DevSM2");
            public const String AlipayPublicKey = @"MFkwEwYHKoZIzj0CAQYIKoEcz1UBgi0DQgAE7oZrr9paKyUq9zbFwoqNKJ0kr+w5/AszLFPm738GZksKQmIqBHlbuR6yXQ25tQlhL/L28f536re3UkLsDhVcdA==";
        }

        public static class DevSM2Cert
        {
            public const String Gateway = "http://openapi-ztt-1.gz00b.dev.alipay.net/gateway.do";
            public const String AppId = "2021000146613340";
            public static readonly String AppPrivateKey = GetPrivateKey("DevSM2Cert");
            public static CertParams CertParams = new CertParams
            {

                AlipayPublicCertPath = TestAccount.GetSolutionBasePath() + "/UnitTestNetCore/Fixture/SM2/alipayCertPublicKey_SM2.crt",
                AppCertPath = TestAccount.GetSolutionBasePath() + "/UnitTestNetCore/Fixture/SM2/appCertPublicKey_2021000146613340.crt",
                RootCertPath = TestAccount.GetSolutionBasePath() + "/UnitTestNetCore/Fixture/SM2/alipayRootCert.crt"
            };
        }

        public static string GetSolutionBasePath()
        {
            string current = Directory.GetCurrentDirectory();
            do
            {
                current = Directory.GetParent(current).ToString();
            }
            while (!current.EndsWith("bin", StringComparison.Ordinal));
            return current + "/../..";
        }

        /// <summary>
        /// 从文件中读取私钥
        /// 注意：实际开发过程中，请务必注意不要将私钥信息配置在源码中（比如配置为常量或储存在配置文件的某个字段中等），因为私钥的保密等级往往比源码高得多，将会增加私钥泄露的风险。推荐将私钥信息储存在专用的私钥文件中，
        /// 将私钥文件通过安全的流程分发到服务器的安全储存区域上，仅供自己的应用运行时读取。
        /// 此处为了单元测试执行的环境普适性，私钥文件随源码一起，实际过程中请不要这样做。
        /// </summary>
        /// <param name="key">私钥的Key</param>
        /// <returns>私钥字符串</returns>
        private static string GetPrivateKey(String key)
        {
            IDictionary<string, string> json = JsonConvert.DeserializeObject<IDictionary<string, string>>(
                File.ReadAllText(GetSolutionBasePath() + "/UnitTestNetCore/Fixture/privateKey.json"));
            return json[key];
        }
    }
}
