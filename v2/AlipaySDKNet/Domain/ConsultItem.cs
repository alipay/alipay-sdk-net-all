using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultItem Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultItem : AopObject
    {
        /// <summary>
        /// 咨询属性字段，如license_no(医生执业证号)
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 实际咨询属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
