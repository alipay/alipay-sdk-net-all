using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParkInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParkInfo : AopObject
    {
        /// <summary>
        /// 停车信息详情
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 停车信息标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 停车信息类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
