using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemOrderBillRefundResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderBillRefundResponse : AopObject
    {
        /// <summary>
        /// 退款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 订单对账退款类型
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }
    }
}
