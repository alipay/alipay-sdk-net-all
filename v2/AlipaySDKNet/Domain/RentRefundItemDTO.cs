using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRefundItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentRefundItemDTO : AopObject
    {
        /// <summary>
        /// 第几期租金，从1开始
        /// </summary>
        [XmlElement("installment_no")]
        public long InstallmentNo { get; set; }

        /// <summary>
        /// 退款金额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 订单费用类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
