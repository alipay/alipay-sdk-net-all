using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsInvoiceIstdwaybillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsInvoiceIstdwaybillQueryModel : AopObject
    {
        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 开票请求流水号
        /// </summary>
        [XmlElement("out_invoice_request_no")]
        public string OutInvoiceRequestNo { get; set; }
    }
}
