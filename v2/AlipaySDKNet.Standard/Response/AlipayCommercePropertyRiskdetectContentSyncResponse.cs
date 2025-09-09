using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyRiskdetectContentSyncResponse.
    /// </summary>
    public class AlipayCommercePropertyRiskdetectContentSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
