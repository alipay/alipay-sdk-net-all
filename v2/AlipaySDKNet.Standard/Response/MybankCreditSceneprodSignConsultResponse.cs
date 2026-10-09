using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodSignConsultResponse.
    /// </summary>
    public class MybankCreditSceneprodSignConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否允许签约
        /// </summary>
        [XmlElement("approved")]
        public string Approved { get; set; }

        /// <summary>
        /// 拒绝原因，当approved为false的时候透出
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
