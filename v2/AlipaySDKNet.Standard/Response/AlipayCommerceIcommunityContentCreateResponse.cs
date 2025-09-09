using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIcommunityContentCreateResponse.
    /// </summary>
    public class AlipayCommerceIcommunityContentCreateResponse : AopResponse
    {
        /// <summary>
        /// 蓝花火兴趣社区创建的内容的唯一id
        /// </summary>
        [XmlElement("icommunity_content_id")]
        public string IcommunityContentId { get; set; }

        /// <summary>
        /// 入参中填入的外部内容唯一键
        /// </summary>
        [XmlElement("out_content_id")]
        public string OutContentId { get; set; }
    }
}
