using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdContractRiskCreateResponse.
    /// </summary>
    public class AlipayBossProdContractRiskCreateResponse : AopResponse
    {
        /// <summary>
        /// 请求单据号
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        [XmlArray("open_api_contract_risk_result_list")]
        [XmlArrayItem("open_a_p_i_contract_risk_result")]
        public List<OpenAPIContractRiskResult> OpenApiContractRiskResultList { get; set; }

        /// <summary>
        /// 请求处理结果code ，1001 正常
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 接口操作描述(失败原因等)
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 接口执行结果 true 成功 false 失败
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

        /// <summary>
        /// 日志traceId
        /// </summary>
        [XmlElement("result_trace_id")]
        public string ResultTraceId { get; set; }
    }
}
