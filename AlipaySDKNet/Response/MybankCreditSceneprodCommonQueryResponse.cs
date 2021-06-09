using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodCommonQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodCommonQueryResponse : AopResponse
    {
        /// <summary>
        /// 请求结果响应说明唯一序号，包含多个字符串
        /// </summary>
        [XmlElement("info")]
        public string Info { get; set; }

        /// <summary>
        /// 支付宝账号不存在。
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 请求是否可重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 请求响应唯一描述
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
