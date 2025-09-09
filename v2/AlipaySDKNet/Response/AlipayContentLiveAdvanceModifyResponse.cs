using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveAdvanceModifyResponse.
    /// </summary>
    public class AlipayContentLiveAdvanceModifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝直播预告id，脱敏返回
        /// </summary>
        [XmlElement("alipay_advance_id")]
        public string AlipayAdvanceId { get; set; }

        /// <summary>
        /// 日志链路id
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }
    }
}
