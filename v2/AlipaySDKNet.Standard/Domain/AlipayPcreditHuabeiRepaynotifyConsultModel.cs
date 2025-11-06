using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiRepaynotifyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiRepaynotifyConsultModel : AopObject
    {
        /// <summary>
        /// Y表示重试，N表示首次进入
        /// </summary>
        [XmlElement("notify_retry")]
        public string NotifyRetry { get; set; }

        /// <summary>
        /// 场景值
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
