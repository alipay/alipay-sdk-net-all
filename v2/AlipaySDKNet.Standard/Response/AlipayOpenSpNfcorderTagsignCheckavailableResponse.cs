using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNfcorderTagsignCheckavailableResponse.
    /// </summary>
    public class AlipayOpenSpNfcorderTagsignCheckavailableResponse : AopResponse
    {
        /// <summary>
        /// 唯一签名校验结果，true: uniqueId可用，正常碰请求；false: 签名已经使用或已经过期，非法请求
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
