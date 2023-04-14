using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncArsummarybillSummarybillBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncArsummarybillSummarybillBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 汇总账单分页信息
        /// </summary>
        [XmlElement("result_set")]
        public SummaryBillPageOpenApiDTO ResultSet { get; set; }
    }
}
