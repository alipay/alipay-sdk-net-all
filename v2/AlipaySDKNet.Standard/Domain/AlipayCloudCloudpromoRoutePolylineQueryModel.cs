using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoRoutePolylineQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoRoutePolylineQueryModel : AopObject
    {
        /// <summary>
        /// 当前坐标经纬度，逗号分隔
        /// </summary>
        [XmlElement("cur_lbs_poi")]
        public string CurLbsPoi { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        [XmlElement("dest")]
        public string Dest { get; set; }

        /// <summary>
        /// 目的地经纬度
        /// </summary>
        [XmlElement("dest_lbs_poi")]
        public string DestLbsPoi { get; set; }

        /// <summary>
        /// 卡片id；随心游卡片查询必传
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 请求来源，H5表示详情页，返回明细数据；CUBE表示卡片，返回缩略数据
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
