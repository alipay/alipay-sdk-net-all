using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceData Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceData : AopObject
    {
        /// <summary>
        /// 门禁所属小区编码
        /// </summary>
        [XmlElement("community_code")]
        public string CommunityCode { get; set; }

        /// <summary>
        /// 门禁所属小区名称
        /// </summary>
        [XmlElement("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 设备SN，唯一标识某个门禁设备
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 门禁设备的来源，ISV表示三方服务商的门禁设备，ANT表示蚂蚁的门禁设备，默认为ISV
        /// </summary>
        [XmlElement("device_source")]
        public string DeviceSource { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        [XmlElement("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// 门禁设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 门禁设备的一个定位纬度，传递精度必须保留到小数点后6位。
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门禁设备的一个定位经度，传递精度必须保留到小数点后6位。
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 线圈ID
        /// </summary>
        [XmlElement("nfc_card_id")]
        public string NfcCardId { get; set; }

        /// <summary>
        /// 点位编码
        /// </summary>
        [XmlElement("point_code")]
        public string PointCode { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("point_name")]
        public string PointName { get; set; }

        /// <summary>
        /// 门禁设备开门的响应时间，单位为毫秒(ms)
        /// </summary>
        [XmlElement("response_time")]
        public long ResponseTime { get; set; }
    }
}
