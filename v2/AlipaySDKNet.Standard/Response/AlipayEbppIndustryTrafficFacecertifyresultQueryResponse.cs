using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryTrafficFacecertifyresultQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryTrafficFacecertifyresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 扫脸校验是否通过。true:通过， false:未通过
        /// </summary>
        [XmlElement("verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// 扫脸结果校验id
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
