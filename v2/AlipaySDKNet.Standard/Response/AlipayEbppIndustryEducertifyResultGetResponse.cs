using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryEducertifyResultGetResponse.
    /// </summary>
    public class AlipayEbppIndustryEducertifyResultGetResponse : AopResponse
    {
        /// <summary>
        /// 学历认证票据
        /// </summary>
        [XmlElement("certify_token")]
        public string CertifyToken { get; set; }

        /// <summary>
        /// 学历认证结果
        /// </summary>
        [XmlElement("ocr_result")]
        public EduOcrResult OcrResult { get; set; }
    }
}
