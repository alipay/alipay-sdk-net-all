using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCardCancelResponse.
    /// </summary>
    public class AlipayFundCardCancelResponse : AopResponse
    {
        /// <summary>
        /// 作废流程的流程单据Id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 返回接口执行结果，无业务返回字段
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
