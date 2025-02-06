using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIcommunityTopicCreateResponse.
    /// </summary>
    public class AlipayCommerceIcommunityTopicCreateResponse : AopResponse
    {
        /// <summary>
        /// 当前话题创建请求传入的外部请求id
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }

        /// <summary>
        /// 创建话题生成的话题唯一标识
        /// </summary>
        [XmlElement("topic_id")]
        public string TopicId { get; set; }
    }
}
