using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NorderTagPositionExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NorderTagPositionExtInfo : AopObject
    {
        /// <summary>
        /// 厂商的品牌信息
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 点位场所
        /// </summary>
        [XmlElement("place")]
        public string Place { get; set; }

        /// <summary>
        /// 点位的场景描述
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
