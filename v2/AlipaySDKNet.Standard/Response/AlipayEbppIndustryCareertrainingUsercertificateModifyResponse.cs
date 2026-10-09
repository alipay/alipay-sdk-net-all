using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingUsercertificateModifyResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingUsercertificateModifyResponse : AopResponse
    {
        /// <summary>
        /// 编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }
    }
}
