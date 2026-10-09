using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolActivityAppitemvoucherModifyResponse.
    /// </summary>
    public class AlipayMarketingToolActivityAppitemvoucherModifyResponse : AopResponse
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
