using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellerunsignCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySellerunsignCreateResponse : AopResponse
    {
        /// <summary>
        /// 失败原因码，解约失败时返回
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// trace信息
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 解约结果：true/false
        /// </summary>
        [XmlElement("unsign_result")]
        public bool UnsignResult { get; set; }
    }
}
