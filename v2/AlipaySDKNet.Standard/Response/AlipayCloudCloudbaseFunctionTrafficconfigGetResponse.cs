using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionTrafficconfigGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionTrafficconfigGetResponse : AopResponse
    {
        /// <summary>
        /// 流量分配规则列表
        /// </summary>
        [XmlArray("traffic_rules")]
        [XmlArrayItem("traffic_rule")]
        public List<TrafficRule> TrafficRules { get; set; }
    }
}
