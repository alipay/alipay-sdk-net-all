using NUnit.Framework;
using System;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Domain;

namespace Test
{

    [TestFixture()]
    public class SDKExecuteTest
    {
        [Test()]
        public void should_return_correct_signed_order_string()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.GetConfig());
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
            // 必须拥有正确的签名串
            Assert.AreEqual(orderString.Contains("&sign="), true);
        }

        [Test()]
        public void should_return_order_string_with_app_auth_token()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.GetConfig());
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
            String appAuthToken = "123";
            AlipayTradeAppPayResponse response = client.SdkExecute(request, appAuthToken);

            String orderString = response.Body;

            //必须含有app_auth_tokne参数
            Assert.AreEqual(orderString.Contains("app_auth_token=123"), true);
        }

        [Test()]
        public void should_return_order_string_with_udf_parames()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.GetConfig());
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
            request.PutOtherTextParam("test1", "value1");
            request.PutOtherTextParam("test2", "value2");
            AlipayTradeAppPayResponse response = client.SdkExecute(request);

            String orderString = response.Body;

            //必须含有自定义参数
            Assert.AreEqual(orderString.Contains("test1=value1"), true);
            Assert.AreEqual(orderString.Contains("test2=value2"), true);
        }

        [Test()]
        public void should_return_order_string_with_correct_order_of_parameters()
        {
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.GetConfig());
            ParameterCaseMixingRequest request = new ParameterCaseMixingRequest();
            AlipayTradeAppPayResponse response = client.SdkExecute(request);

            String orderString = response.Body;
            //大写字符必须在小写字符前面
            Assert.AreEqual(orderString.Contains("A=test&a=test"), true);
        }
    }
}
