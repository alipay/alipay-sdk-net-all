using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportRailwayCouponQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportRailwayCouponQueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("phone_list")]
        [XmlArrayItem("string")]
        public List<string> PhoneList { get; set; }

        /// <summary>
        /// 第三方请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
