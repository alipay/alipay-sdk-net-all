using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfEnumValueItem Data Structure.
    /// </summary>
    [Serializable]
    public class AxfEnumValueItem : AopObject
    {
        /// <summary>
        /// 枚举值key
        /// </summary>
        [XmlElement("enum_key")]
        public string EnumKey { get; set; }

        /// <summary>
        /// 枚举值对的值
        /// </summary>
        [XmlElement("enum_value")]
        public string EnumValue { get; set; }
    }
}
