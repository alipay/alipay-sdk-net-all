using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneContentCommunityHoteventListQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunityHoteventListQueryResponse : AopResponse
    {
        /// <summary>
        /// 存储json序列化后的热门事件列表
        /// </summary>
        [XmlElement("hot_event_product")]
        public string HotEventProduct { get; set; }

        /// <summary>
        /// 返回trace，方便排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
