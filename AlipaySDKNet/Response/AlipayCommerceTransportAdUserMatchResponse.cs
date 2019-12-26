using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdUserMatchResponse.
    /// </summary>
    public class AlipayCommerceTransportAdUserMatchResponse : AopResponse
    {
        /// <summary>
        /// 广告投放端用户ID
        /// </summary>
        [XmlElement("ad_user_id")]
        public string AdUserId { get; set; }
    }
}
