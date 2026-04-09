using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionstoredAiretailriskQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAivisionstoredAiretailriskQueryResponse : AopResponse
    {
        /// <summary>
        /// 风险说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 订单是否有风险
        /// </summary>
        [XmlElement("has_risk")]
        public bool HasRisk { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pics")]
        [XmlArrayItem("string")]
        public List<string> Pics { get; set; }

        /// <summary>
        /// 风险上报时间
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }
    }
}
