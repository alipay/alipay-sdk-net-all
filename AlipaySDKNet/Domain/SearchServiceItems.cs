using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchServiceItems Data Structure.
    /// </summary>
    [Serializable]
    public class SearchServiceItems : AopObject
    {
        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlArray("category_codes")]
        [XmlArrayItem("string")]
        public List<string> CategoryCodes { get; set; }

        /// <summary>
        /// 服务申请单提报关键词
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("string")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
