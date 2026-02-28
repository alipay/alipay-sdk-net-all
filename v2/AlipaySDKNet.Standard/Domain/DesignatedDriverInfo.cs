using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DesignatedDriverInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DesignatedDriverInfo : AopObject
    {
        /// <summary>
        /// 某个服务商传参异常，此字段用于兜底。正确的需要使用contact_phone字段
        /// </summary>
        [XmlElement("concat_phone")]
        public string ConcatPhone { get; set; }

        /// <summary>
        /// 司机电话 明文传输，不允许为固定电话或其他格式的电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 当前距离，单位：米
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 司机工号
        /// </summary>
        [XmlElement("driver_id")]
        public string DriverId { get; set; }

        /// <summary>
        /// 司机名称，非姓名
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 驾龄
        /// </summary>
        [XmlElement("driving_years")]
        public long DrivingYears { get; set; }

        /// <summary>
        /// 司机照片 司机头像照片地址，公网可访问的地址，图片大小为压缩格式，请尽量减小此文件体积，便于加载。
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 司机纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 司机经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 司机真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 服务次数
        /// </summary>
        [XmlElement("service_times")]
        public long ServiceTimes { get; set; }

        /// <summary>
        /// 司机的星级别 5分制，表示师傅在服务商系统内的服务星级。
        /// </summary>
        [XmlElement("star_lever")]
        public string StarLever { get; set; }
    }
}
