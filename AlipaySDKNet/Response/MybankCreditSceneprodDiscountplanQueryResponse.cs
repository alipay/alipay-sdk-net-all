using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodDiscountplanQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodDiscountplanQueryResponse : AopResponse
    {
        /// <summary>
        /// 咨询结果，包含贴息方案的相关信息。
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
