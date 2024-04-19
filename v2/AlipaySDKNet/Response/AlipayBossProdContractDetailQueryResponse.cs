using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdContractDetailQueryResponse.
    /// </summary>
    public class AlipayBossProdContractDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 请求code 200 成功 别的失败 ；失败ErrorCode编码请联系对接技术
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 合同详细信息
        /// </summary>
        [XmlElement("result_data")]
        public ContractDetailQueryDTO ResultData { get; set; }

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
    }
}
