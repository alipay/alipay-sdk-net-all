using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingPaymentSaveResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingPaymentSaveResponse : AopResponse
    {
        /// <summary>
        /// 编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }
    }
}
