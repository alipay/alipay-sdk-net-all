using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApInvoiceBillAmtOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ApInvoiceBillAmtOpenApiResponse : AopObject
    {
        /// <summary>
        /// 发票关联账单金额
        /// </summary>
        [XmlArray("ap_bill_amt_list")]
        [XmlArrayItem("ap_bill_amt_open_api_response")]
        public List<ApBillAmtOpenApiResponse> ApBillAmtList { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
