using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppPageBizAttrContent Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppPageBizAttrContent : AopObject
    {
        /// <summary>
        /// 渠道id
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 事由id
        /// </summary>
        [XmlElement("payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// 使用规则id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
