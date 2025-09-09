using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQcReportCheckItems Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQcReportCheckItems : AopObject
    {
        /// <summary>
        /// 质检项目名
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("recycle_qc_report_check_item")]
        public List<RecycleQcReportCheckItem> Items { get; set; }

        /// <summary>
        /// question_code是问卷中的问题code，attr_name是问题文本描述，两个二选一传入。
        /// </summary>
        [XmlElement("question_code")]
        public string QuestionCode { get; set; }
    }
}
