using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpPartiesDetailsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpPartiesDetailsInfo : AopObject
    {
        /// <summary>
        /// 当事人名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [XmlElement("roles")]
        public string Roles { get; set; }

        /// <summary>
        /// 当事人类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
