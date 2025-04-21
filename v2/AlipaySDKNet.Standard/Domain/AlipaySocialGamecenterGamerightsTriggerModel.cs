using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialGamecenterGamerightsTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialGamecenterGamerightsTriggerModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 触发权益数量，数量为个
        /// </summary>
        [XmlElement("trigger_right_num")]
        public long TriggerRightNum { get; set; }

        /// <summary>
        /// 触发权益类型
        /// </summary>
        [XmlElement("trigger_right_type")]
        public string TriggerRightType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
