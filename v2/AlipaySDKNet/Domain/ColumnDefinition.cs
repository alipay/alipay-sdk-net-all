using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ColumnDefinition Data Structure.
    /// </summary>
    [Serializable]
    public class ColumnDefinition : AopObject
    {
        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [XmlElement("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 列名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 列顺序
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }

        /// <summary>
        /// 是否为主键
        /// </summary>
        [XmlElement("primary_key")]
        public bool PrimaryKey { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }
    }
}
