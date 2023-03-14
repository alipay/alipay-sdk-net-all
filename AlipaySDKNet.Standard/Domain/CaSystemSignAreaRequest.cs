using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaSystemSignAreaRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CaSystemSignAreaRequest : AopObject
    {
        /// <summary>
        /// 骑缝章信息
        /// </summary>
        [XmlElement("ca_system_cross_page_request")]
        public CaSystemCrossPageRequest CaSystemCrossPageRequest { get; set; }

        /// <summary>
        /// 正文章信息
        /// </summary>
        [XmlElement("ca_system_main_body_request")]
        public CaSystemMainBodyRequest CaSystemMainBodyRequest { get; set; }

        /// <summary>
        /// TOP_LEFT("TOP_LEFT", "左上角对齐"),     BOTTOM_LEFT("BOTTOM_LEFT", "左下角对齐"),     CENTER("CENTER", "xy值是印章的中心"),     TOP_RIGHT("TOP_RIGHT", "xy值是印章右上角"),     BOTTOM_RIGHT("BOTTOM_RIGHT", "xy值是印章右下角");
        /// </summary>
        [XmlElement("location_type")]
        public string LocationType { get; set; }

        /// <summary>
        /// 签署位置类型，1-正文，2-骑缝
        /// </summary>
        [XmlElement("position_type")]
        public string PositionType { get; set; }

        /// <summary>
        /// 印章id 联系签署中心获取
        /// </summary>
        [XmlElement("seal_id")]
        public string SealId { get; set; }
    }
}
