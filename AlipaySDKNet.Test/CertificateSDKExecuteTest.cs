using NUnit.Framework;
using System;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Domain;

namespace Test
{

    [TestFixture()]
    public class CertificatSDKExecuteTest
    {
        [Test()]
        public void should_return_order_string_contains_app_cert_sn_and_root_cert_sn()
        {
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.ProdCert.AppId,
                TestAccount.ProdCert.AppPrivateKey, "json", "1.0", "RSA2", "utf-8", false, TestAccount.ProdCert.CertParams);

            AlipayTradeAppPayRequest request = new AlipayTradeAppPayRequest();
            AlipayTradeAppPayModel model = new AlipayTradeAppPayModel();
            model.Body = "我是测试数据";
            model.Subject = "App支付测试DoNet";
            model.TotalAmount = "0.01";
            model.ProductCode = "QUICK_MSECURITY_PAY";
            model.OutTradeNo = "20170216test01";
            model.TimeoutExpress = "30m";
            request.SetBizModel(model);
            request.SetNotifyUrl("http://www.test.notify");
            AlipayTradeAppPayResponse response = client.SdkExecute(request);

            String orderString = response.Body;

            Assert.AreEqual(orderString.Contains("app_cert_sn="), true);
            Assert.AreEqual(orderString.Contains("alipay_root_cert_sn="), true);
        }
    }
}
