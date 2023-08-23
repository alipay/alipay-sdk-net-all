using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PropertyOutDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PropertyOutDTO : AopObject
    {
        /// <summary>
        /// 是否禁用
        /// </summary>
        [XmlElement("disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// 是否必须
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 是否展示
        /// </summary>
        [XmlElement("show")]
        public bool Show { get; set; }
    }
}
