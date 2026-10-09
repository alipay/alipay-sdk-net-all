using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoPartnerAllpoiQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoPartnerAllpoiQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前智能体的id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 伴游记录id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 基于当前位置下一站推荐的景点列表
        /// </summary>
        [XmlElement("next_nearest_poi_list")]
        public PoiInfoVo NextNearestPoiList { get; set; }
    }
}
