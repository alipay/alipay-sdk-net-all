using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationMessageHashSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationMessageHashSendModel : AopObject
    {
        /// <summary>
        /// 动态参数
        /// </summary>
        [XmlElement("context")]
        public string Context { get; set; }

        /// <summary>
        /// 哈希后的手机号，行业侧保存和用户的对应关系
        /// </summary>
        [XmlElement("to_mobile_hash")]
        public string ToMobileHash { get; set; }

        /// <summary>
        /// 代表了当时的触发条件，例如余额不足、出账等情况，行业侧会根据触发条件映射成消息模版，同个条件不同人群可能有多套AB策略
        /// </summary>
        [XmlElement("trigger_condition")]
        public string TriggerCondition { get; set; }
    }
}
