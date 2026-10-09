using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankcustActivityQueryResponse.
    /// </summary>
    public class AlipayUserDtbankcustActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动信息列表
        /// </summary>
        [XmlArray("delivery_activity_infos")]
        [XmlArrayItem("delivery_activity_info")]
        public List<DeliveryActivityInfo> DeliveryActivityInfos { get; set; }

        /// <summary>
        /// lastActivityId后还有没有活动
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 此次查询到的活动数据量
        /// </summary>
        [XmlElement("item_count")]
        public long ItemCount { get; set; }

        /// <summary>
        /// 当前页最后一条数据
        /// </summary>
        [XmlElement("last_activity_id")]
        public string LastActivityId { get; set; }

        /// <summary>
        /// 是否推荐展示
        /// </summary>
        [XmlElement("recommend_display")]
        public bool RecommendDisplay { get; set; }
    }
}
