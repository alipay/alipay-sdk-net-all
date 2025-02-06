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
        /// 质检属性名
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("recycle_qc_report_check_item")]
        public List<RecycleQcReportCheckItem> Items { get; set; }
    }
}
