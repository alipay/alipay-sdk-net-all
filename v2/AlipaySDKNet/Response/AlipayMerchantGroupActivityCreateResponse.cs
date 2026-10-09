using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupActivityCreateResponse.
    /// </summary>
    public class AlipayMerchantGroupActivityCreateResponse : AopResponse
    {
        /// <summary>
        /// 商家群活动id
        /// </summary>
        [XmlElement("group_activity_id")]
        public string GroupActivityId { get; set; }
    }
}
