using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodSumapsummarybillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodSumapsummarybillQueryModel : AopObject
    {
        /// <summary>
        /// AP融合账单查询请求
        /// </summary>
        [XmlElement("ap_summary_bill_view_query_orde")]
        public ApSummaryBillViewQueryOrder ApSummaryBillViewQueryOrde { get; set; }
    }
}
