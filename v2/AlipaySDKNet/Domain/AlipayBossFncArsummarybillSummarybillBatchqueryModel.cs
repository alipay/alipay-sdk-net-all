using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncArsummarybillSummarybillBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncArsummarybillSummarybillBatchqueryModel : AopObject
    {
        /// <summary>
        /// 账单查询请求
        /// </summary>
        [XmlElement("summary_bill_view_query_order")]
        public SummaryBillViewQueryOrder SummaryBillViewQueryOrder { get; set; }
    }
}
