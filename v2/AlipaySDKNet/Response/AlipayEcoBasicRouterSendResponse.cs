using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoBasicRouterSendResponse.
    /// </summary>
    public class AlipayEcoBasicRouterSendResponse : AopResponse
    {
        /// <summary>
        /// 路由返回的数据
        /// </summary>
        [XmlElement("res")]
        public string Res { get; set; }
    }
}
