using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativityFatigue Data Structure.
    /// </summary>
    [Serializable]
    public class CreativityFatigue : AopObject
    {
        /// <summary>
        /// 展位内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 展位内容类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 疲劳度平台对应id
        /// </summary>
        [XmlElement("fatigue_id")]
        public string FatigueId { get; set; }

        /// <summary>
        /// 展位代码
        /// </summary>
        [XmlElement("space_id")]
        public string SpaceId { get; set; }
    }
}
