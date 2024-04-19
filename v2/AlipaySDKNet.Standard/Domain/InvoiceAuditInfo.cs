using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceAuditInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceAuditInfo : AopObject
    {
        /// <summary>
        /// 发票审核备注信息
        /// </summary>
        [XmlElement("invoice_audit_remark")]
        public string InvoiceAuditRemark { get; set; }

        /// <summary>
        /// 发票审核状态
        /// </summary>
        [XmlElement("invoice_audit_status")]
        public string InvoiceAuditStatus { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票外部索引号
        /// </summary>
        [XmlElement("invoice_out_no")]
        public string InvoiceOutNo { get; set; }
    }
}
