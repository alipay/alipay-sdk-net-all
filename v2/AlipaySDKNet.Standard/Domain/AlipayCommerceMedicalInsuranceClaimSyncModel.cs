using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceClaimSyncModel : AopObject
    {
        /// <summary>
        /// 垫付申请编号
        /// </summary>
        [XmlElement("advance_apply_no")]
        public string AdvanceApplyNo { get; set; }

        /// <summary>
        /// 支付宝垫付申请号
        /// </summary>
        [XmlElement("ant_apply_no")]
        public string AntApplyNo { get; set; }

        /// <summary>
        /// 理赔金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("claim_amount")]
        public string ClaimAmount { get; set; }

        /// <summary>
        /// 理赔详情URL
        /// </summary>
        [XmlElement("claim_detail")]
        public string ClaimDetail { get; set; }

        /// <summary>
        /// 案件号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 理赔状态
        /// </summary>
        [XmlElement("claim_status")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 理赔状态描述，理赔失败时原因描述
        /// </summary>
        [XmlElement("claim_status_desc")]
        public string ClaimStatusDesc { get; set; }

        /// <summary>
        /// 保司类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 打款支付宝账户名，案件状态为打款成功时必传
        /// </summary>
        [XmlElement("pay_account")]
        public string PayAccount { get; set; }

        /// <summary>
        /// 打款时间，案件状态为打款成功时必传
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
