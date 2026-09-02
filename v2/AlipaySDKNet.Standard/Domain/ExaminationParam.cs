using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationParam Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationParam : AopObject
    {
        /// <summary>
        /// 预计出报告结束时间
        /// </summary>
        [XmlElement("expected_report_end_time")]
        public string ExpectedReportEndTime { get; set; }

        /// <summary>
        /// 预计出报告开始时间
        /// </summary>
        [XmlElement("expected_report_start_time")]
        public string ExpectedReportStartTime { get; set; }

        /// <summary>
        /// 外部商品ID集合与pdf链接关系 当前字段已废弃(功能拆分，其他接口上传)
        /// </summary>
        [XmlArray("item_id_to_pdf")]
        [XmlArrayItem("fulfillment_item_pdf_info")]
        public List<FulfillmentItemPdfInfo> ItemIdToPdf { get; set; }

        /// <summary>
        /// 预约码
        /// </summary>
        [XmlElement("verify_code")]
        public string VerifyCode { get; set; }
    }
}
