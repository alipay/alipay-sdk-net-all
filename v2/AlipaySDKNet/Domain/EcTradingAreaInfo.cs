using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcTradingAreaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcTradingAreaInfo : AopObject
    {
        /// <summary>
        /// 商圈的地理位置信息
        /// </summary>
        [XmlElement("location_info")]
        public EcLocationInfo LocationInfo { get; set; }

        /// <summary>
        /// 商圈信息的唯一标识
        /// </summary>
        [XmlElement("trading_area_id")]
        public string TradingAreaId { get; set; }

        /// <summary>
        /// 商圈名称信息
        /// </summary>
        [XmlElement("trading_area_name")]
        public string TradingAreaName { get; set; }
    }
}
