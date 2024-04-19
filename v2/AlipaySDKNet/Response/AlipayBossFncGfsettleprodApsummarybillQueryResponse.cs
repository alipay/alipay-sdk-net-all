using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodApsummarybillQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodApsummarybillQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result_set")]
        public ApSummaryBillPageDTO ResultSet { get; set; }
    }
}
