using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncOutputinvoicePreviewModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncOutputinvoicePreviewModel : AopObject
    {
        /// <summary>
        /// 调用方身份识别标记(应用名称) 与业务单据号联合唯一
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 一般时传你系统的业务单据号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 这张发票要开多少钱
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 有账单开票的情况下此参数必填
        /// </summary>
        [XmlArray("invoice_bill_items")]
        [XmlArrayItem("invoice_bill_item")]
        public List<InvoiceBillItem> InvoiceBillItems { get; set; }

        /// <summary>
        /// 发票票面备注，会打印打发票备注栏
        /// </summary>
        [XmlElement("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 多邮寄地址的情况下可以指定邮寄地址
        /// </summary>
        [XmlElement("mail_id")]
        public string MailId { get; set; }

        /// <summary>
        /// 申请原因，描述申请此次发票的原因，方便以后追溯
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 申请人，商户则填写2088账号内部小儿请写工号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 集团模式可以在次参数内部指定开给那个ipRoleId各开多少钱
        /// </summary>
        [XmlArray("output_apply_invoice_detail_orders")]
        [XmlArrayItem("output_apply_invoice_detail_order")]
        public List<OutputApplyInvoiceDetailOrder> OutputApplyInvoiceDetailOrders { get; set; }

        /// <summary>
        /// 开票申请外部单,外部单据开票时指定
        /// </summary>
        [XmlArray("output_invoice_apply_orders")]
        [XmlArrayItem("invoice_apply_open_api")]
        public List<InvoiceApplyOpenApi> OutputInvoiceApplyOrders { get; set; }

        /// <summary>
        /// 来源系统的名称
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
