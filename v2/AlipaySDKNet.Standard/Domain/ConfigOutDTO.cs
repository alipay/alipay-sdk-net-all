using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConfigOutDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ConfigOutDTO : AopObject
    {
        /// <summary>
        /// 字段信息
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("field_out_d_t_o")]
        public List<FieldOutDTO> Fields { get; set; }

        /// <summary>
        /// 模型编码
        /// </summary>
        [XmlElement("model_code")]
        public string ModelCode { get; set; }

        /// <summary>
        /// 字段属性
        /// </summary>
        [XmlElement("props")]
        public PropertyOutDTO Props { get; set; }
    }
}
