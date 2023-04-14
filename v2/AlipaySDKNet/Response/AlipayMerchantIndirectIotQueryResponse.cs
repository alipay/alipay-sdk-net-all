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
        /// 内容id，不同物联网平台值类型不一样
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 固定枚举值（阿里云物联网平台：ALIYUN，支付宝物联网平台：SDK）
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
