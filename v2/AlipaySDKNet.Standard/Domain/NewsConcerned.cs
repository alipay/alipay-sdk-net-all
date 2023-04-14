using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsConcerned Data Structure.
    /// </summary>
    [Serializable]
    public class NewsConcerned : AopObject
    {
        /// <summary>
        /// 是否有打标结果
        /// </summary>
        [XmlElement("has_id")]
        public bool HasId { get; set; }

        /// <summary>
        /// 打标的企业crn
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 详细标签
        /// </summary>
        [XmlArray("label")]
        [XmlArrayItem("news_concerned_label")]
        public List<NewsConcernedLabel> Label { get; set; }

        /// <summary>
        /// 打标的企业名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
