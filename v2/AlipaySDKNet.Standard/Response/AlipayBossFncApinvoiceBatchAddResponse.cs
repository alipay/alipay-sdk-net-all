using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncApinvoiceBatchAddResponse.
    /// </summary>
    public class AlipayBossFncApinvoiceBatchAddResponse : AopResponse
    {
        /// <summary>
        /// 批量发票关联账单，返回发票id及对应的账单+分配金额
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("ap_invoice_bill_amt_open_api_response")]
        public List<ApInvoiceBillAmtOpenApiResponse> ResultSet { get; set; }
    }
}
