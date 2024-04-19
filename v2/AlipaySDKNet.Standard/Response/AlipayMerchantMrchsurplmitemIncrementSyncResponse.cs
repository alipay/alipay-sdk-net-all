using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantMrchsurplmitemIncrementSyncResponse.
    /// </summary>
    public class AlipayMerchantMrchsurplmitemIncrementSyncResponse : AopResponse
    {
        /// <summary>
        /// 建议调用方打印日志
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
