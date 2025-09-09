using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQcReportSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQcReportSummaryInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("image_id_list")]
        [XmlArrayItem("string")]
        public List<string> ImageIdList { get; set; }

        /// <summary>
        /// 不一致内容的特殊描述
        /// </summary>
        [XmlElement("inconsistent_text")]
        public string InconsistentText { get; set; }

        /// <summary>
        /// 报告总结文本内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
