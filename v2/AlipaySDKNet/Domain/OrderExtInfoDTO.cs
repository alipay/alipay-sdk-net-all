using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderExtInfoDTO : AopObject
    {
        /// <summary>
        /// 预约时间，字段名称:预约上门取件时间 字段说明:预约上门取件的时间点,时间格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("door_time")]
        public string DoorTime { get; set; }
    }
}
