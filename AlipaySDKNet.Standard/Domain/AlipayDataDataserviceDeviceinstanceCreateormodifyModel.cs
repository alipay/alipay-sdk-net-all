using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDeviceinstanceCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDeviceinstanceCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 楼宇名称
        /// </summary>
        [XmlElement("building_name")]
        public string BuildingName { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("device_instance_ext_info")]
        public string DeviceInstanceExtInfo { get; set; }

        /// <summary>
        /// 设备唯一编号
        /// </summary>
        [XmlElement("device_instance_id")]
        public string DeviceInstanceId { get; set; }

        /// <summary>
        /// 屏幕摆放位置名称
        /// </summary>
        [XmlElement("device_instance_pos_name")]
        public string DeviceInstancePosName { get; set; }

        /// <summary>
        /// 区或者县级市
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 屏幕分辨率高
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 屏幕尺寸
        /// </summary>
        [XmlElement("screen_size")]
        public string ScreenSize { get; set; }

        /// <summary>
        /// 屏幕状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 屏幕分辨率宽
        /// </summary>
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
