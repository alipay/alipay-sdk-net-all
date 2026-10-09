using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DvcAttrForLocate Data Structure.
    /// </summary>
    [Serializable]
    public class DvcAttrForLocate : AopObject
    {
        /// <summary>
        /// 设备点位蓝牙mac地址
        /// </summary>
        [XmlElement("bluetooth_mac")]
        public string BluetoothMac { get; set; }

        /// <summary>
        /// 门店所在集团ID
        /// </summary>
        [XmlElement("mall_group_cid")]
        public string MallGroupCid { get; set; }

        /// <summary>
        /// 门店所在集团名称
        /// </summary>
        [XmlElement("mall_group_name")]
        public string MallGroupName { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("poi_address")]
        public string PoiAddress { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("poi_city_name")]
        public string PoiCityName { get; set; }

        /// <summary>
        /// 县区
        /// </summary>
        [XmlElement("poi_district_name")]
        public string PoiDistrictName { get; set; }

        /// <summary>
        /// 数字化门店id(digital_poi_id)
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("poi_latitude")]
        public string PoiLatitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("poi_longitude")]
        public string PoiLongitude { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("poi_name")]
        public string PoiName { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("poi_province_name")]
        public string PoiProvinceName { get; set; }

        /// <summary>
        /// 蓝牙上报数据包，根据上报时间取最后一条
        /// </summary>
        [XmlElement("scanned_ble_info")]
        public string ScannedBleInfo { get; set; }

        /// <summary>
        /// CDMA基站上报数据包，根据上报时间取最后一条
        /// </summary>
        [XmlElement("scanned_cdma_info")]
        public string ScannedCdmaInfo { get; set; }

        /// <summary>
        /// GSM基站上报数据包，根据上报时间取最后一条
        /// </summary>
        [XmlElement("scanned_gsm_info")]
        public string ScannedGsmInfo { get; set; }

        /// <summary>
        /// LTE基站上报数据包，根据上报时间取最后一条
        /// </summary>
        [XmlElement("scanned_lte_info")]
        public string ScannedLteInfo { get; set; }

        /// <summary>
        /// WCDMA基站上报数据包，根据上报时间取最后一条
        /// </summary>
        [XmlElement("scanned_wcdma_info")]
        public string ScannedWcdmaInfo { get; set; }

        /// <summary>
        /// wifi上报数据包，根据上报时间取最后一条
        /// </summary>
        [XmlElement("scanned_wifi_info")]
        public string ScannedWifiInfo { get; set; }
    }
}
