using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolFeeitemQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseQuotacontrolFeeitemQueryResponse : AopResponse
    {
        /// <summary>
        /// 额度指标列表
        /// </summary>
        [XmlArray("fee_items")]
        [XmlArrayItem("quota_control_metric")]
        public List<QuotaControlMetric> FeeItems { get; set; }
    }
}
