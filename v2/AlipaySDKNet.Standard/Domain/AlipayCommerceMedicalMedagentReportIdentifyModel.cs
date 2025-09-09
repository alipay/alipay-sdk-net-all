using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentReportIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentReportIdentifyModel : AopObject
    {
        /// <summary>
        /// 报告图片链接
        /// </summary>
        [XmlElement("report_pic_url")]
        public string ReportPicUrl { get; set; }
    }
}
