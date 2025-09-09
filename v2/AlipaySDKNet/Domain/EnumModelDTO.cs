using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnumModelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnumModelDTO : AopObject
    {
        /// <summary>
        /// 一类枚举的值，非小范围枚举类型，无法用枚举全列举出来
        /// </summary>
        [XmlElement("enum_code")]
        public string EnumCode { get; set; }

        /// <summary>
        /// 一类枚举的值，非小范围枚举类型，无法用枚举全列举出来
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 枚举描述
        /// </summary>
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 枚举名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }
    }
}
