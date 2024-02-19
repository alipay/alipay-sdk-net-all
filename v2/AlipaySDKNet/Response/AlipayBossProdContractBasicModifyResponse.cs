using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdContractBasicModifyResponse.
    /// </summary>
    public class AlipayBossProdContractBasicModifyResponse : AopResponse
    {
        /// <summary>
        /// 请求处理结果code
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 更新合同基本信息是否成功
        /// </summary>
        [XmlElement("result_data")]
        public bool ResultData { get; set; }

        /// <summary>
        /// 接口操作描述(失败原因等)
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 接口执行结果
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
