using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolActivityAppitemvoucherCreateResponse.
    /// </summary>
    public class AlipayMarketingToolActivityAppitemvoucherCreateResponse : AopResponse
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
