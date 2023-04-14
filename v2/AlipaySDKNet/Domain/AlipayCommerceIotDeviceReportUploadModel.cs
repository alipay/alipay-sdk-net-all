using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceReportUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceReportUploadModel : AopObject
    {
        /// <summary>
        /// 设备检测报告详情
        /// </summary>
        [XmlElement("report_content")]
        public string ReportContent { get; set; }

        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
