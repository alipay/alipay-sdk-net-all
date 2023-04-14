using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileCheckResponse.
    /// </summary>
    public class AlipayInsScenePetprofilePlatformprofileCheckResponse : AopResponse
    {
        /// <summary>
        /// 宠物照片核验通过后获取的照片URL
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 宠物照片校验结果描述
        /// </summary>
        [XmlElement("verify_desc")]
        public string VerifyDesc { get; set; }

        /// <summary>
        /// 宠物照片校验结果
        /// </summary>
        [XmlElement("verify_result")]
        public bool VerifyResult { get; set; }
    }
}
