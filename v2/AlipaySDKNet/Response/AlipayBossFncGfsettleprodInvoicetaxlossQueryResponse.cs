using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoicetaxlossQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodInvoicetaxlossQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票信息
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("invoice_rev_amount_d_t_o")]
        public List<InvoiceRevAmountDTO> ResultSet { get; set; }
    }
}
