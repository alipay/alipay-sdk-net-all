using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectIotQueryResponse.
    /// </summary>
    public class AlipayMerchantIndirectIotQueryResponse : AopResponse
    {
        /// <summary>
        /// 内容id，下发如果是阿里云等平台可以播报的，是一种内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 代表内容id可以播报的平台
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 营销文案
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
