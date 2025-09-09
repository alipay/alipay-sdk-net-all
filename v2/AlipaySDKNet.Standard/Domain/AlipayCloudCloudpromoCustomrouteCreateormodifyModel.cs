using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoCustomrouteCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoCustomrouteCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 当前坐标经纬度，逗号分隔
        /// </summary>
        [XmlElement("cur_lbs_poi")]
        public string CurLbsPoi { get; set; }

        /// <summary>
        /// 伴游卡片唯一id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 生成自定义路线的景点id列表
        /// </summary>
        [XmlArray("poi_info_id_list")]
        [XmlArrayItem("string")]
        public List<string> PoiInfoIdList { get; set; }

        /// <summary>
        /// 伴游卡片对应的requestId
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 伴游路线id
        /// </summary>
        [XmlElement("route_id")]
        public string RouteId { get; set; }
    }
}
