using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComponentContextResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ComponentContextResponse : AopObject
    {
        /// <summary>
        /// 查找的目标组件的code，方舟颁发给插件的唯一code
        /// </summary>
        [XmlElement("component_code")]
        public string ComponentCode { get; set; }

        /// <summary>
        /// 方舟提供的一种通用的插件数据传输的机制，插件可以使用该字段进行存储或获取其他插件的数据。
        /// </summary>
        [XmlElement("property_model_map")]
        public string PropertyModelMap { get; set; }
    }
}
