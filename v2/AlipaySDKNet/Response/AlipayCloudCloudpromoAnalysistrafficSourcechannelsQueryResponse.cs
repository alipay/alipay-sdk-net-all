using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysistrafficSourcechannelsQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysistrafficSourcechannelsQueryResponse : AopResponse
    {
        /// <summary>
        /// 经营分析流量分析来源渠道列表返回体
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_traffic_source_channel_v_o")]
        public List<OpenApiTrafficSourceChannelVO> Items { get; set; }
    }
}
