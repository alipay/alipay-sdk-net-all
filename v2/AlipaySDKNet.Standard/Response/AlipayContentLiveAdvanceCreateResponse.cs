using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveAdvanceCreateResponse.
    /// </summary>
    public class AlipayContentLiveAdvanceCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝直播预告id，脱敏返回
        /// </summary>
        [XmlElement("alipay_advance_id")]
        public string AlipayAdvanceId { get; set; }

        /// <summary>
        /// 日志链路id 用于排查问题
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }
    }
}
