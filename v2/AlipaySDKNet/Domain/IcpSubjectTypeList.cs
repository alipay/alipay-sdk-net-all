using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpSubjectTypeList Data Structure.
    /// </summary>
    [Serializable]
    public class IcpSubjectTypeList : AopObject
    {
        /// <summary>
        /// 单位性质中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 单位性质编码
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
