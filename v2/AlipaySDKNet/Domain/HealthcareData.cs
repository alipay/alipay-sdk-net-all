using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthcareData Data Structure.
    /// </summary>
    [Serializable]
    public class HealthcareData : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("check_report_list")]
        [XmlArrayItem("check_report")]
        public List<CheckReport> CheckReportList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("inpatient_record_list")]
        [XmlArrayItem("inpatient_record")]
        public List<InpatientRecord> InpatientRecordList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("outpatient_prescription_list")]
        [XmlArrayItem("outpatient_prescription")]
        public List<OutpatientPrescription> OutpatientPrescriptionList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("outpatient_record_list")]
        [XmlArrayItem("outpatient_record")]
        public List<OutpatientRecord> OutpatientRecordList { get; set; }

        /// <summary>
        /// 文件类型 图片:PIC PDF:PDF
        /// </summary>
        [XmlElement("pic_type")]
        public string PicType { get; set; }

        /// <summary>
        /// 图片或PDF链接
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }
    }
}
