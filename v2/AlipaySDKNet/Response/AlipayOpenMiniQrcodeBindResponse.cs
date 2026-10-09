using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniQrcodeBindResponse.
    /// </summary>
    public class AlipayOpenMiniQrcodeBindResponse : AopResponse
    {
        /// <summary>
        /// 路由规则组，用于唯一标记一条路由规则
        /// </summary>
        [XmlElement("route_group")]
        public string RouteGroup { get; set; }
    }
}
