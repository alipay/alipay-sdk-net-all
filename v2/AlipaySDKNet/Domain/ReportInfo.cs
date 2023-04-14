using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReportInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReportInfo : AopObject
    {
        /// <summary>
        /// 赔案号
        /// </summary>
        [XmlElement("case_no")]
        public string CaseNo { get; set; }

        /// <summary>
        /// 1-已报案，2-已结案，3-已支付
        /// </summary>
        [XmlElement("case_status")]
        public string CaseStatus { get; set; }

        /// <summary>
        /// 赔付次数
        /// </summary>
        [XmlElement("case_times")]
        public string CaseTimes { get; set; }

        /// <summary>
        /// 结案赔款金额，单位元，两位小数
        /// </summary>
        [XmlElement("end_case_amount")]
        public string EndCaseAmount { get; set; }

        /// <summary>
        /// 结案时间，格式：yyyy-mm-dd hh24:mi:ss
        /// </summary>
        [XmlElement("end_case_date")]
        public string EndCaseDate { get; set; }

        /// <summary>
        /// 赔付结论，1赔付 2零结 3商业险拒赔 4整案拒赔 5注销
        /// </summary>
        [XmlElement("indemnity_conclusion")]
        public string IndemnityConclusion { get; set; }

        /// <summary>
        /// 支付成功时间，格式：yyyy-mm-dd hh24:mi:ss
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 险种名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 报案时间，格式：yyyy-mm-dd hh24:mi:ss
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [XmlElement("report_no")]
        public string ReportNo { get; set; }
    }
}
