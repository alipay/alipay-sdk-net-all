using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHmMedicalReport Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHmMedicalReport : AopObject
    {
        /// <summary>
        /// 用户测量记录表ID
        /// </summary>
        [XmlElement("assessment_record_id")]
        public string AssessmentRecordId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_url_json")]
        [XmlArrayItem("string")]
        public List<string> ReportUrlJson { get; set; }

        /// <summary>
        /// sync_report-体检报告 /  image-上传图片 / file-上传文件
        /// </summary>
        [XmlElement("upload_type")]
        public string UploadType { get; set; }
    }
}
