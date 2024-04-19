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
        /// 商户订单号
        /// </summary>
        [XmlElement("biz_out_no")]
        public string BizOutNo { get; set; }

        /// <summary>
        /// 支付宝用户用户openId
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 账单持有人uid
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 支付单号
        /// </summary>
        [XmlElement("related_pay_no")]
        public string RelatedPayNo { get; set; }
    }
}
