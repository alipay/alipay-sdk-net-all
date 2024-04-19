using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantMrchsurplmitemModificationSyncResponse.
    /// </summary>
    public class AlipayMerchantMrchsurplmitemModificationSyncResponse : AopResponse
    {
        /// <summary>
        /// 建议调用方打印日志
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
