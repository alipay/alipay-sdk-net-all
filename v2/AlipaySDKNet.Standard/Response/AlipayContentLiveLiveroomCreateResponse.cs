using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveLiveroomCreateResponse.
    /// </summary>
    public class AlipayContentLiveLiveroomCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝直播id
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 日志链路id
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }
    }
}
