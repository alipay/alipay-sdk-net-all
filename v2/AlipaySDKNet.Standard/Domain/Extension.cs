using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Extension Data Structure.
    /// </summary>
    [Serializable]
    public class Extension : AopObject
    {
        /// <summary>
        /// 扩展描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展显示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 扩展名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 扩展状态
        /// </summary>
        [XmlElement("resource")]
        public ResourceStatus Resource { get; set; }

        /// <summary>
        /// 扩展状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 扩展类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
