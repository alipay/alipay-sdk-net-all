using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfarmUserOrnament Data Structure.
    /// </summary>
    [Serializable]
    public class AntfarmUserOrnament : AopObject
    {
        /// <summary>
        /// 装扮名称
        /// </summary>
        [XmlElement("ornament_name")]
        public string OrnamentName { get; set; }

        /// <summary>
        /// 装扮资源key
        /// </summary>
        [XmlElement("resource_key")]
        public string ResourceKey { get; set; }

        /// <summary>
        /// 挂件
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }
    }
}
