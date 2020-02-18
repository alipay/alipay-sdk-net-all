using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsDataAutoCoefficientSyncResponse.
    /// </summary>
    public class AlipayInsDataAutoCoefficientSyncResponse : AopResponse
    {
        /// <summary>
        /// 用户唯一请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
