using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateComponentListResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateComponentListResponse : AopObject
    {
        /// <summary>
        /// 模板组件对象列表
        /// </summary>
        [XmlArray("component")]
        [XmlArrayItem("component_d_t_o")]
        public List<ComponentDTO> Component { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
