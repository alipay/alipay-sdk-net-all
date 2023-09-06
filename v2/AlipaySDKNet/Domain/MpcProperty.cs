using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcProperty Data Structure.
    /// </summary>
    [Serializable]
    public class MpcProperty : AopObject
    {
        /// <summary>
        /// 属性分类
        /// </summary>
        [XmlElement("property_name")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("property_value")]
        public string PropertyValue { get; set; }
    }
}
