using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodInstAuthConsultResponse.
    /// </summary>
    public class MybankCreditSceneprodInstAuthConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("auth")]
        public string Auth { get; set; }

        /// <summary>
        /// 咨询内容返回的结果
        /// </summary>
        [XmlElement("consult_result")]
        public string ConsultResult { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
