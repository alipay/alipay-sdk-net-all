using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizInvoiceBillInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BizInvoiceBillInfoDTO : AopObject
    {
        /// <summary>
        /// 金额，单位为各币种的“元”单位，精确到小数点后两位。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 开票描述
        /// </summary>
        [XmlElement("bill_desc")]
        public string BillDesc { get; set; }

        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务单据号列表
        /// </summary>
        [XmlArray("biz_document_nos")]
        [XmlArrayItem("string")]
        public List<string> BizDocumentNos { get; set; }

        /// <summary>
        /// 费用归属OU
        /// </summary>
        [XmlElement("company_info")]
        public CompanyInfoRequestDTO CompanyInfo { get; set; }

        /// <summary>
        /// 创建开票通知到
        /// </summary>
        [XmlElement("create_invoice_notify")]
        public bool CreateInvoiceNotify { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 扣减策略
        /// </summary>
        [XmlElement("deduct_strategy")]
        public string DeductStrategy { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public GfsmartpayExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 幂等Id
        /// </summary>
        [XmlElement("idempotent_id")]
        public string IdempotentId { get; set; }

        /// <summary>
        /// 发票列表
        /// </summary>
        [XmlArray("invoices")]
        [XmlArrayItem("biz_invoice_d_t_o")]
        public List<BizInvoiceDTO> Invoices { get; set; }

        /// <summary>
        /// 是否异步
        /// </summary>
        [XmlElement("is_async")]
        public bool IsAsync { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 关联单据号列表
        /// </summary>
        [XmlArray("related_document_nos")]
        [XmlArrayItem("string")]
        public List<string> RelatedDocumentNos { get; set; }

        /// <summary>
        /// 系统来源
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
