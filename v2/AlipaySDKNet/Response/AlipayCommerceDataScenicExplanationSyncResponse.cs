using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDataScenicExplanationSyncResponse.
    /// </summary>
    public class AlipayCommerceDataScenicExplanationSyncResponse : AopResponse
    {
        /// <summary>
        /// 成功请求ID。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
