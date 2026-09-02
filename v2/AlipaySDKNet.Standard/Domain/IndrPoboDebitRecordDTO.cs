using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrPoboDebitRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrPoboDebitRecordDTO : AopObject
    {
        /// <summary>
        /// 学校实际扣款金额
        /// </summary>
        [XmlElement("actual_debit_amount")]
        public IndrMoneyDTO ActualDebitAmount { get; set; }

        /// <summary>
        /// 补缴订单链接,用于多扣补缴场景
        /// </summary>
        [XmlElement("back_payment_order_link")]
        public string BackPaymentOrderLink { get; set; }

        /// <summary>
        /// 金额差错类型
        /// </summary>
        [XmlElement("discrepancy_type")]
        public string DiscrepancyType { get; set; }
    }
}
