using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessInfoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessInfoRequest : AopObject
    {
        /// <summary>
        /// 结束时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 场所名称，如房间号：302
        /// </summary>
        [XmlElement("place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// 场所类型，如房间刷脸开门：40002001
        /// </summary>
        [XmlElement("place_type")]
        public string PlaceType { get; set; }

        /// <summary>
        /// 设备编码
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 开始时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 小程序的服务页面url链接 当前字段已废弃(程序中一直未曾使用过)
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
