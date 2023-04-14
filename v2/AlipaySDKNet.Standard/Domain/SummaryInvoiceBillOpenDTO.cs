using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SummaryInvoiceBillOpenDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SummaryInvoiceBillOpenDTO : AopObject
    {
        /// <summary>
        /// 账单流水号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 商户在统一收单链路中透传到支付宝的商户订单号，仅作为透传，非必要
        /// </summary>
        [XmlElement("biz_out_no")]
        public string BizOutNo { get; set; }

        /// <summary>
        /// 账单持有人uid
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 支付类型，可选值：支付-PAY；退款-REFUND
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 退款场景时对应的正向支付单号，当pay_type为REFUND时可取该值，非必须
        /// </summary>
        [XmlElement("related_pay_no")]
        public string RelatedPayNo { get; set; }
    }
}
