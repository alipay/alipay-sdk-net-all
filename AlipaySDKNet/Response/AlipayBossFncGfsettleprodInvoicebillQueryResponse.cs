using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoicebillQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodInvoicebillQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票关联的账单
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("invoice_bill_response_page_d_t_o")]
        public List<InvoiceBillResponsePageDTO> ResultSet { get; set; }
    }
}
