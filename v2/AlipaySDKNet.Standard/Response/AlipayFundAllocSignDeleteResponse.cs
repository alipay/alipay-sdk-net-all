using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAllocSignDeleteResponse.
    /// </summary>
    public class AlipayFundAllocSignDeleteResponse : AopResponse
    {
        /// <summary>
        /// 用于关联本次请求
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 删除操作链接
        /// </summary>
        [XmlElement("operation_url")]
        public string OperationUrl { get; set; }
    }
}
