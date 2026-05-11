using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationCheckInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationCheckInfo : AopObject
    {
        /// <summary>
        /// 检测单ID
        /// </summary>
        [XmlElement("check_no")]
        public string CheckNo { get; set; }

        /// <summary>
        /// 报告信息结合
        /// </summary>
        [XmlArray("report_info_list")]
        [XmlArrayItem("fulfillment_item_pdf_info")]
        public List<FulfillmentItemPdfInfo> ReportInfoList { get; set; }
    }
}
