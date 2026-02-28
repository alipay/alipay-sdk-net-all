using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SyncStatusItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SyncStatusItemInfo : AopObject
    {
        /// <summary>
        /// 预约截止时间
        /// </summary>
        [XmlElement("appointment_end_time")]
        public string AppointmentEndTime { get; set; }

        /// <summary>
        /// 预约开始时间
        /// </summary>
        [XmlElement("appointment_start_time")]
        public string AppointmentStartTime { get; set; }

        /// <summary>
        /// 影响资料类型，如DICOM、NIFTI等
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }

        /// <summary>
        /// 影像地址
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 项目状态:1:预约成功 2:已核销 3:已检测 8:未预约9:已取消10:报告已出
        /// </summary>
        [XmlElement("item_status")]
        public long ItemStatus { get; set; }

        /// <summary>
        /// 报告地址
        /// </summary>
        [XmlElement("pdf_url")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 出具报告的时间
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }
    }
}
