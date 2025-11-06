using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthReport Data Structure.
    /// </summary>
    [Serializable]
    public class HealthReport : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 唯一id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 数据来源 HNjianxiangjun
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 医院编码
        /// </summary>
        [XmlElement("hospital_org_id")]
        public string HospitalOrgId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("inspection_report_list")]
        [XmlArrayItem("health_inspection_report")]
        public List<HealthInspectionReport> InspectionReportList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("laboratory_report_list")]
        [XmlArrayItem("health_laboratory_report")]
        public List<HealthLaboratoryReport> LaboratoryReportList { get; set; }

        /// <summary>
        /// 结论
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 体检报告id
        /// </summary>
        [XmlElement("report_id")]
        public string ReportId { get; set; }

        /// <summary>
        /// 体检单名称
        /// </summary>
        [XmlElement("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 就诊日期
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }
    }
}
