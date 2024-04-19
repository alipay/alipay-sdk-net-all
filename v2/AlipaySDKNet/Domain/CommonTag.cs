using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonTag Data Structure.
    /// </summary>
    [Serializable]
    public class CommonTag : AopObject
    {
        /// <summary>
        /// 点评热度
        /// </summary>
        [XmlElement("heat_value")]
        public string HeatValue { get; set; }

        /// <summary>
        /// 点评名称
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
