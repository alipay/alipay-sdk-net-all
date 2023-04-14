using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodBillinvoiceQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodBillinvoiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果集
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("bill_invoice_response_d_t_o")]
        public List<BillInvoiceResponseDTO> ResultSet { get; set; }
    }
}
