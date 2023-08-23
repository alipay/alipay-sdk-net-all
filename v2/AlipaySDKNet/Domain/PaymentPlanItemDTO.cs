using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentPlanItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentPlanItemDTO : AopObject
    {
        /// <summary>
        /// ext
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 本条款的摘要信息
        /// </summary>
        [XmlElement("item_digest_cn")]
        public string ItemDigestCn { get; set; }

        /// <summary>
        /// 本条款的摘要信息 英文
        /// </summary>
        [XmlElement("item_digest_en")]
        public string ItemDigestEn { get; set; }

        /// <summary>
        /// 条款行类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 是否有票
        /// </summary>
        [XmlElement("need_invoice")]
        public string NeedInvoice { get; set; }

        /// <summary>
        /// 付款申请日期
        /// </summary>
        [XmlElement("pay_apply_date")]
        public string PayApplyDate { get; set; }

        /// <summary>
        /// 付款参照类型
        /// </summary>
        [XmlElement("pay_ref_type")]
        public string PayRefType { get; set; }

        /// <summary>
        /// 付款期限
        /// </summary>
        [XmlElement("pay_term")]
        public long PayTerm { get; set; }

        /// <summary>
        /// 付款期限类型
        /// </summary>
        [XmlElement("pay_term_type")]
        public string PayTermType { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 付款比例
        /// </summary>
        [XmlElement("payment_percent")]
        public string PaymentPercent { get; set; }

        /// <summary>
        /// 条款明细行ID
        /// </summary>
        [XmlElement("payment_plan_item_id")]
        public string PaymentPlanItemId { get; set; }

        /// <summary>
        /// 阶段
        /// </summary>
        [XmlElement("phase")]
        public long Phase { get; set; }

        /// <summary>
        /// 条款内容
        /// </summary>
        [XmlElement("terms")]
        public string Terms { get; set; }
    }
}
