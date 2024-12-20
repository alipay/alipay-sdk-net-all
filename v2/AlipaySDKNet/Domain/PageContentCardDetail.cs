using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PageContentCardDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PageContentCardDetail : AopObject
    {
        /// <summary>
        /// 模板具体数据
        /// </summary>
        [XmlArray("contents")]
        [XmlArrayItem("template_data")]
        public List<TemplateData> Contents { get; set; }

        /// <summary>
        /// 顺序号
        /// </summary>
        [XmlElement("index")]
        public string Index { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
