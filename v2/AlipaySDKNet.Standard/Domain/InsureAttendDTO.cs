using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsureAttendDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsureAttendDTO : AopObject
    {
        /// <summary>
        /// 打卡时间区间代表该时间段内都可以扫码打卡，时间格式强校验，严格按照示例格式传值，中间是 符号是 -
        /// </summary>
        [XmlElement("attend_time")]
        public string AttendTime { get; set; }

        /// <summary>
        /// 打卡时间区间类型
        /// </summary>
        [XmlElement("attend_type")]
        public string AttendType { get; set; }

        /// <summary>
        /// 扫码打卡后的回调地址
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 打卡的经纬度，坐标体系采用GCJ-02 - 国测局坐标，用;作为经度和纬度分割
        /// </summary>
        [XmlElement("coordinates")]
        public string Coordinates { get; set; }

        /// <summary>
        /// 打卡半径，单位m
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }
    }
}
