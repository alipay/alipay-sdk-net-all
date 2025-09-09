using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeCreateInvoiceRequest Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeCreateInvoiceRequest : AopObject
    {
        /// <summary>
        /// 附件
        /// </summary>
        [XmlElement("email_attachments")]
        public string EmailAttachments { get; set; }

        /// <summary>
        /// 首年维保结束时间
        /// </summary>
        [XmlElement("first_year_warranty_end_date")]
        public string FirstYearWarrantyEndDate { get; set; }

        /// <summary>
        /// 首年维保开始时间
        /// </summary>
        [XmlElement("first_year_warranty_start_date")]
        public string FirstYearWarrantyStartDate { get; set; }

        /// <summary>
        /// 对象
        /// </summary>
        [XmlArray("fxiao_invoice_detail")]
        [XmlArrayItem("fxiao_invoice_detail")]
        public List<FxiaoInvoiceDetail> FxiaoInvoiceDetail { get; set; }

        /// <summary>
        /// 关联的【总代订单】
        /// </summary>
        [XmlElement("general_agency_order_no")]
        public string GeneralAgencyOrderNo { get; set; }

        /// <summary>
        /// 负责人工号
        /// </summary>
        [XmlElement("invoice_owner")]
        public string InvoiceOwner { get; set; }

        /// <summary>
        /// 自增编号
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 关联【报价单】
        /// </summary>
        [XmlElement("quotation_no")]
        public string QuotationNo { get; set; }
    }
}
