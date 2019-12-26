using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskRiskprofileQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskRiskprofileQueryResponse : AopResponse
    {
        /// <summary>
        /// success 字段为false 是返回失败原因
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// riskprofile查询返回的键值对
        /// </summary>
        [XmlArray("risk_profile_value")]
        [XmlArrayItem("risk_profile_dto")]
        public List<RiskProfileDto> RiskProfileValue { get; set; }

        /// <summary>
        /// 处理结果，true：处理成功，false:处理失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
