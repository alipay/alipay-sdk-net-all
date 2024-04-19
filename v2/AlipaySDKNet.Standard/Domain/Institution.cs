using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Institution Data Structure.
    /// </summary>
    [Serializable]
    public class Institution : AopObject
    {
        /// <summary>
        /// 机构编码（如：人行联行号）
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 机构全称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父级机构编码
        /// </summary>
        [XmlElement("root_code")]
        public string RootCode { get; set; }

        /// <summary>
        /// 父级机构全称
        /// </summary>
        [XmlElement("root_name")]
        public string RootName { get; set; }
    }
}
