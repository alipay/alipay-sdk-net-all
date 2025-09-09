using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocationPointInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class LocationPointInfoVO : AopObject
    {
        /// <summary>
        /// 绑定的线圈id
        /// </summary>
        [XmlElement("binding_card_id")]
        public string BindingCardId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 所在楼层
        /// </summary>
        [XmlElement("floor_num")]
        public long FloorNum { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 点位描述
        /// </summary>
        [XmlElement("location_desc")]
        public string LocationDesc { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("location_point_id")]
        public string LocationPointId { get; set; }

        /// <summary>
        /// 点位类型 巡检：PATROL 门禁：EC
        /// </summary>
        [XmlElement("location_type")]
        public string LocationType { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 是否多层 是：Y 否：N（默认）
        /// </summary>
        [XmlElement("muti_floor")]
        public string MutiFloor { get; set; }

        /// <summary>
        /// 外部点位id
        /// </summary>
        [XmlElement("out_location_point_id")]
        public string OutLocationPointId { get; set; }
    }
}
