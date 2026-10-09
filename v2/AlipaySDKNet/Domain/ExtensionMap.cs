using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtensionMap Data Structure.
    /// </summary>
    [Serializable]
    public class ExtensionMap : AopObject
    {
        /// <summary>
        /// 键值对中的key{"orderDetail":"/order/detail"}中的 orderDetail
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 键值对中的值{"orderDetail":"order/detail"}中的order/detail
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
