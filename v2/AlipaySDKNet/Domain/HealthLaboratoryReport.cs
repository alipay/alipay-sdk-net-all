using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthLaboratoryReport Data Structure.
    /// </summary>
    [Serializable]
    public class HealthLaboratoryReport : AopObject
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result_info_list")]
        [XmlArrayItem("report_result_info")]
        public List<ReportResultInfo> ResultInfoList { get; set; }
    }
}
