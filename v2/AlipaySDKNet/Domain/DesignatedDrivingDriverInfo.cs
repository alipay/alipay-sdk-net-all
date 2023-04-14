using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DesignatedDrivingDriverInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DesignatedDrivingDriverInfo : AopObject
    {
        /// <summary>
        /// 司机联系方式，可能是渠道处理后的电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 司机距离当前用户的距离，即司机的经纬度距离用户经纬度的距离
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 代驾司机在渠道方的ID，字符串类型
        /// </summary>
        [XmlElement("driver_id")]
        public string DriverId { get; set; }

        /// <summary>
        /// 代驾司机名称
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机服务年限
        /// </summary>
        [XmlElement("driving_years")]
        public long DrivingYears { get; set; }

        /// <summary>
        /// 司机头像，司机在渠道方的头像，公网可访问的地址
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 代驾渠道在能力中心的唯一code
        /// </summary>
        [XmlElement("isv")]
        public string Isv { get; set; }

        /// <summary>
        /// 司机经纬度信息
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 司机经纬度信息
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 司机代驾服务次数
        /// </summary>
        [XmlElement("service_times")]
        public long ServiceTimes { get; set; }

        /// <summary>
        /// 司机在渠道内的服务级别，服务星级
        /// </summary>
        [XmlElement("star_level")]
        public string StarLevel { get; set; }
    }
}
