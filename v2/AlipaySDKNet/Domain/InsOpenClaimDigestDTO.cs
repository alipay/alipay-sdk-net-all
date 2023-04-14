using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenClaimDigestDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenClaimDigestDTO : AopObject
    {
        /// <summary>
        /// 报案时间
        /// </summary>
        [XmlElement("claim_apply_time")]
        public string ClaimApplyTime { get; set; }

        /// <summary>
        /// 核赔时间
        /// </summary>
        [XmlElement("claim_assess_time")]
        public string ClaimAssessTime { get; set; }

        /// <summary>
        /// 销案时间
        /// </summary>
        [XmlElement("claim_cancel_time")]
        public string ClaimCancelTime { get; set; }

        /// <summary>
        /// 赔付金额赔付成功之后有效
        /// </summary>
        [XmlElement("claim_fee")]
        public long ClaimFee { get; set; }

        /// <summary>
        /// 赔案号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 立案时间
        /// </summary>
        [XmlElement("claim_record_time")]
        public string ClaimRecordTime { get; set; }

        /// <summary>
        /// 理赔报案单号
        /// </summary>
        [XmlElement("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 理赔单状态：      INIT  已报案      RECORDED 已立案      RECORD_REJECTED 不予立案      RESOLVED 已结案      REJECTED 已拒赔      ASSESSED 已核赔      CANCELLED 已销案
        /// </summary>
        [XmlElement("claim_status")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 资金打款执行返回码
        /// </summary>
        [XmlElement("fund_result_code")]
        public string FundResultCode { get; set; }

        /// <summary>
        /// 资金打款执行返回描述
        /// </summary>
        [XmlElement("fund_result_desc")]
        public string FundResultDesc { get; set; }

        /// <summary>
        /// 资金打款状态： INIT 初始化       PAID 已支付       CLOSED 已关闭       REFUND 已退款       BOUNCED 已退票
        /// </summary>
        [XmlElement("fund_status")]
        public string FundStatus { get; set; }

        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 产品编码，标识某一类产品：YFX（运费险）
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 拒赔原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
