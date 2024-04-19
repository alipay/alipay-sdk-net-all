using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateSecondaryItem Data Structure.
    /// </summary>
    [Serializable]
    public class PayForPrivilegeCardTemplateSecondaryItem : AopObject
    {
        /// <summary>
        /// 唯一表示该区域的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 二级区块标题
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 二级区块值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
