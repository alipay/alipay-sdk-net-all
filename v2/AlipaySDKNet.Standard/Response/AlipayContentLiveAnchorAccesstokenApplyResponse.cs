using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveAnchorAccesstokenApplyResponse.
    /// </summary>
    public class AlipayContentLiveAnchorAccesstokenApplyResponse : AopResponse
    {
        /// <summary>
        /// 鉴权token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 用于全链路排查问题的追踪标识
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }
    }
}
