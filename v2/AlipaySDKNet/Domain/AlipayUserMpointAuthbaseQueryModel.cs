using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMpointAuthbaseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMpointAuthbaseQueryModel : AopObject
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户的支付宝账户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
