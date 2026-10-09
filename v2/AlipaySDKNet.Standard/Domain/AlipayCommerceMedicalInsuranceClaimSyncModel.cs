using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceClaimSyncModel : AopObject
    {
        /// <summary>
        /// TPA垫付金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("advance_amount")]
        public string AdvanceAmount { get; set; }

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
        /// 支付宝理赔报案号
        /// </summary>
        [XmlElement("ant_claim_no")]
        public string AntClaimNo { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("business_no")]
        public string BusinessNo { get; set; }

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
        /// 案件号（保司理赔报案号）
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
        /// 理赔发起类型
        /// </summary>
        [XmlElement("claim_type")]
        public string ClaimType { get; set; }

        /// <summary>
        /// 保司类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 申请/补充材料
        /// </summary>
        [XmlArray("identity_materials")]
        [XmlArrayItem("identity_materials")]
        public List<IdentityMaterials> IdentityMaterials { get; set; }

        /// <summary>
        /// 补材场景
        /// </summary>
        [XmlElement("lack_materials_sense")]
        public string LackMaterialsSense { get; set; }

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
        /// 理赔打款金额，打款给用户金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

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
        /// 邮寄信息
        /// </summary>
        [XmlElement("to_send_info")]
        public PostInfo ToSendInfo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
