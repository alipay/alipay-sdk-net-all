using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodDrawdownApplyResponse.
    /// </summary>
    public class MybankCreditSceneprodDrawdownApplyResponse : AopResponse
    {
        /// <summary>
        /// 序号和支用号的对应关系
        /// </summary>
        [XmlElement("drawdown_list")]
        public string DrawdownList { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
