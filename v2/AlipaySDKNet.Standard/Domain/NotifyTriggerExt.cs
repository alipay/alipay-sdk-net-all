using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NotifyTriggerExt Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyTriggerExt : AopObject
    {
        /// <summary>
        /// 是否默认值
        /// </summary>
        [XmlElement("default_value")]
        public bool DefaultValue { get; set; }

        /// <summary>
        /// 描述字段
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
