using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcgReportDatail Data Structure.
    /// </summary>
    [Serializable]
    public class EcgReportDatail : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 检查结果
        /// </summary>
        [XmlElement("check_result")]
        public string CheckResult { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 医院编码
        /// </summary>
        [XmlElement("hospital_code")]
        public string HospitalCode { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 报告对应图片类型
        /// </summary>
        [XmlElement("pic_type")]
        public string PicType { get; set; }

        /// <summary>
        /// 心电图报告唯一标识
        /// </summary>
        [XmlElement("report_id")]
        public string ReportId { get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [XmlElement("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报告采集时间
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }

        /// <summary>
        /// 报告类型
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 报告上传时间
        /// </summary>
        [XmlElement("report_upload_time")]
        public string ReportUploadTime { get; set; }

        /// <summary>
        /// 报告保存地址
        /// </summary>
        [XmlElement("report_url")]
        public string ReportUrl { get; set; }
    }
}
