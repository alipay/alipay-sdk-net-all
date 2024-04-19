using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourceusageMonthlyQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourceusageMonthlyQueryResponse : AopResponse
    {
        /// <summary>
        /// 各计费项用量列表
        /// </summary>
        [XmlArray("monthly_usages")]
        [XmlArrayItem("monthly_usage")]
        public List<MonthlyUsage> MonthlyUsages { get; set; }
    }
}
