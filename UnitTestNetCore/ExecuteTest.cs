using NUnit.Framework;using Aop.Api;using Aop.Api.Request;using Aop.Api.Response;using Aop.Api.Domain;using System.Collections.Generic;namespace Test{    [TestFixture()]    public class ExecuteTest    {
        [Test()]        public void should_return_success_response()        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey, "utf-8", false);            AlipayTradeCreateRequest request = getTradeCreateRequest();
            //when
            AlipayTradeCreateResponse response = client.Execute(request);
            //then
            Assert.AreEqual(response.Code, "10000");        }

        //TODO:待相关依赖上线后替换为线上环境测试
        public void should_return_success_when_use_sm2()
        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.DevSM2.Gateway, TestAccount.DevSM2.AppId,
                TestAccount.DevSM2.AppPrivateKey, "json", "1.0", "SM2",
                TestAccount.DevSM2.AlipayPublicKey, "utf-8", false);
            AlipayOpenOperationOpenbizmockBizQueryRequest request = GetRequest();
            //when
            AlipayOpenOperationOpenbizmockBizQueryResponse response = client.Execute(request);
            //then
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
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey, "utf-8", false);
            AlipayTradeCreateResponse response = client.Execute(getTradeCreateRequest(), "123", "456");
            Assert.AreEqual(response.SubMsg.Contains("无效的应用授权令牌"), true);
        }

        //TODO:待相关依赖上线后替换为线上环境测试
        public void should_be_able_to_send_target_app_id()
        {
            IAopClient client = new DefaultAopClient(TestAccount.DevSpi.Gateway, TestAccount.DevSpi.AppId,
                  TestAccount.DevSpi.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.DevSpi.AlipayPublicKey, "utf-8");

            AlipaySecurityLcTestQueryRequest request = new AlipaySecurityLcTestQueryRequest();
            request.BizContent = "{\"shop_id\":\"1001\",\"user_id\":\"2088X\",\"status\":\"0\"}";
            AlipaySecurityLcTestQueryResponse response = client.Execute(request, null, null, "2018120560475357");
            Assert.AreEqual(response.Code, "20000");
        }

        [Test()]        public void should_return_success_when_request_and_response_encrypted()        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey, "utf-8", TestAccount.Sandbox.AesKey);            AlipayTradeCreateRequest request = getTradeCreateRequest();            request.SetNeedEncrypt(true);
            //when
            AlipayTradeCreateResponse response = client.Execute(request);
            //then
            Assert.AreEqual(response.Code, "10000");        }        [Test()]        public void should_get_correct_response_body()        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,
               TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey,
               "utf-8", false);            AlipayTradeQueryRequest request = new AlipayTradeQueryRequest();            request.BizContent = "{" +            "\"out_trade_no\":\"20150320010101001\"," +            "\"trade_no\":\"2014112611001004680 073956707\"," +            "\"org_pid\":\"2088101117952222\"," +            "      \"query_options\":[" +            "        \"TRADE_SETTE_INFO\"" +            "      ]" +            "  }";
            //when
            AlipayTradeQueryResponse response = client.Execute(request);
            //then
            Assert.AreEqual(response.Body, null);
            //如果Response类中也有同名的Body字段，那么只能用如下方式提取到基类中的Body
            Assert.AreNotEqual(((AopResponse)response).Body, null);        }

        [Test()]
        public void should_be_able_to_parse_xml_format_response()
        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,
               TestAccount.Sandbox.AppPrivateKey, "xml", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey,
               "utf-8", false);
            AlipayTradeCreateRequest request = getTradeCreateRequest();
            //when
            AlipayTradeCreateResponse response = client.Execute(request);
            //then
            Assert.AreEqual(response.IsError, false);
            Assert.AreEqual(response.Code, "10000");
        }

        [Test()]
        public void should_be_able_to_parse_xml_format_response_when_encrypted()
        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,
                TestAccount.Sandbox.AppPrivateKey, "xml", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey,
                "utf-8", TestAccount.Sandbox.AesKey);
            AlipayTradeCreateRequest request = getTradeCreateRequest();
            request.SetNeedEncrypt(true);
            //when
            AlipayTradeCreateResponse response = client.Execute(request);
            //then
            Assert.AreEqual(response.IsError, false);
            Assert.AreEqual(response.Code, "10000");
        }

        [Test()]
        public void should_return_false_when_app_not_set_private_key()
        {
            //given
            //访问线上一个没有设置公私钥对的APP
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.Gateway, TestAccount.NotSetKeyAppId,
                    TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey, "utf-8", false);
            //when
            AlipayTradeCreateResponse response = client.Execute(getTradeCreateRequest());
            //then
            Assert.AreEqual(response.IsError, true);
            Assert.AreEqual(response.SubMsg.Contains("应用未配置对应签名算法的公钥或者证书"), true);
        }

        [Test]
        public void should_get_exception_when_call_cert_execute()
        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey, "utf-8", false);            AlipayTradeCreateRequest request = getTradeCreateRequest();

            //then
            AopException ex = Assert.Throws<AopException>(() => client.CertificateExecute(request));
            Assert.AreEqual(ex.Message.Contains("检测到证书相关参数未初始化，非证书模式下请改为调用Execute"), true);
        }

        private static AlipayTradeCreateRequest getTradeCreateRequest()
        {
            AlipayTradeCreateRequest request = new AlipayTradeCreateRequest();
            AlipayTradeCreateModel model = new AlipayTradeCreateModel();            model.OutTradeNo = "20200320010101006";            model.TotalAmount = "88.88";            model.Subject = "Iphone6 16G";            model.BuyerId = "2088102177846880";            ExtendParams extendParams = new ExtendParams();            extendParams.HbFqNum = "3";            extendParams.HbFqSellerPercent = "100";            model.ExtendParams = extendParams;            request.SetBizModel(model);
            return request;
        }

        [Test]
        public void should_support_complex_object_in_not_biz_content_mode()
        {
            //given
            IAopClient client = new DefaultAopClient(TestAccount.Sandbox.Gateway, TestAccount.Sandbox.AppId,                TestAccount.Sandbox.AppPrivateKey, "json", "1.0", "RSA2", TestAccount.Sandbox.AlipayPublicKey, "utf-8", false);            AlipayOpenMiniVersionAuditApplyRequest request = new AlipayOpenMiniVersionAuditApplyRequest();
            RegionInfo regionInfo = new RegionInfo
            {
                AreaCode = "12345678",
                AreaName = "测试"
            };
            List<RegionInfo> regionList = new List<RegionInfo>
            {
                regionInfo
            };
            request.ServiceRegionInfo = regionList;


            //when
            AlipayOpenMiniVersionAuditApplyResponse response = client.Execute(request);

            //then
            Assert.AreEqual(response.Code, "40006");

        }
    }}