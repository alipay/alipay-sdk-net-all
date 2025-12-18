using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLivePlatformGiftQueryResponse.
    /// </summary>
    public class AlipayContentLivePlatformGiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 追踪trace_id
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("gift_list")]
        [XmlArrayItem("live_gift_item")]
        public List<LiveGiftItem> GiftList { get; set; }
    }
}
