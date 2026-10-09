using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationChongyaUserNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationChongyaUserNotifyModel : AopObject
    {
        /// <summary>
        /// action用户行为：POINTS_AVAILABLE；POINTS_ CLAIMED
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// openId，支付宝用户openID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户动作对应的参数
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// userId，支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
