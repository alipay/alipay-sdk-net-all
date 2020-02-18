using NUnit.Framework;
using System;
using System.Collections.Generic;
using Aop.Api;
using System.IO;
using System.Text;

namespace Test
{
    [TestFixture()]
    public class AlipayMobilePublicMultiMediaClientTest
    {
        [Test()]
        public void should_send_request_success_with_private_key_from_string()
        {
            //准备客户端参数
            string serverUrl = "https://openfile.alipay.com/chat/multimedia.do";
            string appId = "2013092500031084";
            string privateKeyPem = @"MIICXQIBAAKBgQDIgHnOn7LLILlKETd6BFRJ0GqgS2Y3mn1wMQmyh9zEyWlz5p1z
rahRahbXAfCfSqshSNfqOmAQzSHRVjCqjsAw1jyqrXaPdKBmr90DIpIxmIyKXv4G
GAkPyJ/6FTFY99uhpiq0qadD/uSzQsefWo0aTvP/65zi3eof7TcZ32oWpwIDAQAB
AoGBALrKLjBXyRrCFryxA2zyIZBO0TcaZ1T/4UKm/LDNL9hJB6wJOcBuFTQb0MFn
tkLALmOo2DYHQj4EzS+Xy2jp6pMsvCKG63XbU/7d7w1/ejTYxz+MX4ZzG6Ro5Cmb
pY1inbithQIfN3noK0h+PE7lkvOy43mTR4a+ceAtCh3gU2HpAkEA+XMqxbirmuhj
RtHU4+YAOu0fY3JrXA1oErLiF0tJc1HhsWQuMv8v++peku4wWLhpM/8dpiWmf29z
McXBkNNWDQJBAM3ERi014EzIN91Dkdd6Kl4lfXEG62h0f2j5kvJGcZCTWKMLNyt7
pjVYy4RRrrLLZiyGNqSKTzVDoaNWGGrTxoMCQQDavL54+uKfx7+mTkGcRgdVpLCt
h5vU8HyeSPYw7vfNg7Og1fQdC+CLyox70xnZ8ntt+PuKweEqRhSBRKPj1y3RAkAY
jjzFtnE/GIG6MQ8dhOG7fIPc0jOTsptl3qrPqOJym3Lvei4qTUZHhYI8Fzde9PEL
jTTGLA9JzvliMasWTJGbAkB7UviY/ywp0GYCysV2QJZcakk5QZZ9mJwYJOh6hy6f
BJJ8dq1F4aMRNbw/bTZqJuj4mmZUMrpK0JKeRjjFgzJF";

            //通过各个重载构造函数初始化客户端
            List<IAopClient> clients = new List<IAopClient>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            clients.Add(new AlipayMobilePublicMultiMediaClient(serverUrl, appId, privateKeyPem, false, "json", "GBK"));
            clients.Add(new AlipayMobilePublicMultiMediaClient(serverUrl, appId, privateKeyPem, false, "json", "GBK", "1.0", "RSA"));

            //对每一种构造出的客户端都执行相同的测试
            foreach (IAopClient client in clients)
            {
                //构造request
                AlipayMobilePublicMultiMediaDownloadRequest request = getRequest();

                //执行OpenAPI调用
                AlipayMobilePublicMultiMediaDownloadResponse response = client.Execute(request);

                //断言响应
                Assert.AreEqual(response.Code, "2001");
                Assert.AreEqual(response.Msg, "公众账号信息不存在");

                //释放文件句柄
                request.stream.Close();
            }
        }

        [Test()]
        public void should_send_request_success_with_private_key_from_file()
        {
            //准备客户端参数
            string serverUrl = "https://openfile.alipay.com/chat/multimedia.do";
            string appId = "2013092500031084";
            string privateKeyPem = GetPrivateKeyFilePath();

            //通过各个重载构造函数初始化客户端
            List<IAopClient> clients = new List<IAopClient>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            clients.Add(new AlipayMobilePublicMultiMediaClient(serverUrl, appId, privateKeyPem, true, "json", "GBK"));
            clients.Add(new AlipayMobilePublicMultiMediaClient(serverUrl, appId, privateKeyPem, true, "json", "GBK", "1.0", "RSA"));
            clients.Add(new AlipayMobilePublicMultiMediaClient(serverUrl, appId, privateKeyPem, "json", "GBK"));
            clients.Add(new AlipayMobilePublicMultiMediaClient(serverUrl, appId, privateKeyPem, "json", "GBK", "1.0", "RSA"));

            //对每一种构造出的客户端都执行相同的测试
            foreach (IAopClient client in clients)
            {
                //构造request
                AlipayMobilePublicMultiMediaDownloadRequest request = getRequest();

                //执行OpenAPI调用
                AlipayMobilePublicMultiMediaDownloadResponse response = client.Execute(request);

                //断言响应
                Assert.AreEqual(response.Code, "2001");
                Assert.AreEqual(response.Msg, "公众账号信息不存在");

                //释放文件句柄
                request.stream.Close();
            }
        }

        private AlipayMobilePublicMultiMediaDownloadRequest getRequest()
        {
            AlipayMobilePublicMultiMediaDownloadRequest req = new AlipayMobilePublicMultiMediaDownloadRequest();
            string path = GetTestImagePath();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileStream fs = new FileStream(path, FileMode.CreateNew);
            req.stream = fs;
            string mediaId = "L21pZnMvVDFQV3hYWGJKWFhYYUNucHJYP3Q9YW13ZiZ4c2lnPTU0MzRhYjg1ZTZjNWJmZTMxZGJiNjIzNDdjMzFkNzkw575";
            req.BizContent = "{\"mediaId\":\"" + mediaId + "\"}";
            return req;
        }

        private String GetPrivateKeyFilePath()
        {
            return TestAccount.GetSolutionBasePath() + "/UnitTestNetCore/Fixture/aop-openfile-RSA-private.pem";
        }

        private String GetTestImagePath()
        {
            return TestAccount.GetSolutionBasePath() + "/UnitTestNetCore/Fixture/test-image.png";
        }
    }
}
