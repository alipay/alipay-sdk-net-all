using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyManagerAuthResponse.
    /// </summary>
    public class AlipayCommercePropertyManagerAuthResponse : AopResponse
    {
        /// <summary>
        /// 视频通话页面请求webSocket建联token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }
    }
}
