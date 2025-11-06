using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniRefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniRefundInfo : AopObject
    {
        /// <summary>
        /// 退款金额（元）
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }
    }
}
