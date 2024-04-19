using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArInvoiceBillLinkOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ArInvoiceBillLinkOpenApiResponse : AopObject
    {
        /// <summary>
        /// 开票金额
        /// </summary>
        [XmlElement("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 应收月账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 创建
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 可开票时间 yyyymm
        /// </summary>
        [XmlElement("inv_rcpt_month")]
        public string InvRcptMonth { get; set; }

        /// <summary>
        /// 发票ID
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票单据ID
        /// </summary>
        [XmlElement("invoice_receipt_id")]
        public string InvoiceReceiptId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 关联明细号
        /// </summary>
        [XmlElement("link_id")]
        public string LinkId { get; set; }

        /// <summary>
        /// 01主站，02芝麻，03金融云
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 已撤回金额
        /// </summary>
        [XmlElement("ret_amt")]
        public MultiCurrencyMoneyOpenApi RetAmt { get; set; }

        /// <summary>
        /// 关联明细状态   Y：有效，N：无效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户机构id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
