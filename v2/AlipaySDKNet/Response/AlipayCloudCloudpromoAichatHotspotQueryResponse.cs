using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatHotspotQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAichatHotspotQueryResponse : AopResponse
    {
        /// <summary>
        /// 热点资讯集
        /// </summary>
        [XmlElement("hotspots")]
        public ChatHotspot Hotspots { get; set; }
    }
}
