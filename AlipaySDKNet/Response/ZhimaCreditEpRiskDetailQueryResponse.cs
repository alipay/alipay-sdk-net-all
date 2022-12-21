using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRiskDetailQueryResponse.
    /// </summary>
    public class ZhimaCreditEpRiskDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 风险列表
        /// </summary>
        [XmlElement("risk_list")]
        public RiskDoc RiskList { get; set; }

        /// <summary>
        /// 风险合计数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
