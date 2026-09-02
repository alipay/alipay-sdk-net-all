using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasInvoiceDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasInvoiceDownloadModel : AopObject
    {
        /// <summary>
        /// 发票下载类型1=PDF、2=OFD、3=XML
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// saas平台发票单据号
        /// </summary>
        [XmlElement("saas_invoice_order_no")]
        public string SaasInvoiceOrderNo { get; set; }
    }
}
