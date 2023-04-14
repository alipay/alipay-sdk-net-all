using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiPaymentTermsItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiPaymentTermsItemDTO : AopObject
    {
        /// <summary>
        /// 子项id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否有票
        /// </summary>
        [XmlElement("need_invoice")]
        public string NeedInvoice { get; set; }

        /// <summary>
        /// *付款基数      *      * 合同金额:CONTRACT_AMOUNT      *      * 累计产值:ACCUMULATED_ASSET_VALUE      *      * 结算金额:SETTLEMENT_AMOUNT
        /// </summary>
        [XmlElement("pay_base")]
        public string PayBase { get; set; }

        /// <summary>
        /// 付款前置条件,     *      * 预付款保函: PRE-PAYMENT_GUA      *      * 履约保函:PERFORMANCE_GUARA      *      * 质保函:QUALITY_GUARANTEE
        /// </summary>
        [XmlElement("pay_pre_type")]
        public string PayPreType { get; set; }

        /// <summary>
        /// *付款参照类型      *      * INVOICE_ARV_DATE  供应商开票后天数      *      * INVOICE_BILL_DATE 票到期限      *      * NONE 无发票
        /// </summary>
        [XmlElement("pay_ref_type")]
        public string PayRefType { get; set; }

        /// <summary>
        /// *     * 付款期限      *      * invoice_arv_date供应商开票后天数取值于 dayAfterInvoicing      *      * invoice_bill_date票到期限取值于 invoiceDueDate
        /// </summary>
        [XmlElement("pay_term")]
        public string PayTerm { get; set; }

        /// <summary>
        /// 是否自然日付款      *      * 工作日：WORKING_DAY      *      * 自然日：CALENDAR_DAY
        /// </summary>
        [XmlElement("pay_term_type")]
        public string PayTermType { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 支付条款类型     *     * 支付条款类型 对应新模型的term_type，对原模型 lineType + paymentMethod ；      *      * <P>支付条款后付款：<code>POSTPAY_MONEY</code> 对应原来的 <code>lineTyp:SCHEDULE, paymentMethod:POSTPAID</code> ；</P>      *      * <P>支付条款预付款：<code>PREPAY_MONEY</code> 对应原来的 <code>lineTyp:SCHEDULE, paymentMethod:PREPAID</code> ；</P>      *      * <P>质量保证金：<code>lineType:GUARANTEE_MONEY</code> 对应原来的 <code>DEPOSIT</code></P>
        /// </summary>
        [XmlElement("payment_item_type")]
        public string PaymentItemType { get; set; }

        /// <summary>
        /// 付款比例
        /// </summary>
        [XmlElement("payment_percent")]
        public string PaymentPercent { get; set; }

        /// <summary>
        /// 头ID
        /// </summary>
        [XmlElement("payment_terms_id")]
        public string PaymentTermsId { get; set; }

        /// <summary>
        /// 阶段
        /// </summary>
        [XmlElement("phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 条款内容
        /// </summary>
        [XmlElement("terms")]
        public string Terms { get; set; }

        /// <summary>
        /// 条款内容-中文
        /// </summary>
        [XmlElement("terms_cn")]
        public string TermsCn { get; set; }

        /// <summary>
        /// 条款内容-英文
        /// </summary>
        [XmlElement("terms_en")]
        public string TermsEn { get; set; }
    }
}
