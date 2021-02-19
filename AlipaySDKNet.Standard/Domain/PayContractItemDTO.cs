using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayContractItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayContractItemDTO : AopObject
    {
        /// <summary>
        /// 付款条款描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 计划行号会用于发起付款时进行作为幂等字段
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 后付款:POSTPAY_MONEY, 先付款 :PREPAY_MONEY, 质量保证金 :GUARANTEE_MONEY, 预付款 :ADVANCE_MONEY;
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 是否有票
        /// </summary>
        [XmlElement("need_invoice")]
        public bool NeedInvoice { get; set; }

        /// <summary>
        /// 付款申请时间
        /// </summary>
        [XmlElement("pay_apply_date")]
        public string PayApplyDate { get; set; }

        /// <summary>
        /// 付款日期类型， 票到日 ：INVOICE_ARV_DATE 供方开票日 ：INVOICE_BILL_DATE 货到日 ：RCV_DATE 无票 ：NONE
        /// </summary>
        [XmlElement("pay_ref_type")]
        public string PayRefType { get; set; }

        /// <summary>
        /// 付款期限
        /// </summary>
        [XmlElement("pay_term")]
        public long PayTerm { get; set; }

        /// <summary>
        /// 付款期限类型 工作日-WORKING_DAY 自然日-CALENDAR_DAY
        /// </summary>
        [XmlElement("pay_term_type")]
        public string PayTermType { get; set; }

        /// <summary>
        /// 付款金额-元
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 付款阶段
        /// </summary>
        [XmlElement("phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 条款描述内容
        /// </summary>
        [XmlElement("terms")]
        public string Terms { get; set; }
    }
}
