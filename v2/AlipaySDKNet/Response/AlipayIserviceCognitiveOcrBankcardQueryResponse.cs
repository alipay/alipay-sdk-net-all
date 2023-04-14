using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrBankcardQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrBankcardQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行卡号
        /// </summary>
        [XmlElement("card_num")]
        public string CardNum { get; set; }

        /// <summary>
        /// 服务器内部请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// true: 识别成功  false: 识别失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
