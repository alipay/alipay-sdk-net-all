using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NRiskDeviceSnapshot Data Structure.
    /// </summary>
    [Serializable]
    public class NRiskDeviceSnapshot : AopObject
    {
        /// <summary>
        /// 描叙商家品牌
        /// </summary>
        [XmlElement("customer_brand")]
        public string CustomerBrand { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public NRiskDeviceSnapshotExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 记录设备最后一次交易时间
        /// </summary>
        [XmlElement("last_trade_time")]
        public string LastTradeTime { get; set; }

        /// <summary>
        /// 记录设备最后一次的开机时间
        /// </summary>
        [XmlElement("last_turn_on_time")]
        public string LastTurnOnTime { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("poi_address")]
        public string PoiAddress { get; set; }

        /// <summary>
        /// 门店POI名称
        /// </summary>
        [XmlElement("poi_name")]
        public string PoiName { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
