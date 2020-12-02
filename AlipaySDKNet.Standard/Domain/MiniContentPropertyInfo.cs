using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniContentPropertyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniContentPropertyInfo : AopObject
    {
        /// <summary>
        /// 属性key，必须是平台预先定义的，否则不允许录入
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlArray("value_list")]
        [XmlArrayItem("string")]
        public List<string> ValueList { get; set; }
    }
}
