using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelPartnerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoTravelPartnerQueryModel : AopObject
    {
        /// <summary>
        /// 当前坐标经纬度，逗号分隔
        /// </summary>
        [XmlElement("cur_lbs_poi")]
        public string CurLbsPoi { get; set; }

        /// <summary>
        /// 伴游卡片ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 路线ID
        /// </summary>
        [XmlElement("route_id")]
        public string RouteId { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 微信用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
