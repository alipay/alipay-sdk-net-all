using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniQrcodePatternCreateResponse.
    /// </summary>
    public class AlipayOpenMiniQrcodePatternCreateResponse : AopResponse
    {
        /// <summary>
        /// 路由规则组，用于唯一标记所创建模式的字段
        /// </summary>
        [XmlElement("route_group")]
        public string RouteGroup { get; set; }
    }
}
