using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HmRefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HmRefundInfo : AopObject
    {
        /// <summary>
        /// 退款金额，单位：分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款路径
        /// </summary>
        [XmlElement("refund_channel")]
        public string RefundChannel { get; set; }

        /// <summary>
        /// 退款时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }
    }
}
