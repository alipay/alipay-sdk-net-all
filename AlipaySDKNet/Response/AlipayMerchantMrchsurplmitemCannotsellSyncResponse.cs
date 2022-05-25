using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantMrchsurplmitemCannotsellSyncResponse.
    /// </summary>
    public class AlipayMerchantMrchsurplmitemCannotsellSyncResponse : AopResponse
    {
        /// <summary>
        /// 将请求中的ID直接返回
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
