using NUnit.Framework;
using System;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;

namespace Test
{
    [TestFixture()]
    public class PageExecuteTest
    {
        [Test()]
        public void should_return_correct_signed_order_form()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,
                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey,
                "utf-8", false);
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
            // 必须拥有正确的签名串
            Assert.AreEqual(orderString.Contains("name='sign'"), true);
        }

        [Test()]
        public void should_return_order_form_with_app_auth_token()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,
                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey,
                "utf-8", false);
            AlipayTradeWapPayRequest request = new AlipayTradeWapPayRequest();
            request.BizContent = "{" +
            "    \"body\":\"对一笔交易的具体描述信息。如果是多种商品，请将商品描述字符串累加传给body。\"," +
            "    \"subject\":\"大乐透\"," +
            "    \"out_trade_no\":\"70501111111S001111119\"," +
            "    \"timeout_express\":\"90m\"," +
            "    \"total_amount\":9.00," +
            "    \"product_code\":\"QUICK_WAP_WAY\"" +
            "  }";
            AlipayTradeWapPayResponse response = client.pageExecute(request, null, "123", "POST");

            String orderString = response.Body;
            //必须含有app_auth_tokne参数，不包含auth_token参数
            Assert.AreEqual(orderString.Contains("name='app_auth_token' value='123'"), true);
            Assert.AreEqual(orderString.Contains("name='auth_token'"), false);
        }

        [Test()]
        public void should_return_order_form_with_access_token()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,
                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey,
                "utf-8", false);
            AlipayTradeWapPayRequest request = new AlipayTradeWapPayRequest();
            request.BizContent = "{" +
            "    \"body\":\"对一笔交易的具体描述信息。如果是多种商品，请将商品描述字符串累加传给body。\"," +
            "    \"subject\":\"大乐透\"," +
            "    \"out_trade_no\":\"70501111111S001111119\"," +
            "    \"timeout_express\":\"90m\"," +
            "    \"total_amount\":9.00," +
            "    \"product_code\":\"QUICK_WAP_WAY\"" +
            "  }";
            AlipayTradeWapPayResponse response = client.pageExecute(request, "123", null, "POST");

            String orderString = response.Body;
            //必须含有auth_tokne参数，不包含app_auth_token参数
            Assert.AreEqual(orderString.Contains("app_auth_token"), false);
            Assert.AreEqual(orderString.Contains("name='auth_token' value='123'"), true);
        }

        [Test()]
        public void should_return_order_form_with_access_token_and_app_auth_token()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,
                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey,
                "utf-8", false);
            AlipayTradeWapPayRequest request = new AlipayTradeWapPayRequest();
            request.BizContent = "{" +
            "    \"body\":\"对一笔交易的具体描述信息。如果是多种商品，请将商品描述字符串累加传给body。\"," +
            "    \"subject\":\"大乐透\"," +
            "    \"out_trade_no\":\"70501111111S001111119\"," +
            "    \"timeout_express\":\"90m\"," +
            "    \"total_amount\":9.00," +
            "    \"product_code\":\"QUICK_WAP_WAY\"" +
            "  }";
            AlipayTradeWapPayResponse response = client.pageExecute(request, "123", "123", "POST");

            String orderString = response.Body;
            //必须含有auth_tokne参数和app_auth_token参数
            Assert.AreEqual(orderString.Contains("name='app_auth_token' value='123'"), true);
            Assert.AreEqual(orderString.Contains("name='auth_token' value='123'"), true);
        }

        [Test()]
        public void should_return_query_string_with_access_token_and_app_auth_token()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,
                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey,
                "utf-8", false);
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
            //必须含有auth_tokne参数和app_auth_token参数
            Assert.AreEqual(orderString.Contains("app_auth_token=123"), true);
            Assert.AreEqual(orderString.Contains("auth_token=123"), true);
        }

        [Test()]
        public void should_return_order_string_with_correct_order_of_parameters()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,
                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey,
                "utf-8", false);
            ParameterCaseMixingRequest request = new ParameterCaseMixingRequest();
            AlipayTradeAppPayResponse response = client.pageExecute(request, null, null, "GET");

            String orderString = response.Body;
            //大写字符必须在小写字符前面
            Assert.AreEqual(orderString.Contains("A=test&a=test"), true);
        }
    }
}
