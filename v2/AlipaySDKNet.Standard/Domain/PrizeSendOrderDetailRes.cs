using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeSendOrderDetailRes Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeSendOrderDetailRes : AopObject
    {
        /// <summary>
        /// 单个奖品金额，单位元。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 发奖奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 发奖orderId
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }

        /// <summary>
        /// 发奖状态
        /// </summary>
        [XmlElement("send_status")]
        public string SendStatus { get; set; }
    }
}
