using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConversionProperty Data Structure.
    /// </summary>
    [Serializable]
    public class ConversionProperty : AopObject
    {
        /// <summary>
        /// 业务转化数据属性
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 转化属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 业务转化属性实例值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
