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
    }
}
