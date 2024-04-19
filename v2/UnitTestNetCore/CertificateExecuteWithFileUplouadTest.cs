using NUnit.Framework;
using System;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Util;
using System.IO;

namespace Test
{
    [TestFixture()]
    public class CertificateExecuteWithFileUplouadTest
    {
        [Test()]
        public void should_be_able_to_upload_file()
        {
            IAopClient client = new DefaultAopClient(TestAccount.ProdCert.GetConfig());

            AlipayOfflineMaterialImageUploadRequest request = new AlipayOfflineMaterialImageUploadRequest();
            request.ImageType = "jpg";
            request.ImageName = "海底捞";
            FileItem ImageContent = new FileItem(GetTestImagePath());
            request.ImagePid = "2088021822217233";
            request.ImageContent = ImageContent;
            AlipayOfflineMaterialImageUploadResponse response = client.CertificateExecute(request);

            Assert.AreEqual(response.Body.Contains("ISV权限不足"), true);
        }

        private String GetTestImagePath()
        {
            return TestAccount.GetSolutionBasePath() + "/UnitTestNetCore/Fixture/海底捞.jpg";
        }
    }
}
