using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceContractdeductUnsignResponse.
    /// </summary>
    public class AlipayEbppInstserviceContractdeductUnsignResponse : AopResponse
    {
        /// <summary>
        /// 代扣流程id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回的结果码描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 操作状态： false-失败 true-成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
