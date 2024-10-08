using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoCustomrouteCreateormodifyResponse.
    /// </summary>
    public class AlipayCloudCloudpromoCustomrouteCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 伴游卡片唯一id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 伴游路线列表
        /// </summary>
        [XmlArray("routes")]
        [XmlArrayItem("route_info")]
        public List<RouteInfo> Routes { get; set; }
    }
}
