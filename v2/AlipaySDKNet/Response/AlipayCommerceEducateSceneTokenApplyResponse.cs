using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneTokenApplyResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneTokenApplyResponse : AopResponse
    {
        /// <summary>
        /// 唤起采集组件令牌
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }
    }
}
