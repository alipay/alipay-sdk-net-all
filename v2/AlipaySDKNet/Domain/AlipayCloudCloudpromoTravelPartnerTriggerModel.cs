using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelPartnerTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoTravelPartnerTriggerModel : AopObject
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
        /// 伴游卡片对应的requestId，可不传
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 伴游路线id
        /// </summary>
        [XmlElement("route_id")]
        public string RouteId { get; set; }

        /// <summary>
        /// 请求来源，枚举有：CUBE、H5
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
