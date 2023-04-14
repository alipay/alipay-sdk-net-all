using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// District Data Structure.
    /// </summary>
    [Serializable]
    public class District : AopObject
    {
        /// <summary>
        /// 行政地区编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 行政地区名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
