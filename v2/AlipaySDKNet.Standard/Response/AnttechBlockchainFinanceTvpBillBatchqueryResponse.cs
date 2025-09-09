using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpBillBatchqueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTvpBillBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("trust_bill_order")]
        public List<TrustBillOrder> BillList { get; set; }

        /// <summary>
        /// 资金单据总量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
