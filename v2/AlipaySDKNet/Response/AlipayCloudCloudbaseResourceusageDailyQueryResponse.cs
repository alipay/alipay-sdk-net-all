using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourceusageDailyQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourceusageDailyQueryResponse : AopResponse
    {
        /// <summary>
        /// 各计费项用量列表
        /// </summary>
        [XmlArray("daily_usages")]
        [XmlArrayItem("daily_usage")]
        public List<DailyUsage> DailyUsages { get; set; }
    }
}
