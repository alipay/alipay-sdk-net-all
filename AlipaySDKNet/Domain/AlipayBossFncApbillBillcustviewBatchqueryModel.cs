using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncApbillBillcustviewBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncApbillBillcustviewBatchqueryModel : AopObject
    {
        /// <summary>
        /// 月账单号列表
        /// </summary>
        [XmlArray("bill_nos")]
        [XmlArrayItem("string")]
        public List<string> BillNos { get; set; }

        /// <summary>
        /// 发票种类{"01":"增值税专用发票","02":"增值税普通发票","05":"其它发票","07":"虚拟发票"}
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }
    }
}
