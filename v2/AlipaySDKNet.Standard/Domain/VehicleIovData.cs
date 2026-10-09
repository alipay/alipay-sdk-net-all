using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleIovData Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleIovData : AopObject
    {
        /// <summary>
        /// 车联描述
        /// </summary>
        [XmlElement("iov_desc")]
        public string IovDesc { get; set; }

        /// <summary>
        /// 车联时间戳
        /// </summary>
        [XmlElement("iov_timestamp")]
        public string IovTimestamp { get; set; }

        /// <summary>
        /// 车联数据类型
        /// </summary>
        [XmlElement("iov_type")]
        public string IovType { get; set; }

        /// <summary>
        /// 车联单位
        /// </summary>
        [XmlElement("iov_unit")]
        public string IovUnit { get; set; }

        /// <summary>
        /// 车联数据值
        /// </summary>
        [XmlElement("iov_value")]
        public string IovValue { get; set; }
    }
}
