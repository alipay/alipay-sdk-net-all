using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MetaData Data Structure.
    /// </summary>
    [Serializable]
    public class MetaData : AopObject
    {
        /// <summary>
        /// 元数据code
        /// </summary>
        [XmlElement("meta_data_code")]
        public string MetaDataCode { get; set; }

        /// <summary>
        /// 元数据的描述
        /// </summary>
        [XmlElement("meta_data_desc")]
        public string MetaDataDesc { get; set; }

        /// <summary>
        /// 元数据名称
        /// </summary>
        [XmlElement("meta_data_name")]
        public string MetaDataName { get; set; }

        /// <summary>
        /// 元数据对应的简单类型的值，字符串类型
        /// </summary>
        [XmlElement("simple_value")]
        public string SimpleValue { get; set; }
    }
}
