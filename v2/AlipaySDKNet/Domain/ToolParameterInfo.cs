using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ToolParameterInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ToolParameterInfo : AopObject
    {
        /// <summary>
        /// 是否列表.true为列表
        /// </summary>
        [XmlElement("array")]
        public bool Array { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [XmlElement("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [XmlElement("param_desc")]
        public string ParamDesc { get; set; }

        /// <summary>
        /// 参数名
        /// </summary>
        [XmlElement("param_name")]
        public string ParamName { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        [XmlElement("param_type")]
        public string ParamType { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 对象类型的子参数（key 为子参数名，value 为子参数定义）
        /// </summary>
        [XmlElement("sub_params")]
        public string SubParams { get; set; }
    }
}
