using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpCertificateTypeList Data Structure.
    /// </summary>
    [Serializable]
    public class IcpCertificateTypeList : AopObject
    {
        /// <summary>
        /// 证件类型中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 证件类型对应的单位性质编码
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }

        /// <summary>
        /// 证件类型编码
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
