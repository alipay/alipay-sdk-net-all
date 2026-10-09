using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelUserQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userid，2088开头长度为16位的字符串
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
