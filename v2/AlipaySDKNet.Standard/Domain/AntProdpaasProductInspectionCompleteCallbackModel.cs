using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntProdpaasProductInspectionCompleteCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasProductInspectionCompleteCallbackModel : AopObject
    {
        /// <summary>
        /// 生产单据编号，于自检指令创建接口获取。
        /// </summary>
        [XmlElement("ao_no")]
        public string AoNo { get; set; }

        /// <summary>
        /// 不合格原因，由供应商反馈
        /// </summary>
        [XmlElement("defect_reason")]
        public string DefectReason { get; set; }

        /// <summary>
        /// 实际自检完成时间
        /// </summary>
        [XmlElement("feedback_time")]
        public string FeedbackTime { get; set; }

        /// <summary>
        /// 产品自检图URL
        /// </summary>
        [XmlElement("inspection_picture")]
        public string InspectionPicture { get; set; }

        /// <summary>
        /// 自检报告URL
        /// </summary>
        [XmlElement("inspection_report_attachment")]
        public string InspectionReportAttachment { get; set; }

        /// <summary>
        /// 自检结果
        /// </summary>
        [XmlElement("inspection_result")]
        public string InspectionResult { get; set; }

        /// <summary>
        /// 自检单据编号,于自检指令创建接口获取。
        /// </summary>
        [XmlElement("quality_inspection_no")]
        public string QualityInspectionNo { get; set; }

        /// <summary>
        /// 自检数量，单位：件
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("result_remark")]
        public string ResultRemark { get; set; }
    }
}
