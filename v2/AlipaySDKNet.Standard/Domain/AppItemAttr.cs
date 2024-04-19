using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemAttr Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemAttr : AopObject
    {
        /// <summary>
        /// 销售属性key（自定义）
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 销售属性value（自定义），字符类型，最长不超过40，相同 key 下不能超过100个不同value。
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
