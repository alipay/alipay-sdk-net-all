using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationTopuppointPayConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationTopuppointPayConsultModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 场景值
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
