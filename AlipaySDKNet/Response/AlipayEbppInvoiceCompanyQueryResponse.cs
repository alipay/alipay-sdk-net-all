using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceCompanyQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceCompanyQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业税务信息
        /// </summary>
        [XmlElement("invoice_company")]
        public InvoiceCompanyInfo InvoiceCompany { get; set; }

        /// <summary>
        /// 支付宝商户ID。当业务前台走支付宝开票系统时，会返回该字段。
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 入驻工单ID
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }
    }
}
