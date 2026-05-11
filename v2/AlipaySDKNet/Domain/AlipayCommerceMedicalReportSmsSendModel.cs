using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalReportSmsSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalReportSmsSendModel : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 报告科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号码,仅支持中国手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 报告数量
        /// </summary>
        [XmlElement("report_count")]
        public string ReportCount { get; set; }

        /// <summary>
        /// 报告id列表(json格式数组)
        /// </summary>
        [XmlElement("report_ids")]
        public string ReportIds { get; set; }

        /// <summary>
        /// 报告出具时间(毫秒级时间戳)
        /// </summary>
        [XmlElement("report_issue_time")]
        public string ReportIssueTime { get; set; }

        /// <summary>
        /// 报告名称(若有多份填最新那份)
        /// </summary>
        [XmlElement("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报告类型;如果是mixed,报告数量则必须>1,否则返回参数错误
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 机构社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }

        /// <summary>
        /// 就诊时间(毫秒级时间戳)
        /// </summary>
        [XmlElement("visit_time")]
        public string VisitTime { get; set; }
    }
}
