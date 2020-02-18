using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceRiskContentVerifyResponse.
    /// </summary>
    public class SsdataDataserviceRiskContentVerifyResponse : AopResponse
    {
        /// <summary>
        /// 对应传入的每一种风险类型的所有风险识别结果
        /// </summary>
        [XmlArray("risk_result")]
        [XmlArrayItem("risk_result")]
        public List<RiskResult> RiskResult { get; set; }

        /// <summary>
        /// 分值
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 业务唯一识别码
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
