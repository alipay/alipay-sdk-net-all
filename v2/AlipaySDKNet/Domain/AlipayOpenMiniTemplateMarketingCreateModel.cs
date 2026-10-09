using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTemplateMarketingCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTemplateMarketingCreateModel : AopObject
    {
        /// <summary>
        /// 营销活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 消息模板id列表，最多50个模板id
        /// </summary>
        [XmlArray("template_ids")]
        [XmlArrayItem("string")]
        public List<string> TemplateIds { get; set; }

        /// <summary>
        /// 消息运营位名称，不填默认使用券名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
