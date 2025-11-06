using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckReport Data Structure.
    /// </summary>
    [Serializable]
    public class CheckReport : AopObject
    {
        /// <summary>
        /// 唯一id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 数据来源
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
        /// 检查报告详情
        /// </summary>
        [XmlElement("inspection_report")]
        public InspectionReport InspectionReport { get; set; }

        /// <summary>
        /// 检验报告详情
        /// </summary>
        [XmlElement("laboratory_report")]
        public LaboratoryReport LaboratoryReport { get; set; }

        /// <summary>
        /// 检验报告id
        /// </summary>
        [XmlElement("report_id")]
        public string ReportId { get; set; }

        /// <summary>
        /// 检验报告名称
        /// </summary>
        [XmlElement("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报告时间
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }

        /// <summary>
        /// 检验报告类型 inspection-检查，laboratory-检验
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }
    }
}
