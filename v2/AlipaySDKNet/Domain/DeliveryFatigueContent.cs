using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryFatigueContent Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryFatigueContent : AopObject
    {
        /// <summary>
        /// 内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 内容类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 增长展位代码
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
