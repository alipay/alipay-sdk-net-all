using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdUserCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdUserCreateResponse : AopResponse
    {
        /// <summary>
        /// 广告系统用户ID
        /// </summary>
        [XmlElement("ad_user_id")]
        public string AdUserId { get; set; }
    }
}
