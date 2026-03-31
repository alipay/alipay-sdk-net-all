using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreateTextRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CreateTextRequest : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("common_text_list")]
        [XmlArrayItem("common_text_req")]
        public List<CommonTextReq> CommonTextList { get; set; }

        /// <summary>
        /// 是否直接发布
        /// </summary>
        [XmlElement("publish_flag")]
        public bool PublishFlag { get; set; }

        /// <summary>
        /// 工号 例如:xxxxxx
        /// </summary>
        [XmlElement("work_id")]
        public string WorkId { get; set; }
    }
}
