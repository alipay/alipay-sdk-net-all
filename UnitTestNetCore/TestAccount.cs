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

        public static class Sandbox
        {
            public const String Gateway = "https://openapi.alipaydev.com/gateway.do";
            public const String AlipayPublicKey = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAnAUxtW3XiajFkyIpf0psiSorGpVGTWAEkbOGcJXtgoVUr42wBsbGI91X0z9tlMubrjb/rsi4b9A1plS4L6SkbB6/jplDbCE5WY5LPb9MsbBNYgHxL4RCL5NLvSM0W19iOq5jkj4tJtjn7+EOUSLHsSLqtu7HIlvN/prxOYNj8RdXhUKRyzqNXnLZYdbWoiyzKfF2Epdp4It/cSjHsODu1+WqSHU1xqpTyh4tHASDFpNK0pOaPjGJl7HR0O/BLQjwIRdxk3OmrSPb5cTn7q2z+hK4O3Dh8qK606KDMReveZN0uOvS2CuH62nxZKoEJmujR7vEY0lHk/xgv0TqKXpt4QIDAQAB";
            public const String AppId = "2016092700607517";
            public const String AppPublicKey = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtQ6pOPm4pt87Ha7AGtMCUM8gv/I0L740taQsL5RA724qSLhkTzf4jeVjW9kiIGJnqUKvPMZEpCTAbuLfMTMAlYbwxqjCRcXIwHx0C1NxSdh2oK5vI0HS1+Qk1JUZxyZKMUNMmQ9sbD7NUyTk0lXmKgGbUGHle0cAF3jiHygT2lBcWagO83kT79B84jWU8u8EZju6gyj5nnC38cKw5F9eSxVyZU/s3xFhjwOJp3GHfDPxt213hv4QOD4M+2DoTuJRxKYsdYdjxpCsprBb2LXQeXxmVvJqyKDJ8UwFRLxv1li3UiVr3pqEC3nQzD3YAUMbl8PY33f3ZdQSiJ2qmyvEZwIDAQAB";
            public static readonly String AppPrivateKey = GetPrivateKey("Sandbox");
            public static readonly String AppPrivateKeyFile = GetSolutionBasePath() + "/UnitTestNetCore/Fixture/aop-sandbox-RSA-private.pem";
            public static readonly String AppPublicKeyFile = GetSolutionBasePath() + "/UnitTestNetCore/Fixture/aop-sandbox-RSA-public.pem";
            public const String Pid = "2088102177492087";
            public const String AesKey = "hNtPqVWeuUeEpw9ksTZ92A==";
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
