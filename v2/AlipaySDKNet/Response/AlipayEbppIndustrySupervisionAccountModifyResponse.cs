using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionAccountModifyResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionAccountModifyResponse : AopResponse
    {
        /// <summary>
        /// 商户子户户号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 商户子户状态
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }
    }
}
