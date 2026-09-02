using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceReportinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceReportinfoSyncModel : AopObject
    {
        /// <summary>
        /// 评估时间
        /// </summary>
        [XmlElement("assess_time")]
        public string AssessTime { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 扩展xin'x
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 解读人
        /// </summary>
        [XmlElement("interpretation_person")]
        public string InterpretationPerson { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("out_unique_biz_no")]
        public string OutUniqueBizNo { get; set; }

        /// <summary>
        /// 报告详情json
        /// </summary>
        [XmlElement("report_detail")]
        public string ReportDetail { get; set; }

        /// <summary>
        /// 报告id
        /// </summary>
        [XmlElement("report_id")]
        public string ReportId { get; set; }

        /// <summary>
        /// 报告图片
        /// </summary>
        [XmlElement("report_image")]
        public string ReportImage { get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [XmlElement("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
