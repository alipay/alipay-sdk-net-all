using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskGravityConsultResponse.
    /// </summary>
    public class AlipaySecurityRiskGravityConsultResponse : AopResponse
    {
        /// <summary>
        /// 多方安全风控服务错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 多方安全风控服务错误信息详情
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 参数名：extension+是否唯一：无需唯一+应用场景：多方安全风控标准接口普通扩展参数，用于处理可能存在的小部分标准之外定制化需求+枚举：无枚举+如何获取：多方安全风控与调用方协商+特殊说明：无
        /// </summary>
        [XmlArray("extension")]
        [XmlArrayItem("gravity_param")]
        public List<GravityParam> Extension { get; set; }

        /// <summary>
        /// 参数名：header+是否唯一：无需唯一+应用场景：多方安全风控服务标准头信息，譬如系统间调用的traceId+枚举：无枚举+如何获取：调用方系统随机生成，保证全局唯一+特殊说明：无
        /// </summary>
        [XmlElement("header")]
        public SecGravityServiceHeader Header { get; set; }

        /// <summary>
        /// 多方安全风控服务处理结果是否成功标识：true/false
        /// </summary>
        [XmlElement("process_success")]
        public bool ProcessSuccess { get; set; }

        /// <summary>
        /// 多方安全风控风险咨询结果
        /// </summary>
        [XmlArray("risk_result")]
        [XmlArrayItem("gravity_risk_result")]
        public List<GravityRiskResult> RiskResult { get; set; }
    }
}
