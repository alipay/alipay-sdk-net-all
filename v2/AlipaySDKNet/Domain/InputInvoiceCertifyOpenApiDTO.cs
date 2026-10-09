using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceCertifyOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceCertifyOpenApiDTO : AopObject
    {
        /// <summary>
        /// 发票id
        /// </summary>
        [XmlArray("invoice_ids")]
        [XmlArrayItem("number")]
        public List<long> InvoiceIds { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 平台code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 请求幂等号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
