using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantIndirectCollectionDetailDataRefund Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantIndirectCollectionDetailDataRefund : AopObject
    {
        /// <summary>
        /// 退款金额(如有退款 必填)
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款时间（精确到秒）
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }
    }
}
