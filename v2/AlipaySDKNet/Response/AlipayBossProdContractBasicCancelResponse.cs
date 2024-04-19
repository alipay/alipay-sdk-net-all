using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdContractBasicCancelResponse.
    /// </summary>
    public class AlipayBossProdContractBasicCancelResponse : AopResponse
    {
        /// <summary>
        /// 请求处理结果code 200 正常 错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 合同作废是否成功
        /// </summary>
        [XmlElement("result_data")]
        public bool ResultData { get; set; }

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
        /// trace id
        /// </summary>
        [XmlElement("result_trace_id")]
        public string ResultTraceId { get; set; }
    }
}
