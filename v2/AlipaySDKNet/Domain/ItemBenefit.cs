using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemBenefit Data Structure.
    /// </summary>
    [Serializable]
    public class ItemBenefit : AopObject
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 一级子属性
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 二级子属性
        /// </summary>
        [XmlElement("sub_key")]
        public string SubKey { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
