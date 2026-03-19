using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTrafficcardsCardQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTrafficcardsCardQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("bus_card_list")]
        [XmlArrayItem("traffic_card_info")]
        public List<TrafficCardInfo> BusCardList { get; set; }

        /// <summary>
        /// 公交乘车卡通用描述，可用于前端展示
        /// </summary>
        [XmlElement("bus_scene_desc")]
        public string BusSceneDesc { get; set; }

        /// <summary>
        /// 该字段代表是否查询到有效的乘车卡数据，true代表已查询到有效的乘车卡数据，false代表未查询到
        /// </summary>
        [XmlElement("has_valid_card")]
        public bool HasValidCard { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("metro_card_list")]
        [XmlArrayItem("traffic_card_info")]
        public List<TrafficCardInfo> MetroCardList { get; set; }

        /// <summary>
        /// 地铁乘车卡通用描述，可用于前端展示
        /// </summary>
        [XmlElement("metro_scene_desc")]
        public string MetroSceneDesc { get; set; }
    }
}
