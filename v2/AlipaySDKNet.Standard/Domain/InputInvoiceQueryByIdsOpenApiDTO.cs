using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceQueryByIdsOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceQueryByIdsOpenApiDTO : AopObject
    {
        /// <summary>
        /// 发票id
        /// </summary>
        [XmlArray("invoice_ids")]
        [XmlArrayItem("number")]
        public List<long> InvoiceIds { get; set; }
    }
}
