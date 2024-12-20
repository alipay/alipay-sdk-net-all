using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SeriesInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SeriesInfo : AopObject
    {
        /// <summary>
        /// 车系ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
