using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatHistoryAddResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAichatHistoryAddResponse : AopResponse
    {
        /// <summary>
        /// 本次请求的的ID，可以用来查询历史记录
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
