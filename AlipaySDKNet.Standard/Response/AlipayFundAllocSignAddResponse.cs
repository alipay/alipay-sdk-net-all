using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAllocSignAddResponse.
    /// </summary>
    public class AlipayFundAllocSignAddResponse : AopResponse
    {
        /// <summary>
        /// 用于关联本次请求
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 授权操作链接
        /// </summary>
        [XmlElement("operation_url")]
        public string OperationUrl { get; set; }
    }
}
