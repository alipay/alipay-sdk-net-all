using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodPlanQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodPlanQueryResponse : AopResponse
    {
        /// <summary>
        /// 贷款方案内容
        /// </summary>
        [XmlElement("loan_plan")]
        public string LoanPlan { get; set; }

        /// <summary>
        /// 是否离线准入，只有为true的时候loan_plan才会有数据
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
