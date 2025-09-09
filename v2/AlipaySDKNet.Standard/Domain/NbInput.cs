using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NbInput Data Structure.
    /// </summary>
    [Serializable]
    public class NbInput : AopObject
    {
        /// <summary>
        /// 变量名称
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 最大长度，单位字符
        /// </summary>
        [XmlElement("max_length")]
        public long MaxLength { get; set; }

        /// <summary>
        /// 用户输入变量值的自定义下拉选项列表
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("string")]
        public List<string> Options { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 输入类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 变量key
        /// </summary>
        [XmlElement("variable")]
        public string Variable { get; set; }

        /// <summary>
        /// 权重比例，单位百分比
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
