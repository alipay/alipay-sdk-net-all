using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenAttributeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenAttributeDTO : AopObject
    {
        /// <summary>
        /// 属性名
        /// </summary>
        [XmlElement("filed_name")]
        public string FiledName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("filed_value")]
        public string FiledValue { get; set; }
    }
}
