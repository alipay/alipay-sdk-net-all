using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseSummaryinvoicebillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseSummaryinvoicebillQueryModel : AopObject
    {
        /// <summary>
        /// 汇总开票批次ID
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页行数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
