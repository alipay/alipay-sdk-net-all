using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodSumapsummarybillQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodSumapsummarybillQueryResponse : AopResponse
    {
        /// <summary>
        /// 统计金额
        /// </summary>
        [XmlElement("result_set")]
        public ApSumSummaryBillAmountDTO ResultSet { get; set; }
    }
}
