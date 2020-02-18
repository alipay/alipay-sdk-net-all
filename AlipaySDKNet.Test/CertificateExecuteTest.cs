using NUnit.Framework;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Domain;

namespace Test
{
    [TestFixture()]
    public class CertificatExecuteTest
    {
        [Test()]
        public void should_return_correct_response()
        {
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.ProdCert.AppId,
                TestAccount.ProdCert.AppPrivateKey, "json", "1.0", "RSA2", "utf-8", false, TestAccount.ProdCert.CertParams);
            AlipayOpenOperationOpenbizmockBizQueryRequest request = GetRequest();

            AlipayOpenOperationOpenbizmockBizQueryResponse response = client.CertificateExecute(request);

            Assert.AreEqual(response.IsError, false);
            Assert.AreEqual(response.Code, "10000");
        }

        //TODO:待相关依赖上线后替换为线上环境测试
        public void should_return_correct_response_when_use_sm2()
        {
            IAopClient client = new DefaultAopClient(TestAccount.DevSM2Cert.Gateway, TestAccount.DevSM2Cert.AppId,
               TestAccount.DevSM2Cert.AppPrivateKey,
               "json", "1.0", "SM2", "utf-8", false, TestAccount.DevSM2Cert.CertParams);
            AlipayOpenOperationOpenbizmockBizQueryRequest request = GetRequest();

            AlipayOpenOperationOpenbizmockBizQueryResponse response = client.CertificateExecute(request);

            Assert.AreEqual(response.IsError, false);
            Assert.AreEqual(response.Code, "10000");
        }

        private static AlipayOpenOperationOpenbizmockBizQueryRequest GetRequest()
        {
            AlipayOpenOperationOpenbizmockBizQueryRequest request = new AlipayOpenOperationOpenbizmockBizQueryRequest();
            AlipayOpenOperationOpenbizmockBizQueryModel model = new AlipayOpenOperationOpenbizmockBizQueryModel
            {
                BizNo = "test"
            };
            request.SetBizModel(model);
            return request;
        }

        [Test()]
        public void should_be_able_to_send_token()
        {
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.ProdCert.AppId,
                   TestAccount.ProdCert.AppPrivateKey, "json", "1.0", "RSA2", "utf-8", false, TestAccount.ProdCert.CertParams);
            AlipayOpenOperationOpenbizmockBizQueryResponse response = client.CertificateExecute(GetRequest(), "123", "456");
            Assert.AreEqual(response.SubMsg.Contains("无效的应用授权令牌"), true);
        }

        [Test()]
        public void should_auto_download_alipay_public_cert()
        {
            CertParams certParams = TestAccount.ProdCert.CertParams;
            //将支付宝公钥证书路径故意设置成商户证书路径，以便触发自动下载支付宝公钥证书链路
            certParams.AlipayPublicCertPath = certParams.AppCertPath;
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.ProdCert.AppId,
                TestAccount.ProdCert.AppPrivateKey, "json", "1.0", "RSA2", "utf-8", false, certParams);
            AlipayOpenOperationOpenbizmockBizQueryRequest request = GetRequest();

            AlipayOpenOperationOpenbizmockBizQueryResponse response = client.CertificateExecute(request);

            Assert.AreEqual(response.IsError, false);
            Assert.AreEqual(response.Code, "10000");
        }

        //TODO:待相关依赖上线后替换为线上环境测试
        public void should_auto_download_alipay_public_cert_when_use_sm2()
        {
            IAopClient client = new DefaultAopClient(TestAccount.DevSM2Cert.Gateway, TestAccount.DevSM2Cert.AppId,
               TestAccount.DevSM2Cert.AppPrivateKey,
               "json", "1.0", "SM2", "utf-8", false, TestAccount.DevSM2Cert.CertParams);
            AlipayOpenOperationOpenbizmockBizQueryRequest request = GetRequest();

            AlipayOpenOperationOpenbizmockBizQueryResponse response = client.CertificateExecute(request);

            Assert.AreEqual(response.IsError, false);
            Assert.AreEqual(response.Code, "10000");
        }

        [Test()]
        public void should_be_able_to_parse_xml_format_response()
        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.ProdCert.AppId,
                TestAccount.ProdCert.AppPrivateKey, "xml", "1.0", "RSA2", "utf-8", false, TestAccount.ProdCert.CertParams);
            AlipayOpenOperationOpenbizmockBizQueryRequest request = GetRequest();
            //when
            AlipayOpenOperationOpenbizmockBizQueryResponse response = client.CertificateExecute(request);
            //then
            Assert.AreEqual(response.IsError, false);
        }

        [Test()]
        public void should_return_false_when_app_not_set_private_key()
        {
            //given
            //访问线上一个没有设置公私钥对的APP
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.NotSetKeyAppId,
                    TestAccount.ProdCert.AppPrivateKey, "json", "1,0", "RSA2", "utf-8", false, TestAccount.ProdCert.CertParams);
            //when
            AlipayOpenOperationOpenbizmockBizQueryResponse response = client.CertificateExecute(GetRequest());
            //then
            Assert.AreEqual(response.IsError, true);
            Assert.AreEqual(response.SubMsg.Contains("应用未配置对应签名算法的公钥或者证书"), true);
        }

        [Test]
        public void should_get_exeception_when_call_normal_execuet()
        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.ProdCert.AppId,
               TestAccount.ProdCert.AppPrivateKey, "json", "1.0", "RSA2", "utf-8", false, TestAccount.ProdCert.CertParams);
            AlipayOpenOperationOpenbizmockBizQueryRequest request = GetRequest();

            //then
            AopException ex = Assert.Throws<AopException>(() => client.Execute(request));
            Assert.AreEqual(ex.Message.Contains("检测到证书相关参数已初始化，证书模式下请改为调用CertificateExecute。"), true);
        }
    }
}
