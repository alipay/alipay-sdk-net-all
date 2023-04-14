using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAccountQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户的支付宝用户号，2088开头。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
