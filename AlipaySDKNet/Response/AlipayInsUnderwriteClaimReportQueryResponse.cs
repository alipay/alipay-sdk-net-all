using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsUnderwriteClaimReportQueryResponse.
    /// </summary>
    public class AlipayInsUnderwriteClaimReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 案件信息
        /// </summary>
        [XmlArray("reports")]
        [XmlArrayItem("ins_claim_report")]
        public List<InsClaimReport> Reports { get; set; }
    }
}
