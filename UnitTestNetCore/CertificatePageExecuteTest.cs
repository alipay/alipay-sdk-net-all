using NUnit.Framework;
using System;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;

namespace Test
{
    [TestFixture()]
    public class CertificatPageExecuteTest
    {
        [Test()]
        public void should_return_correct_signed_order_form_contains_root_cert_sn_and_app_cert_sn()
        {
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.ProdCert.AppId,
                TestAccount.ProdCert.AppPrivateKey, "json", "1.0", "RSA2", "utf-8", false, TestAccount.ProdCert.CertParams);
            AlipayTradeWapPayRequest request = new AlipayTradeWapPayRequest();
            request.BizContent = "{" +
            "    \"body\":\"对一笔交易的具体描述信息。如果是多种商品，请将商品描述字符串累加传给body。\"," +
            "    \"subject\":\"大乐透\"," +
            "    \"out_trade_no\":\"70501111111S001111119\"," +
            "    \"timeout_express\":\"90m\"," +
            "    \"total_amount\":9.00," +
            "    \"product_code\":\"QUICK_WAP_WAY\"" +
            "  }";
            AlipayTradeWapPayResponse response = client.pageExecute(request);

            String orderString = response.Body;

            Assert.AreEqual(orderString.Contains("app_cert_sn"), true);
            Assert.AreEqual(orderString.Contains("alipay_root_cert_sn"), true);
        }

        [Test()]
        public void should_return_query_string_contains_root_cert_sn_and_app_cert()
        {
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.ProdCert.AppId,
                 TestAccount.ProdCert.AppPrivateKey, "json", "1.0", "RSA2", "utf-8", false, TestAccount.ProdCert.CertParams);
            AlipayTradeWapPayRequest request = new AlipayTradeWapPayRequest();
            request.BizContent = "{" +
            "    \"body\":\"对一笔交易的具体描述信息。如果是多种商品，请将商品描述字符串累加传给body。\"," +
            "    \"subject\":\"大乐透\"," +
            "    \"out_trade_no\":\"70501111111S001111119\"," +
            "    \"timeout_express\":\"90m\"," +
            "    \"total_amount\":9.00," +
            "    \"product_code\":\"QUICK_WAP_WAY\"" +
            "  }";
            AlipayTradeWapPayResponse response = client.pageExecute(request, "123", "123", "GET");

            String orderString = response.Body;

            Assert.AreEqual(orderString.Contains("app_cert_sn="), true);
            Assert.AreEqual(orderString.Contains("alipay_root_cert_sn="), true);
        }
    }
}
