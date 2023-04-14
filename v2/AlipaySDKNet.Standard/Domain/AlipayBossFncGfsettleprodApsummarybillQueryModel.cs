using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodApsummarybillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodApsummarybillQueryModel : AopObject
    {
        /// <summary>
        /// 查询
        /// </summary>
        [XmlElement("ap_summary_bill_view_query_order")]
        public ApSummaryBillViewQueryOrder ApSummaryBillViewQueryOrder { get; set; }
    }
}
