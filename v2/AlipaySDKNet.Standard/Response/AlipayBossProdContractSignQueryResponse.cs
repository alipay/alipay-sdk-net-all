using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdContractSignQueryResponse.
    /// </summary>
    public class AlipayBossProdContractSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_title")]
        public string ContractTitle { get; set; }

        /// <summary>
        /// 请求code 200 成功 别的失败 ；失败ErrorCode编码请联系对接技术
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 合同查询结果DTO
        /// </summary>
        [XmlElement("result_data")]
        public ContractQueryDTO ResultData { get; set; }

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
        /// traceId
        /// </summary>
        [XmlElement("result_trace_id")]
        public string ResultTraceId { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }
    }
}
